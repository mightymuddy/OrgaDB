using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgaMS
{
    


    static class DataManager
    {
        public enum EnumEntities
        {
            Customer = 0, job = 1, Bills = 2, Database = 99
        };

        static internal void DatabaseOpen()
        {
            OrgaDatabase.InitDatabase();
        }
        static internal void LoadDataFromEntity(EnumEntities enEntity)
        {
            switch(enEntity)
            {
               case 0: OrgaDatabase.LoadQueryOf((int)EnumEntities.Customer);break;

            }
        }

        static internal void writeNewAuftrag(Auftraege auftrag)
        {
           OrgaDatabase.writeAuftrag(auftrag.ID, auftrag);
        }
    }
}
