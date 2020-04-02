using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnet_vj5
{
    public partial class Form1 : Form
    {
        Dictionary<string, Zaba> sveZabe = new Dictionary<string, Zaba>();
        Zaba zaba;
        Label label1;
        public int broj = 1;
        int cnt = 0;

        public Form1()
        {
            InitializeComponent();
        }





        private void dodajZabuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zaba = new Zaba();
            cnt++;
            zaba.Naziv = "Žaba" + broj++.ToString();
            sveZabe.Add(zaba.Naziv, zaba);
            label1 = new Label
            {
                Location = Cursor.Position,
                Text = zaba.Naziv,
                AutoSize = true
            };
            this.Controls.Add(label1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Click += new EventHandler((s, b) =>
            {
                if (cnt == 1)
                    MessageBox.Show("hoću još žaba", "Roda");
                this.Controls.Remove(label1);
                cnt--;
                sveZabe.Remove(label1.Text);


            });

        }
    }
}