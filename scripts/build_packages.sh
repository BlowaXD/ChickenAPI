# /bin/sh

# ChickenAPI.Core
dotnet build -c Release src/ChickenAPI.Core
dotnet pack -c Release src/ChickenAPI.Core --output nupkgs /p:NuspecFile=chickenapi.core.nuspec /p:NuspecBasePath=.

# ChickenAPI.Packets
dotnet build -c Release src/ChickenAPI.Packets
dotnet pack -c Release src/ChickenAPI.Packets --output nupkgs /p:NuspecFile=chickenapi.packets.nuspec /p:NuspecBasePath=.

# ChickenAPI.Enums
dotnet build -c Release src/ChickenAPI.Enums
dotnet pack -c Release src/ChickenAPI.Enums --output nupkgs /p:NuspecFile=chickenapi.enums.nuspec /p:NuspecBasePath=.

# ChickenAPI.Data
dotnet build -c Release src/ChickenAPI.Data
dotnet pack -c Release src/ChickenAPI.Data --output nupkgs /p:NuspecFile=chickenapi.data.nuspec /p:NuspecBasePath=.

# ChickenAPI.Game
dotnet build -c Release src/ChickenAPI.Game
dotnet pack -c Release src/ChickenAPI.Game --output nupkgs /p:NuspecFile=chickenapi.game.nuspec /p:NuspecBasePath=.

# ChickenAPI.Game.Extensions
dotnet build -c Release src/ChickenAPI.Game.Extensions
dotnet pack -c Release src/ChickenAPI.Game.Extensions --output nupkgs /p:NuspecFile=chickenapi.game.extensions.nuspec /p:NuspecBasePath=.