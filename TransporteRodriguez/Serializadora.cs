using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TransporteRodriguez
{
    public class Serializadora<T>
    {
        public static void EscribirXML(string path, List<T> gen)
        { 
            try
            {
                using (StreamWriter sw = new StreamWriter(path ,true))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<T>));
                    ser.Serialize(sw, gen);
                }
            }
            catch
            {
                throw new Exception("ERROR al guardar archivo."); 
            }
        }
        public static List<T> LeerXML(string path)
        {
            List<T> lectura;

            using (XmlTextReader sr = new XmlTextReader(path))
            {
               XmlSerializer des = new XmlSerializer(typeof(List<T>));
                lectura = (List<T>)des.Deserialize(sr);
            }
            return lectura;
        }
    }
}
