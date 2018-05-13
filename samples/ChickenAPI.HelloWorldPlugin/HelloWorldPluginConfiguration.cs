using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace ChickenAPI.HelloWorldPlugin
{
    [DataContract]
    public class HelloWorldPluginConfiguration
    {
        [DataMember(Name = "printHeader")]
        public bool PrintHeader = true;
    }
}