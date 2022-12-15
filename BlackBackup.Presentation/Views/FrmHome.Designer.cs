namespace BlackBackup.Presentation.Views
{
    partial class FrmHome
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
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbConexao = new System.Windows.Forms.TabPage();
            this.mlvConexoes = new MaterialSkin.Controls.MaterialListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Conexao = new System.Windows.Forms.ColumnHeader();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.btnExcluir = new MaterialSkin.Controls.MaterialButton();
            this.btnAdicionar = new MaterialSkin.Controls.MaterialButton();
            this.tbBackups = new System.Windows.Forms.TabPage();
            this.btnAtualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnDownload = new MaterialSkin.Controls.MaterialButton();
            this.mlvBackups = new MaterialSkin.Controls.MaterialListView();
            this.tbClientes = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.btnBackup = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tbConexao.SuspendLayout();
            this.tbBackups.SuspendLayout();
            this.tbClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // testeToolStripMenuItem1
            // 
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            this.testeToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // testeToolStripMenuItem2
            // 
            this.testeToolStripMenuItem2.Name = "testeToolStripMenuItem2";
            this.testeToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // testeToolStripMenuItem3
            // 
            this.testeToolStripMenuItem3.Name = "testeToolStripMenuItem3";
            this.testeToolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 24);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1195, 48);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tbConexao);
            this.materialTabControl1.Controls.Add(this.tbBackups);
            this.materialTabControl1.Controls.Add(this.tbClientes);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1186, 651);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tbConexao
            // 
            this.tbConexao.Controls.Add(this.mlvConexoes);
            this.tbConexao.Controls.Add(this.btnEditar);
            this.tbConexao.Controls.Add(this.btnExcluir);
            this.tbConexao.Controls.Add(this.btnAdicionar);
            this.tbConexao.Location = new System.Drawing.Point(4, 24);
            this.tbConexao.Name = "tbConexao";
            this.tbConexao.Padding = new System.Windows.Forms.Padding(3);
            this.tbConexao.Size = new System.Drawing.Size(1178, 623);
            this.tbConexao.TabIndex = 0;
            this.tbConexao.Text = "Conexões";
            this.tbConexao.UseVisualStyleBackColor = true;
            // 
            // mlvConexoes
            // 
            this.mlvConexoes.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.mlvConexoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlvConexoes.AutoSizeTable = false;
            this.mlvConexoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvConexoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvConexoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Conexao});
            this.mlvConexoes.Depth = 0;
            this.mlvConexoes.FullRowSelect = true;
            this.mlvConexoes.Location = new System.Drawing.Point(6, 15);
            this.mlvConexoes.MinimumSize = new System.Drawing.Size(1166, 557);
            this.mlvConexoes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvConexoes.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvConexoes.Name = "mlvConexoes";
            this.mlvConexoes.OwnerDraw = true;
            this.mlvConexoes.Size = new System.Drawing.Size(1166, 557);
            this.mlvConexoes.TabIndex = 3;
            this.mlvConexoes.UseCompatibleStateImageBehavior = false;
            this.mlvConexoes.View = System.Windows.Forms.View.Details;
            this.mlvConexoes.SelectedIndexChanged += new System.EventHandler(this.mlvConexoes_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Conexao
            // 
            this.Conexao.Text = "Conexões";
            this.Conexao.Width = 1114;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = null;
            this.btnEditar.Location = new System.Drawing.Point(110, 581);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(71, 36);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.Location = new System.Drawing.Point(189, 581);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExcluir.Size = new System.Drawing.Size(80, 36);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = false;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicionar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdicionar.Depth = 0;
            this.btnAdicionar.HighEmphasis = true;
            this.btnAdicionar.Icon = null;
            this.btnAdicionar.Location = new System.Drawing.Point(4, 581);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdicionar.Size = new System.Drawing.Size(98, 36);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdicionar.UseAccentColor = false;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbBackups
            // 
            this.tbBackups.Controls.Add(this.btnAtualizar);
            this.tbBackups.Controls.Add(this.btnDownload);
            this.tbBackups.Controls.Add(this.mlvBackups);
            this.tbBackups.Location = new System.Drawing.Point(4, 24);
            this.tbBackups.Name = "tbBackups";
            this.tbBackups.Padding = new System.Windows.Forms.Padding(3);
            this.tbBackups.Size = new System.Drawing.Size(1178, 623);
            this.tbBackups.TabIndex = 1;
            this.tbBackups.Text = "Backups";
            this.tbBackups.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAtualizar.Depth = 0;
            this.btnAtualizar.HighEmphasis = true;
            this.btnAtualizar.Icon = null;
            this.btnAtualizar.Location = new System.Drawing.Point(114, 581);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAtualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAtualizar.Size = new System.Drawing.Size(99, 36);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAtualizar.UseAccentColor = false;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDownload.Depth = 0;
            this.btnDownload.HighEmphasis = true;
            this.btnDownload.Icon = null;
            this.btnDownload.Location = new System.Drawing.Point(4, 581);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDownload.Size = new System.Drawing.Size(102, 36);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDownload.UseAccentColor = false;
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // mlvBackups
            // 
            this.mlvBackups.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.mlvBackups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlvBackups.AutoSizeTable = false;
            this.mlvBackups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvBackups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvBackups.Depth = 0;
            this.mlvBackups.FullRowSelect = true;
            this.mlvBackups.Location = new System.Drawing.Point(6, 15);
            this.mlvBackups.MinimumSize = new System.Drawing.Size(1166, 557);
            this.mlvBackups.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvBackups.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvBackups.Name = "mlvBackups";
            this.mlvBackups.OwnerDraw = true;
            this.mlvBackups.ShowItemToolTips = true;
            this.mlvBackups.Size = new System.Drawing.Size(1166, 557);
            this.mlvBackups.TabIndex = 0;
            this.mlvBackups.UseCompatibleStateImageBehavior = false;
            this.mlvBackups.View = System.Windows.Forms.View.Details;
            // 
            // tbClientes
            // 
            this.tbClientes.Controls.Add(this.materialListView1);
            this.tbClientes.Controls.Add(this.btnBackup);
            this.tbClientes.Location = new System.Drawing.Point(4, 24);
            this.tbClientes.Name = "tbClientes";
            this.tbClientes.Size = new System.Drawing.Size(1178, 623);
            this.tbClientes.TabIndex = 2;
            this.tbClientes.Text = "Clientes";
            this.tbClientes.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.Location = new System.Drawing.Point(6, 15);
            this.materialListView1.MinimumSize = new System.Drawing.Size(1166, 557);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1166, 557);
            this.materialListView1.TabIndex = 1;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackup.Depth = 0;
            this.btnBackup.HighEmphasis = true;
            this.btnBackup.Icon = null;
            this.btnBackup.Location = new System.Drawing.Point(4, 581);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackup.Size = new System.Drawing.Size(78, 36);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackup.UseAccentColor = false;
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 718);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1192, 822);
            this.MinimumSize = new System.Drawing.Size(1192, 718);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tbConexao.ResumeLayout(false);
            this.tbConexao.PerformLayout();
            this.tbBackups.ResumeLayout(false);
            this.tbBackups.PerformLayout();
            this.tbClientes.ResumeLayout(false);
            this.tbClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolStripMenuItem testeToolStripMenuItem;
        private ToolStripMenuItem testeToolStripMenuItem1;
        private ToolStripMenuItem testeToolStripMenuItem2;
        private ToolStripMenuItem testeToolStripMenuItem3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tbConexao;
        private TabPage tbBackups;
        private TabPage tbClientes;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton btnExcluir;
        private MaterialSkin.Controls.MaterialButton btnAdicionar;
        private MaterialSkin.Controls.MaterialListView mlvConexoes;
        private MaterialSkin.Controls.MaterialButton btnDownload;
        private MaterialSkin.Controls.MaterialListView mlvBackups;
        private MaterialSkin.Controls.MaterialButton btnAtualizar;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialButton btnBackup;
        private ColumnHeader Conexao;
        private ColumnHeader Id;
    }
}