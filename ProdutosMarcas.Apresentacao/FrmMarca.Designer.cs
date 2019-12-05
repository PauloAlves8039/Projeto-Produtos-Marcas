namespace ProdutosMarcas.Apresentacao
{
    partial class FrmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarca));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalvarMarca = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimparMarca = new System.Windows.Forms.ToolStripButton();
            this.btnFecharMarca = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNomeMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 39);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvarMarca,
            this.toolStripSeparator1,
            this.btnLimparMarca,
            this.btnFecharMarca});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(402, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalvarMarca
            // 
            this.btnSalvarMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarMarca.Image")));
            this.btnSalvarMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarMarca.Name = "btnSalvarMarca";
            this.btnSalvarMarca.Size = new System.Drawing.Size(36, 36);
            this.btnSalvarMarca.Text = "Salvar Marcar";
            this.btnSalvarMarca.Click += new System.EventHandler(this.btnSalvarMarca_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnLimparMarca
            // 
            this.btnLimparMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimparMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparMarca.Image")));
            this.btnLimparMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimparMarca.Name = "btnLimparMarca";
            this.btnLimparMarca.Size = new System.Drawing.Size(36, 36);
            this.btnLimparMarca.Text = "Limpar Marca";
            this.btnLimparMarca.Click += new System.EventHandler(this.btnLimparMarca_Click);
            // 
            // btnFecharMarca
            // 
            this.btnFecharMarca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFecharMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFecharMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharMarca.Image")));
            this.btnFecharMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFecharMarca.Name = "btnFecharMarca";
            this.btnFecharMarca.Size = new System.Drawing.Size(36, 36);
            this.btnFecharMarca.Text = "Fechar Marca";
            this.btnFecharMarca.Click += new System.EventHandler(this.btnFecharMarca_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNomeMarca);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 97);
            this.panel2.TabIndex = 1;
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMarca.Location = new System.Drawing.Point(127, 34);
            this.txtNomeMarca.MaxLength = 50;
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.Size = new System.Drawing.Size(250, 23);
            this.txtNomeMarca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Marca:";
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 136);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar/Atualizar Marca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvarMarca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLimparMarca;
        private System.Windows.Forms.ToolStripButton btnFecharMarca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNomeMarca;
        private System.Windows.Forms.Label label1;
    }
}