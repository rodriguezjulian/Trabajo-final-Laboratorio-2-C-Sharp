using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransporteRodriguez
{
    public class Serializadora<T>
    {
        public static void EscribirXML(string path, string nombreDeArchivo, T gen)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path + nombreDeArchivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(sw, gen);
                }
            }
            catch
            {
                throw new Exception("ERROR al guardar archivo."); 
            }

        }
        public static void LeerXML(string path)
        {
            T lectura;
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(T));
                lectura = (T)des.Deserialize(sr);
            }
      
        }

    }
}
