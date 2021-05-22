using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgaMS
{
    class Auftraege
    {


        private int iAuftrNr;
        private string strTitle;
        private int AuftragsKategorie;
        private DateTime dtErstelldatum;
        private int iKuNr;
        private string strDescription;


        internal Auftraege(int iAuftr = 0, string sTitle = "", int kat = 0, DateTime date = new DateTime(),
                    int iKN = 0, string sDesc = "")
        {
            iAuftrNr = iAuftr;
            strTitle = sTitle;
            AuftragsKategorie = kat;
            dtErstelldatum = date;
            iKuNr = iKN;
            strDescription = sDesc;
        }

        internal Auftraege CreateNew(int iAuftr, string sTitle, int kat, DateTime date, int iKN, string sDesc)
        {
            Auftraege auftrag = new Auftraege(iAuftr, sTitle, kat, date, iKN, strDescription);
            return auftrag;
        }

        internal int ID
        {
            get { return iAuftrNr; }
        }
        internal string Titel
        {
            get { return strTitle; }
        }

        internal int Kategorie
        {
            get { return AuftragsKategorie; }
        }

        internal int KuNr
        {
            get { return iKuNr; }
        }

        internal DateTime ErstellDatum
        {
            get { return dtErstelldatum; }
        }

        internal string Beschreibung
        {
            get { return strDescription; }
        }

   

    }
}
