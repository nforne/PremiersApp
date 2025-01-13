using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Week11_Lab01_PremierApp
{
    public partial class PremierApp : Form
    {
        private static Dictionary<string, Premier> premiers;
        public PremierApp()
        {
            InitializeComponent();

            InitializeGui();
        }
       
        private void InitializeGui()
        {
            premiers = new Dictionary<string, Premier>();
            foreach(Premier p in Premier.GetPremiers()) { 
                premiers[p.Key] = p;
            }
            lbx_Premiers.DataSource = premiers.Keys.ToList();
        }
        private void lbx_Premiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lbx_Premier = (ListBox)sender;
            ShowPremier(lbx_Premier.SelectedItem.ToString());
        }

        private void ShowPremier(string key) { 
            Premier p = premiers[key];
            if (p != null)
            {
                lbl_PnameAndLife.Text = $"{p.Name} -- {p.Life} \n-------------------------";
                pbx_Primier.ImageLocation = $"images\\{key.ToLower()}.jpg";
                pbx_Primier.SizeMode = PictureBoxSizeMode.CenterImage;
                pbx_Primier.SizeMode = PictureBoxSizeMode.StretchImage;
                lbl_PremierAndInfo.Text = $"-------------------------" +
                    $"\nOffice from {p.Start} to {p.End}" +
                    $" \n{p.Constituent}" +
                    $" \n{p.Party}";
            }
            else {
                MessageBox.Show("There's NEVER been a premier with that name!🤔");
            }
        }
       
    }
}
