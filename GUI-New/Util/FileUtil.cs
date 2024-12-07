using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_New.Util
{
    public class FileUtil
    {
        public JObject getJsonFile(string basePath, string relativePath, string fileName)
        {
            JObject configJson = new JObject();
            string real_file_path = basePath + relativePath + fileName;
            if (!File.Exists(real_file_path))
            {
                return configJson;
            }
            try
            {
                string configContent = File.ReadAllText(real_file_path);
                configJson = JObject.Parse(configContent);

            }
            catch (Exception ex){}
            return configJson;
        }
    }
}
