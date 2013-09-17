using PluginFramework.Interface;
using System;
using System.IO;

namespace PluginFramework
{
    public class PluginConfiguration
    {
        private string path;
        private string typeName;

        public PluginConfiguration(string path, string typeName)
        {
            this.path = path;
            this.typeName = typeName;
        }

        public IPlugin LoadPlugin()
        {
            var assembly = AppDomain.CurrentDomain.Load(File.ReadAllBytes(this.path));
            return (IPlugin)Activator.CreateInstance(assembly.GetType(this.typeName));
        }
    }
}
