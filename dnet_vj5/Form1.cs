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
                Location = this.PointToClient(Cursor.Position),
                Text = zaba.Naziv,
                AutoSize = true
            };

            label1.Click += (s, b) =>
            {
                Label l = (Label)s;
                if (cnt == 1)
                    MessageBox.Show("hoću još žaba", "Roda");
                this.Controls.Remove(l);
                cnt--;
                sveZabe.Remove(l.Text);


            };
            this.Controls.Add(label1);

        }

        
    }
}