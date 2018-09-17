using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the connections
            GlobalConfig.InitializeConnections(DatabaseType.Sql);
            GlobalConfig.InitializeConnections(DatabaseType.TextFile);

            Application.Run(new CreateTournamentForm());
            Application.Run(new TournamentDashbordForm());
        }
    }
}
