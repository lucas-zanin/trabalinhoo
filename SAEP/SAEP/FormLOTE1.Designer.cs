namespace SAEP
{
    partial class FormLOTE1
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
            this.dgvLote1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLote1
            // 
            this.dgvLote1.AllowUserToAddRows = false;
            this.dgvLote1.AllowUserToDeleteRows = false;
            this.dgvLote1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLote1.Location = new System.Drawing.Point(29, 194);
            this.dgvLote1.Name = "dgvLote1";
            this.dgvLote1.ReadOnly = true;
            this.dgvLote1.Size = new System.Drawing.Size(457, 181);
            this.dgvLote1.TabIndex = 0;
            this.dgvLote1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLote1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Área 1";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(77, 106);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(225, 106);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(411, 104);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 4;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(187, 160);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Visible = false;
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(295, 160);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(0, 13);
            this.lblQtde.TabIndex = 8;
            this.lblQtde.Visible = false;
            // 
            // FormLOTE1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 390);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLote1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLOTE1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área 1";
            this.Load += new System.EventHandler(this.FormLOTE1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLote1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblQtde;
    }
}