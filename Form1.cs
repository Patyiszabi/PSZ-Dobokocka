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

        private void idozito_Tick(object sender, EventArgs e)
        {
            kep_index_aladar = rnd.Next(1, 7);
            kep_index_bendeguz = rnd.Next(1, 7);
            switch (kep_index_aladar)
            {
                case 1:
                    pctb_aladar.Load("dobas1.png");
                    break;
                case 2:
                    pctb_aladar.Load("dobas2.png");
                    break;
                case 3:
                    pctb_aladar.Load("dobas3.png");
                    break;
                case 4:
                    pctb_aladar.Load("dobas4.png");
                    break;
                case 5:
                    pctb_aladar.Load("dobas5.png");
                    break;
                case 6:
                    pctb_aladar.Load("dobas6.png");
                    break;


            }

            switch (kep_index_bendeguz)
            {
                case 1:
                    pctb_bendeguz.Load("dobas1.png");
                    break;
                case 2:
                    pctb_bendeguz.Load("dobas2.png");
                    break;
                case 3:
                    pctb_bendeguz.Load("dobas3.png");
                    break;
                case 4:
                    pctb_bendeguz.Load("dobas4.png");
                    break;
                case 5:
                    pctb_bendeguz.Load("dobas5.png");
                    break;
                case 6:
                    pctb_bendeguz.Load("dobas6.png");
                    break;
            }
        }

        private void btn_indulas_Click(object sender, EventArgs e)
        {
            idozito.Enabled = true;
            btn_indulas.Text = "Állj";
        }
    }
}
