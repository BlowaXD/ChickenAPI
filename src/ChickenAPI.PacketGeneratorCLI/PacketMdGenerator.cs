using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ChickenAPI.PacketGeneratorCLI
{
    public class PacketMdGenerator
    {
        private class PacketFile
        {
            public string Header { get; set; }
            public string FilePath { get; set; }
        }

        /// <summary>
        /// Will get packets within the directory and its subdirectories
        /// </summary>
        /// <param name="path"></param>
        /// <param name="originalPath"></param>
        /// <returns></returns>
        private static string GetPackets(string path, string originalPath)
        {
            var dir = new DirectoryInfo(path);
            List<PacketFile> files = (from file in dir.GetFiles("*.cs")
                                      let lines = File.ReadAllLines(file.FullName)
                                      from line in lines
                                      let match = Regex.Match(line, "\\[PacketHeader\\(\\\"([A-Z0-9_-])+\\\"", RegexOptions.IgnoreCase)
                                      where match.Success
                                      let anotherMatch = Regex.Match(match.Value, "\\\"([A-Z0-9_-])+\\\"", RegexOptions.IgnoreCase)
                                      where anotherMatch.Success
                                      let header = Regex.Match(anotherMatch.Value, "(([A-Z0-9_-])+)", RegexOptions.IgnoreCase)
                                      where header.Success
                                      let filePath = originalPath + file.FullName.Substring(dir.FullName.Length + 1)
                                      select new PacketFile { FilePath = filePath, Header = header.Value }).ToList();

            var stringBuilder = new StringBuilder();
            foreach (PacketFile s in files.OrderBy(s => s.Header))
            {
                stringBuilder.AppendLine($"- [x] [{s.Header}]({s.FilePath})");
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Do the café komdirélotr
        /// </summary>
        /// <param name="path"></param>
        public static void DoWork(string path)
        {
            string tmp = "# ChickenAPI Packet list\n\n" +
                "\n## CharacterScreen Packets (only in character selection screen)\n\n" +
                "### Sent by Client\n\n" + GetPackets($"{path}/CharacterScreen/Client", "CharacterScreen/Client/") + "\n\n" +
                "### Sent by Server\n\n" + GetPackets($"{path}/CharacterScreen/Server", "CharacterScreen/Server/") + "\n\n" +
                "## Game Packets (sent/received only in game)\n\n" +
                "### Sent by Client\n\n" + GetPackets($"{path}/Game/Client", "Game/Client/") + "\n\n" +
                "### Sent by Server\n\n" + GetPackets($"{path}/Game/Server", "Game/Server/");
            Console.WriteLine(tmp);
        }
    }
}