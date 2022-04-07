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
    public class cargarGuardar
    {

        public static partida cargarPartida(int slot)
        {
            partida P = (partida)LoadViaDataContractSerialization<partida>("ranura" + slot + ".xml");

            return P;
        }

        public static void guardarPartida(List<Nivel> niveles, string mapaAnterior, Nivel mapaActual, Jugador jugador, int slot)
        {
            partida P = new partida(niveles, mapaAnterior, mapaActual, jugador);

            SaveViaDataContractSerialization(P, "ranura" + slot + ".xml");
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
