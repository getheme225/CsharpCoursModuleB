using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PayBookModel
{
    public class XmlCreator
    {
        public static bool SaveXML(object obj, string filename)
        {
           
            using (StreamWriter writer = new StreamWriter(filename))
            {
                try
                {
                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                    ns.Add(".xml", "");
                    XmlSerializer serializer = new XmlSerializer(obj.GetType());
                    serializer.Serialize(writer, obj, ns);
                    
                    return true;
                }
                catch
                {
                    throw new Exception("Ошибка при сохраниеня");
                }
                finally
                {
                    writer.Close();
                }
            }
            
        }
        public static object LoadXml(Type type, string filename)
        {
            object result = null;
            using (StreamReader reader = new StreamReader(filename))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(type);
                    result = serializer.Deserialize(reader);
                }
                catch
                {
                    throw new Exception("Ошибка при Выгрузки данных");
                }
                finally
                {
                    reader.Close();
                }
            }
            return result;
        }

    }
}
