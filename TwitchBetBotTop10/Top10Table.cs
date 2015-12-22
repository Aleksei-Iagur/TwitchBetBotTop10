using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace TwitchBetBotTop10
{
    public partial class Top10Table : Form
    {
        public Top10Table()
        {
            InitializeComponent();
        }
        
        private void ShowTop10InList()
        {
            listView_Top10.Items.Clear();

            listView_Top10.Items.Add("");
            listView_Top10.Items.Add("     === TOP 10 ===");

            var connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            var um = (new DatabaseManager(connectionString)).GetAllUsers();
            var cm = um.OrderByDescending(x => x.Coins).Take(10).ToList();
            var users = cm.Select(x => $"{x.Name} [{x.Coins}]").ToList();
            foreach (var user in users)
            {
                listView_Top10.Items.Add("    "+user);
            }
        }

        private void ControlDesc_Load(object sender, EventArgs e)
        {
            ShowTop10InList();
        }

        private void timerTop10_Tick(object sender, EventArgs e)
        {
            ShowTop10InList();
        }
        
        private void button_Update_Click(object sender, EventArgs e)
        {
            ShowTop10InList();
        }
    }
}
