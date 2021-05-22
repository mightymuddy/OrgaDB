
using System.Xml;
using System.Diagnostics; 
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace OrgaMS
{
    static class OrgaDatabase
    {
        static string database = "OrgaDatabase";
        static string dataSource = @"..\..\Database\DBOrgaMS.xml";
        static XmlReader xmlReader;
        static XmlWriter xmlWriter;

   
        static bool checkDatabase()
        {
            if (File.Exists(dataSource))
                return true;
            return false;
        }
        static public void InitDatabase()
        {
            LoadDatabase(dataSource);
        }
        static internal void LoadDatabase(string Source)
        {
            if (!checkDatabase())
            {
                Debug.Write("DBOrgaMS.xml doesn't exist");
                if (DialogResult.OK == MessageBox.Show("DatabaseFile is Missing. Should we create another new Database?", "Failure", MessageBoxButtons.OKCancel))
                    
                    
                    File.WriteAllText(dataSource, "New Database");
                else
                    System.Environment.Exit(0);
            }
             
            
        }

        static public void LoadQueryOf(int iFlag)
        {
            xmlReader = XmlReader.Create(dataSource);
            xmlReader.GetAttribute(database);
            xmlReader.Close();
        }

        static public void writeAuftrag(int index, Auftraege item)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Async = true;

            xmlWriter = XmlWriter.Create(dataSource, settings);


            xmlWriter.WriteStartElement("x", "root", "Auftragsliste");
            xmlWriter.WriteStartElement(null, "Auftrag", null);
            xmlWriter.WriteAttributeString(null, "ID", null, index.ToString());
            
            xmlWriter.WriteStartElement(null, "Title", null);
            xmlWriter.WriteAttributeString(null, "title", null, item.Titel);
            xmlWriter.WriteString(item.Titel);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement(null, "Kategorie", null);
            xmlWriter.WriteAttributeString(null, "Kat", null, item.Kategorie.ToString());
            xmlWriter.WriteString(item.Kategorie.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement(null, "Erstelldatum", null);
            xmlWriter.WriteAttributeString(null, "date", null, item.ErstellDatum.ToString());
            xmlWriter.WriteString(item.ErstellDatum.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement(null, "KundenNr", null);
            xmlWriter.WriteAttributeString(null, "KuNr", null, item.KuNr.ToString());
            xmlWriter.WriteString(item.KuNr.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement(null, "Beschreibung", null);
            xmlWriter.WriteString(item.Beschreibung);
            xmlWriter.WriteEndElement();


            xmlWriter.WriteEndElement();

            xmlWriter.Flush();
            xmlWriter.Close();


        }


    }
}
