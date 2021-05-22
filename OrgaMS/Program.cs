using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrgaMS
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DataManager.DatabaseOpen();
            DataManager.LoadDataFromEntity(DataManager.EnumEntities.Customer);

            Application.Run(new frmAuftraege());
            
        }
    }
}
