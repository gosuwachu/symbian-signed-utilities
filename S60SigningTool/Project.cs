using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace S60SigningTool
{
    [Serializable]
    class Project : ISerializable 
    {
        public string FilePath;
        public string Output;
        public string Certificate;
        public string Key;
        public bool Unsign;

        public static void Serialize(string filePath, Project project)
        {
            Stream stream = File.Open(filePath, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, project);
            stream.Close();
        }

        public static Project Deserialize(string filePath)
        {
            Stream stream = File.Open(filePath, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
                    
            Project project = (Project)formatter.Deserialize(stream);
            stream.Close();
                        
            return project;
        }

        public Project()
        {
        }

        public Project(SerializationInfo info, StreamingContext context)
        {
            FilePath = info.GetString("filePath");
            Output = info.GetString("output");
            Certificate = info.GetString("certificate");
            Key = info.GetString("key");
            Unsign = info.GetBoolean("unsign");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("filePath", FilePath);
            info.AddValue("output", Output);
            info.AddValue("certificate", Certificate);
            info.AddValue("key", Key);
            info.AddValue("unsign", Unsign);
        }
    }
}
