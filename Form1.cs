using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSZ_Dobokocka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random rnd = new Random();
        static int kep_index_aladar;
        static int kep_index_bendeguz;
        public List<int> aladar_list;
        public List<int> bendeguz_list;

       

        private void btn_indulas_Click(object sender, EventArgs e)
        {
            btn_indulas.Text = "Új dobás";
            btn_indulas.AutoSize = true;
            rnd.Next(1, 7);
            kep_index_aladar = rnd.Next(1, 7);
            kep_index_bendeguz = rnd.Next(1, 7);
            pctb_aladar.Load($"dobas{kep_index_aladar}.png");
            pctb_bendeguz.Load($"dobas{kep_index_bendeguz}.png");

            if (kep_index_aladar > kep_index_bendeguz)
            {
                lbl_eredmeny.Text = "Ádám nyert!";
            }
            else if (kep_index_aladar < kep_index_bendeguz)
            {
                lbl_eredmeny.Text = "Bendegúz nyert!";
            }
            else
            {
                lbl_eredmeny.Text = "Döntetlen!";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
