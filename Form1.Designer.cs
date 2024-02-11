namespace AgendaContatos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AgendaLabel = new System.Windows.Forms.Label();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.EndereçoLabel = new System.Windows.Forms.Label();
            this.CelularLabel = new System.Windows.Forms.Label();
            this.TelefoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AgendaDataGridView = new System.Windows.Forms.DataGridView();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.EndereçoTextBox = new System.Windows.Forms.TextBox();
            this.CelularTextBox = new System.Windows.Forms.TextBox();
            this.TelefoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AdicionarButton = new System.Windows.Forms.Button();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.DeletarButton = new System.Windows.Forms.Button();
            this.SairButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgendaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AgendaLabel
            // 
            this.AgendaLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgendaLabel.Location = new System.Drawing.Point(0, 0);
            this.AgendaLabel.Name = "AgendaLabel";
            this.AgendaLabel.Size = new System.Drawing.Size(800, 51);
            this.AgendaLabel.TabIndex = 0;
            this.AgendaLabel.Text = "Agenda-Contatos";
            this.AgendaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NomeLabel
            // 
            this.NomeLabel.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLabel.ForeColor = System.Drawing.Color.Purple;
            this.NomeLabel.Location = new System.Drawing.Point(38, 51);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(100, 23);
            this.NomeLabel.TabIndex = 1;
            this.NomeLabel.Text = "Nome:";
            // 
            // EndereçoLabel
            // 
            this.EndereçoLabel.AutoSize = true;
            this.EndereçoLabel.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndereçoLabel.ForeColor = System.Drawing.Color.Purple;
            this.EndereçoLabel.Location = new System.Drawing.Point(38, 84);
            this.EndereçoLabel.Name = "EndereçoLabel";
            this.EndereçoLabel.Size = new System.Drawing.Size(84, 19);
            this.EndereçoLabel.TabIndex = 2;
            this.EndereçoLabel.Text = "Endereço:";
            // 
            // CelularLabel
            // 
            this.CelularLabel.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularLabel.ForeColor = System.Drawing.Color.Purple;
            this.CelularLabel.Location = new System.Drawing.Point(38, 117);
            this.CelularLabel.Name = "CelularLabel";
            this.CelularLabel.Size = new System.Drawing.Size(83, 21);
            this.CelularLabel.TabIndex = 3;
            this.CelularLabel.Text = "Celular:";
            // 
            // TelefoneLabel
            // 
            this.TelefoneLabel.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneLabel.ForeColor = System.Drawing.Color.Purple;
            this.TelefoneLabel.Location = new System.Drawing.Point(37, 158);
            this.TelefoneLabel.Name = "TelefoneLabel";
            this.TelefoneLabel.Size = new System.Drawing.Size(84, 20);
            this.TelefoneLabel.TabIndex = 4;
            this.TelefoneLabel.Text = "Telefone:";
            this.TelefoneLabel.UseWaitCursor = true;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Purple;
            this.EmailLabel.Location = new System.Drawing.Point(40, 197);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(82, 54);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email:";
            // 
            // AgendaDataGridView
            // 
            this.AgendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgendaDataGridView.Location = new System.Drawing.Point(44, 258);
            this.AgendaDataGridView.Name = "AgendaDataGridView";
            this.AgendaDataGridView.Size = new System.Drawing.Size(709, 218);
            this.AgendaDataGridView.TabIndex = 6;
            this.AgendaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgendaDataGridView_CellContentClick);
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.NomeTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NomeTextBox.Location = new System.Drawing.Point(128, 51);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(268, 20);
            this.NomeTextBox.TabIndex = 7;
            // 
            // EndereçoTextBox
            // 
            this.EndereçoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.EndereçoTextBox.Location = new System.Drawing.Point(128, 84);
            this.EndereçoTextBox.Name = "EndereçoTextBox";
            this.EndereçoTextBox.Size = new System.Drawing.Size(268, 20);
            this.EndereçoTextBox.TabIndex = 8;
            // 
            // CelularTextBox
            // 
            this.CelularTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.CelularTextBox.Location = new System.Drawing.Point(127, 118);
            this.CelularTextBox.Name = "CelularTextBox";
            this.CelularTextBox.Size = new System.Drawing.Size(238, 20);
            this.CelularTextBox.TabIndex = 9;
            // 
            // TelefoneTextBox
            // 
            this.TelefoneTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.TelefoneTextBox.Location = new System.Drawing.Point(127, 158);
            this.TelefoneTextBox.Name = "TelefoneTextBox";
            this.TelefoneTextBox.Size = new System.Drawing.Size(238, 20);
            this.TelefoneTextBox.TabIndex = 10;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.EmailTextBox.Location = new System.Drawing.Point(127, 197);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(269, 20);
            this.EmailTextBox.TabIndex = 11;
            // 
            // AdicionarButton
            // 
            this.AdicionarButton.BackColor = System.Drawing.Color.GreenYellow;
            this.AdicionarButton.Location = new System.Drawing.Point(529, 51);
            this.AdicionarButton.Name = "AdicionarButton";
            this.AdicionarButton.Size = new System.Drawing.Size(86, 38);
            this.AdicionarButton.TabIndex = 12;
            this.AdicionarButton.Text = "Novo";
            this.AdicionarButton.UseVisualStyleBackColor = false;
            this.AdicionarButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // SalvarButton
            // 
            this.SalvarButton.BackColor = System.Drawing.Color.GreenYellow;
            this.SalvarButton.Location = new System.Drawing.Point(529, 100);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(86, 38);
            this.SalvarButton.TabIndex = 13;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = false;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.BackColor = System.Drawing.Color.GreenYellow;
            this.EditarButton.Location = new System.Drawing.Point(529, 148);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(86, 38);
            this.EditarButton.TabIndex = 14;
            this.EditarButton.Text = "Editar";
            this.EditarButton.UseVisualStyleBackColor = false;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // DeletarButton
            // 
            this.DeletarButton.BackColor = System.Drawing.Color.DarkRed;
            this.DeletarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeletarButton.Location = new System.Drawing.Point(658, 100);
            this.DeletarButton.Name = "DeletarButton";
            this.DeletarButton.Size = new System.Drawing.Size(86, 38);
            this.DeletarButton.TabIndex = 15;
            this.DeletarButton.Text = "Deletar";
            this.DeletarButton.UseVisualStyleBackColor = false;
            this.DeletarButton.Click += new System.EventHandler(this.DeletarButton_Click);
            // 
            // SairButton
            // 
            this.SairButton.BackColor = System.Drawing.Color.DarkRed;
            this.SairButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SairButton.Location = new System.Drawing.Point(658, 148);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(86, 38);
            this.SairButton.TabIndex = 16;
            this.SairButton.Text = "Sair";
            this.SairButton.UseVisualStyleBackColor = false;
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.DeletarButton);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.AdicionarButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.TelefoneTextBox);
            this.Controls.Add(this.CelularTextBox);
            this.Controls.Add(this.EndereçoTextBox);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.AgendaDataGridView);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.TelefoneLabel);
            this.Controls.Add(this.CelularLabel);
            this.Controls.Add(this.EndereçoLabel);
            this.Controls.Add(this.NomeLabel);
            this.Controls.Add(this.AgendaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Contatos";
            ((System.ComponentModel.ISupportInitialize)(this.AgendaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AgendaLabel;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.Label EndereçoLabel;
        private System.Windows.Forms.Label CelularLabel;
        private System.Windows.Forms.Label TelefoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.DataGridView AgendaDataGridView;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.TextBox EndereçoTextBox;
        private System.Windows.Forms.TextBox CelularTextBox;
        private System.Windows.Forms.TextBox TelefoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button AdicionarButton;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button DeletarButton;
        private System.Windows.Forms.Button SairButton;
    }
}

