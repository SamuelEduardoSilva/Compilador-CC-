using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{
    public partial class token_table : Form
    {
        public token_table()
        {
            InitializeComponent();
            listView1.View = View.List;
            listView2.View = View.List;

            listView3.View = View.List;

            string[] lines = System.IO.File.ReadAllLines(@"Tokens.txt");
           
            foreach (string line in lines)
            {
                String[] subs = line.Split('&');
               
                listView1.Items.Add(subs[0] + System.Environment.NewLine);
                listView2.Items.Add(subs[1] + System.Environment.NewLine);
                listView3.Items.Add(subs[2] + System.Environment.NewLine);


            }
        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Form1 = new Form1();
           
        }
    }
}
