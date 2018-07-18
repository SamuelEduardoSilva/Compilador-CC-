using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Compilador : Form
    {
        public Compilador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalisadorLexico x = new AnalisadorLexico();
            debug.Text = "";
            string texto = codigo.Text;

            bool erro = x.Analisa(texto);

            debug.Text = (x.analiseLexica);
            if (erro)
                debug.BackColor = Color.Red;
            else
                debug.BackColor = Color.Green;
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codigo.Text = "";


        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "All files(*.cc#) | *.cc#";
            if (f.ShowDialog() == DialogResult.OK)
            {

                String arq = f.FileName;

                string text = System.IO.File.ReadAllText(@arq);

                codigo.Text = text;
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "All files(*.cc#) | *.cc#";
            if(f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(f.FileName);
                FileStream fs = new FileStream(f.FileName, FileMode.Create);

                //Cria um escrito que irá escrever no stream
                StreamWriter writer = new StreamWriter(fs);
                //escreve o conteúdo da caixa de texto no stream
                writer.Write(codigo.Text);
                //fecha o escrito e o stream
                writer.Close();
            }
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabelaDeTokensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            token_table t = new token_table();
            t.Show();
   
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            debug.Text = "";
            debug.BackColor = Color.White;
        }
    }
}
