using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Application.Files.Xml
{
    public class Xml<T> : IFile<T>
    {
        //TODO implementar IFile
        public bool Read(string file, out T data)
        {
            using (XmlTextReader xmlTextReader = new XmlTextReader(file))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                Xml<T> leerPersona = new Xml<T>();

               if ( leerPersona.Read(file, out data))
                {
                    return true;
                }
                else
                {
                   return false;
                }
                    
                //if (serializer.Deserialize(xmlTextReader, data))
                //{
                //    return true;
                //}
                //return (T)serializer.Deserialize(xmlTextReader);
            }
        }

        public bool Save(string file, T data)
        {
            throw new NotImplementedException();
        }
    }
}
