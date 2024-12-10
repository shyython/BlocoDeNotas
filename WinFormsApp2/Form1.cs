using System.Data;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MFormatar_Click(object sender, EventArgs e)
        {

        }

        private void MNovaJanela_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();
        }

        private void MSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DialogResult resposta;
                resposta = MessageBox.Show("Deseja salvar as alterações?", "salvar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                RTxtBloco.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }


        private void MNovo_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DialogResult resposta;
                Directory.CreateDirectory(saveFileDialog1.FileName);
                File.CreateText(saveFileDialog1.FileName);
            }
        }

        private void MSalvar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DialogResult resposta;
                File.WriteAllText(saveFileDialog1.FileName, RTxtBloco.Text);
            }

        }

        private void RTxtBloco_TextChanged(object sender, EventArgs e)
        {


        }

        private void MArquivo_Click(object sender, EventArgs e)
        {

        }

        public void MCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RTxtBloco.SelectedText);
        }

        public void MColar_Click(object sender, EventArgs e)
        {
            RTxtBloco.Text = RTxtBloco.Text + Clipboard.GetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MQubraDeLinha_Click(object sender, EventArgs e)
        {
            RTxtBloco.Text = "\n" + RTxtBloco.Text;
        }

        private void Mrecortar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RTxtBloco.SelectedText);
            RTxtBloco.SelectedText = string.Empty;
        }

        private void MLimpar_Click(object sender, EventArgs e)
        {
            RTxtBloco.Text = "";
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog myfont = new FontDialog();
            myfont.ShowColor = true;
            myfont.Font = RTxtBloco.Font;
            DialogResult resultado = myfont.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                RTxtBloco.Font = myfont.Font;
                RTxtBloco.ForeColor = myfont.Color;
            }

        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTxtBloco.Text = RTxtBloco.Text + DateTime.Now;
        }

        private void saibaMaisSobreONotePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form3();
            form.Show();
        }
    }
}