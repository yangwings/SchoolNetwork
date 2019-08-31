using SchoolNetwork.Log;
using SchoolNetwork.Regedit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace SchoolNetwork.Config
{
    internal class Configuration
    {
        public LoggingMode LoggingMode { get; set; }
        public string LogPath { get; set; }
        public Dictionary<string, MethodInfo> Dic_type { get; set; }
        public string RunPath { get; set; }
        public ContextMenuRegEdit ContextMenu { get; set; }
        public object MainObject { get; set; }
        public CookieContainer Cookies { get; set; }

        public static Configuration Config { set; get; }

        public object CallMethod(string name,object[] o)
        {
            var j = new object[o.Length + 1];
            o.CopyTo(j, 0);
            j[o.Length] = Config.Cookies;
            return Config.Dic_type[name].Invoke(Config.MainObject,j);
        }
        public static Configuration SetConfig<T>(LoggingMode backMode, string backLogPath) {
            if (Config == null)
            {
                return new Lazy<Configuration>(() =>
                {
                    Configuration config = new Configuration
                    {
                        LoggingMode = backMode,
                        LogPath = backLogPath.EndsWith(@"/") ? backLogPath : backLogPath + @"/",
                        Dic_type = new Dictionary<string, MethodInfo>(),
                        RunPath = Environment.CurrentDirectory+@"\",
                        ContextMenu = new ContextMenuRegEdit(Environment.CurrentDirectory + @"\",Path.GetFileName(Application.ExecutablePath)),
                        MainObject = Activator.CreateInstance(typeof(T)),
                        Cookies = new CookieContainer()

                };
                    Config = config;
                    return Config;
                }, LazyThreadSafetyMode.PublicationOnly).Value;
            }
            else
            {
                return Config;
            }
        }
        

    }
}


