using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prosjek_ocjena1
{
    public partial class Form1 : Form
    {
        List<Prosjek>
        public Form1()
        {

            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*listaOcjena.Clear();
            foreach (Prosjek prosjek in listaOcjena)
            {
                listaOcjena.AppendText(prosjek.NazivPredmeta + "\t" + prosjek.Ocjena + "\r\n");
            }*/
            string text = "";
            foreach (Prosjek prosjek in listaOcjena)
            {
                text += prosjek.NazivPredmeta + "\t" + prosjek.Ocjena + "\r\n";
            }
            txtOcjena.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string nazivPredmeta = cmbOcjena.Text; 
            int ocjena;

            if (string.IsNullOrEmpty(nazivPredmeta))
            {
                MessageBox.Show("Predmet ne smije biti prazan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtOcjena.Text, out ocjena))
            {
                if (ocjena < 1 || ocjena > 5)
                {
                    MessageBox.Show("Ocjena mora biti između 1 i 5!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                Prosjek prosjek = new Prosjek(nazivPredmeta, ocjena);
                listaOcjena.Add(prosjek);

                txtOcjena.Clear();
                cmbOcjena.SelectedIndex = -1;  
                txtOcjena.Focus();
            }
            else
            {
                MessageBox.Show("Molimo unesite validnu ocjenu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }

