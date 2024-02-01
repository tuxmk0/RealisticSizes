#if EXILED
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace RealisticSizes
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Plugin Enabled?")]
        public bool Debug { get; set; } = false;
        public float MinSize { get; set; } = 0.9f;
        public float MaxSize { get; set; } = 1.1f;

    }
}
#endif