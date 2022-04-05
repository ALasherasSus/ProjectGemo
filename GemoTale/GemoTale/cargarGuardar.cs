using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GemoTale
{
    internal class cargarGuardar
    {

        public static List<Object> cargarPartida()
        {
            List<Object> objetos = (List<object>)LoadViaDataContractSerialization<Object>("ranura.xml");

            return objetos;

        }

        public static void guardarPartida(List<Nivel> niveles, string mapaAnterior, Nivel mapaActual, Jugador jugador)
        {

            List<Object> objetos = new List<object>();
            objetos.Add(mapaAnterior);
            objetos.Add(mapaActual);
            objetos.Add(jugador);
            objetos.Add(niveles);

            SaveViaDataContractSerialization(objetos, "ranura.xml");

        }

        public static void SaveViaDataContractSerialization<T>(T serializableObject, string filepath)
        {
            var serializer = new DataContractSerializer(typeof(T));
            var settings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t",
            };
            var writer = XmlWriter.Create(filepath, settings);
            serializer.WriteObject(writer, serializableObject);
            writer.Close();
        }


        public static T LoadViaDataContractSerialization<T>(string filepath)
        {
            var fileStream = new FileStream(filepath, FileMode.Open);
            var reader = XmlDictionaryReader.CreateTextReader(fileStream, new XmlDictionaryReaderQuotas());
            var serializer = new DataContractSerializer(typeof(T));
            T serializableObject = (T)serializer.ReadObject(reader, true);
            reader.Close();
            fileStream.Close();
            return serializableObject;
        }

    }

    

}
