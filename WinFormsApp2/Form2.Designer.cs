namespace WinFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            RTxtBloco = new RichTextBox();
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RTxtBloco
            // 
            RTxtBloco.BackColor = SystemColors.Window;
            RTxtBloco.Dock = DockStyle.Fill;
            RTxtBloco.Location = new Point(0, 24);
            RTxtBloco.Name = "RTxtBloco";
            RTxtBloco.Size = new Size(800, 426);
            RTxtBloco.TabIndex = 3;
            RTxtBloco.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Window;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MArquivo, editarToolStripMenuItem, MFormatar, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // MArquivo
            // 
            MArquivo.DropDownItems.AddRange(new ToolStripItem[] { MNovo, MNovaJanela, MAbrir, MSalvar, MSair });
            MArquivo.Name = "MArquivo";
            MArquivo.Size = new Size(61, 20);
            MArquivo.Text = "Arquivo";
            // 
            // MNovo
            // 
            MNovo.Name = "MNovo";
            MNovo.Size = new Size(137, 22);
            MNovo.Text = "Novo";
            // 
            // MNovaJanela
            // 
            MNovaJanela.Name = "MNovaJanela";
            MNovaJanela.Size = new Size(137, 22);
            MNovaJanela.Text = "Nova Janela";
            // 
            // MAbrir
            // 
            MAbrir.Name = "MAbrir";
            MAbrir.Size = new Size(137, 22);
            MAbrir.Text = "Abrir";
            // 
            // MSalvar
            // 
            MSalvar.Name = "MSalvar";
            MSalvar.Size = new Size(137, 22);
            MSalvar.Text = "Salvar";
            // 
            // MSair
            // 
            MSair.Name = "MSair";
            MSair.Size = new Size(137, 22);
            MSair.Text = "Sair";
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
            // 
            // Mrecortar
            // 
            Mrecortar.Name = "Mrecortar";
            Mrecortar.Size = new Size(118, 22);
            Mrecortar.Text = "Recortar";
            // 
            // MColar
            // 
            MColar.Name = "MColar";
            MColar.Size = new Size(118, 22);
            MColar.Text = "Colar";
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(118, 22);
            dataToolStripMenuItem.Text = "Data";
            // 
            // MFormatar
            // 
            MFormatar.DropDownItems.AddRange(new ToolStripItem[] { MQuebrarLinha, MLimpar, Nfonte });
            MFormatar.Name = "MFormatar";
            MFormatar.Size = new Size(67, 20);
            MFormatar.Text = "Formatar";
            // 
            // MQuebrarLinha
            // 
            MQuebrarLinha.Name = "MQuebrarLinha";
            MQuebrarLinha.Size = new Size(149, 22);
            MQuebrarLinha.Text = "Quebrar Linha";
            // 
            // MLimpar
            // 
            MLimpar.Name = "MLimpar";
            MLimpar.Size = new Size(149, 22);
            MLimpar.Text = "Limpar";
            // 
            // Nfonte
            // 
            Nfonte.Name = "Nfonte";
            Nfonte.Size = new Size(149, 22);
            Nfonte.Text = "Alterar fonte";
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
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RTxtBloco);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RTxtBloco;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MArquivo;
        private ToolStripMenuItem MNovo;
        private ToolStripMenuItem MNovaJanela;
        private ToolStripMenuItem MAbrir;
        private ToolStripMenuItem MSalvar;
        private ToolStripMenuItem MSair;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem MCopiar;
        private ToolStripMenuItem Mrecortar;
        private ToolStripMenuItem MColar;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem MFormatar;
        private ToolStripMenuItem MQuebrarLinha;
        private ToolStripMenuItem MLimpar;
        private ToolStripMenuItem Nfonte;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem saibaMaisSobreONotePadToolStripMenuItem;
    }
}