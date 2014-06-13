using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using AddToWunderlistForOutlook.Model;
using XmlSerializer;

namespace AddToWunderlistForOutlook.Model
{
    [Serializable]
    public class Settings
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public string DefaultSaveListId { get; set; }

        public static string SettingsPath
        {
            get
            {
                return string.Format("{0}\\{1}\\{2}\\{3}",
                                     Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                     AssemblyInfo.Company, AssemblyInfo.Product, "settings.xml");
            }
        }

        public static void Serialize(string path, Settings settings)
        {
            try
            {
                if (path != null)
                {
                    var dirInfo = Directory.CreateDirectory(Path.GetDirectoryName(path));
                    if (dirInfo.Exists)
                    {
                        var xml = new XmlObjectSerializer().Serialize(settings);
                        xml.Save(path);
                    }
                }
            }
            catch (IOException e)
            {
                Debug.WriteLine("{0} Serialize IOException error: {1}", AssemblyInfo.Product, e.Message);
            }
        }

        public static Settings Deserialize(string path)
        {
            var settings = new Settings();
            try
            {
                if (File.Exists(path))
                {
                    settings = (Settings)new XmlObjectSerializer().Deserialize(File.ReadAllText(path));
                }
            }
            catch (IOException e)
            {
                Debug.WriteLine("{0} Deserialize IOException error: {1}", AssemblyInfo.Product, e.Message);
            }
            return settings;
        }

    }
}
