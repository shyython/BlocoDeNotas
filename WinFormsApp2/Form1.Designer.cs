namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            MArquivo = new ToolStripMenuItem();
            MNovo = new ToolStripMenuItem();
            MNovaJanela = new ToolStripMenuItem();
            MAbrir = new ToolStripMenuItem();
            MSalvar = new ToolStripMenuItem();
            MSair = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            MCopiar = new ToolStripMenuItem();
            Mrecortar = new ToolStripMenuItem();
            MColar = new ToolStripMenuItem();
            dataToolStripMenuItem = new ToolStripMenuItem();
            MFormatar = new ToolStripMenuItem();
            MQuebrarLinha = new ToolStripMenuItem();
            MLimpar = new ToolStripMenuItem();
            Nfonte = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            saibaMaisSobreONotePadToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            RTxtBloco = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Window;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MArquivo, editarToolStripMenuItem, MFormatar, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(995, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MArquivo
            // 
            MArquivo.DropDownItems.AddRange(new ToolStripItem[] { MNovo, MNovaJanela, MAbrir, MSalvar, MSair });
            MArquivo.Name = "MArquivo";
            MArquivo.Size = new Size(61, 20);
            MArquivo.Text = "Arquivo";
            MArquivo.Click += MArquivo_Click;
            // 
            // MNovo
            // 
            MNovo.Name = "MNovo";
            MNovo.Size = new Size(137, 22);
            MNovo.Text = "Novo";
            MNovo.Click += MNovo_Click;
            // 
            // MNovaJanela
            // 
            MNovaJanela.Name = "MNovaJanela";
            MNovaJanela.Size = new Size(137, 22);
            MNovaJanela.Text = "Nova Janela";
            MNovaJanela.Click += MNovaJanela_Click;
            // 
            // MAbrir
            // 
            MAbrir.Name = "MAbrir";
            MAbrir.Size = new Size(137, 22);
            MAbrir.Text = "Abrir";
            MAbrir.Click += MAbrir_Click;
            // 
            // MSalvar
            // 
            MSalvar.Name = "MSalvar";
            MSalvar.Size = new Size(137, 22);
            MSalvar.Text = "Salvar";
            MSalvar.Click += MSalvar_Click;
            // 
            // MSair
            // 
            MSair.Name = "MSair";
            MSair.Size = new Size(137, 22);
            MSair.Text = "Sair";
            MSair.Click += MSair_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MCopiar, Mrecortar, MColar, dataToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // MCopiar
            // 
            MCopiar.Name = "MCopiar";
            MCopiar.Size = new Size(118, 22);
            MCopiar.Text = "Copiar";
            MCopiar.Click += MCopiar_Click;
            // 
            // Mrecortar
            // 
            Mrecortar.Name = "Mrecortar";
            Mrecortar.Size = new Size(118, 22);
            Mrecortar.Text = "Recortar";
            Mrecortar.Click += Mrecortar_Click;
            // 
            // MColar
            // 
            MColar.Name = "MColar";
            MColar.Size = new Size(118, 22);
            MColar.Text = "Colar";
            MColar.Click += MColar_Click;
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(118, 22);
            dataToolStripMenuItem.Text = "Data";
            dataToolStripMenuItem.Click += dataToolStripMenuItem_Click;
            // 
            // MFormatar
            // 
            MFormatar.DropDownItems.AddRange(new ToolStripItem[] { MQuebrarLinha, MLimpar, Nfonte });
            MFormatar.Name = "MFormatar";
            MFormatar.Size = new Size(67, 20);
            MFormatar.Text = "Formatar";
            MFormatar.Click += MFormatar_Click;
            // 
            // MQuebrarLinha
            // 
            MQuebrarLinha.Name = "MQuebrarLinha";
            MQuebrarLinha.Size = new Size(149, 22);
            MQuebrarLinha.Text = "Quebrar Linha";
            MQuebrarLinha.Click += MQubraDeLinha_Click;
            // 
            // MLimpar
            // 
            MLimpar.Name = "MLimpar";
            MLimpar.Size = new Size(149, 22);
            MLimpar.Text = "Limpar";
            MLimpar.Click += MLimpar_Click;
            // 
            // Nfonte
            // 
            Nfonte.Name = "Nfonte";
            Nfonte.Size = new Size(149, 22);
            Nfonte.Text = "Alterar fonte";
            Nfonte.Click += negritoToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saibaMaisSobreONotePadToolStripMenuItem });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // saibaMaisSobreONotePadToolStripMenuItem
            // 
            saibaMaisSobreONotePadToolStripMenuItem.Name = "saibaMaisSobreONotePadToolStripMenuItem";
            saibaMaisSobreONotePadToolStripMenuItem.Size = new Size(221, 22);
            saibaMaisSobreONotePadToolStripMenuItem.Text = "Saiba mais sobre o NotePad";
            saibaMaisSobreONotePadToolStripMenuItem.Click += saibaMaisSobreONotePadToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "C:\\";
            // 
            // RTxtBloco
            // 
            RTxtBloco.BackColor = SystemColors.Window;
            RTxtBloco.Dock = DockStyle.Fill;
            RTxtBloco.Location = new Point(0, 24);
            RTxtBloco.Name = "RTxtBloco";
            RTxtBloco.Size = new Size(995, 654);
            RTxtBloco.TabIndex = 1;
            RTxtBloco.Text = "";
            RTxtBloco.TextChanged += RTxtBloco_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(995, 678);
            Controls.Add(RTxtBloco);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Note Pad";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MArquivo;
        private ToolStripMenuItem MNovo;
        private ToolStripMenuItem MNovaJanela;
        private ToolStripMenuItem MAbrir;
        private ToolStripMenuItem MSalvar;
        private ToolStripMenuItem MSair;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem MCopiar;
        private ToolStripMenuItem MColar;
        private ToolStripMenuItem MFormatar;
        private ToolStripMenuItem MQuebrarLinha;
        private OpenFileDialog openFileDialog1;
        private RichTextBox RTxtBloco;
        private ToolStripMenuItem Mrecortar;
        private ToolStripMenuItem MLimpar;
        private ToolStripMenuItem Nfonte;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem saibaMaisSobreONotePadToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
    }
}