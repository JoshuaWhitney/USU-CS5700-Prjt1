using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Assignment1.IO
{
    public class XmlImportExportStrategy : ImportExporterStrategy
    {

        public override List<Person> Load(string filename)
        {
            List<Person> accounts = null;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>), new Type[] { typeof(Person), typeof(Child), typeof(Adult) });

            if (OpenReader(filename))
            {
                accounts = serializer.Deserialize(Reader) as List<Person>;
                Reader.Close();
            }
            return accounts;
        }

        public override void Save(string filename, List<Person> accounts)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>), new Type[] { typeof(Person), typeof(Child), typeof(Adult) });

            if (OpenWriter(filename))
            {
                serializer.Serialize(Writer, accounts);
                Writer.Close();
            }
        }


    }
}
