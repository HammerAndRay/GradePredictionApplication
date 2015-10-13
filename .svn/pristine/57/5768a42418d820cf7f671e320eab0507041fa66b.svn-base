using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
namespace CW2_OOD
{
	public class GPAState
	{
		protected XmlDocument doc;
		protected const string DTD = @"
    <!ELEMENT course (level*) >
    <!ATTLIST course name CDATA #REQUIRED >

    <!ELEMENT level (module*) >
    <!ATTLIST level level (4|5|6) #REQUIRED >

    <!ELEMENT module (assessment*) >
    <!ATTLIST module code CDATA #REQUIRED >
    <!ATTLIST module name CDATA #REQUIRED >
    <!ATTLIST module credit CDATA #REQUIRED >

    <!ELEMENT assessment EMPTY >
    <!ATTLIST assessment name CDATA #REQUIRED >
    <!ATTLIST assessment mark CDATA ""n/a"" >
    <!ATTLIST assessment weight CDATA ""n/a"" >
";

		public GPAState()
		{
			this.doc = new XmlDocument();
		}

        public void init()
        {
            doc.AppendChild(doc.CreateDocumentType("course", null, null, DTD));
            XmlElement nc = doc.CreateElement("course");
            XmlAttribute na = doc.CreateAttribute("name");
            nc.Attributes.Append(na);

            doc.AppendChild(nc);
        }

		public bool load(string fpath)
		{
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                XmlReader reader;
                settings.DtdProcessing = DtdProcessing.Parse;
                settings.ValidationType = ValidationType.DTD;

                reader = XmlReader.Create(fpath, settings);

                doc.Load(reader);
                reader.Dispose();
                return true;
            }
            catch (FileNotFoundException ex)
            {
                Console.Out.WriteLine(ex);
            }
            catch (XmlSchemaValidationException ex)
            {
                Console.Out.WriteLine(ex);
            }


            init();
            return false;
		}
		public bool save(string fpath)
		{
            try
            {
                doc.Save(fpath);
                return true;
            }
            catch (IOException ex)
            {
                Console.Out.WriteLine(ex);
                return false;
            }
		}

		public Course getCourse()
		{
			return new Course(doc, doc.DocumentElement);
		}
	}
}

