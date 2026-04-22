namespace Kargo_Dağıtım_Sistemi
{
    partial class FormSoforTeslimatlar
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
            this.dgvTeslimatlar = new System.Windows.Forms.DataGridView();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeslimatlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeslimatlar
            // 
            this.dgvTeslimatlar.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvTeslimatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeslimatlar.Location = new System.Drawing.Point(12, 12);
            this.dgvTeslimatlar.Name = "dgvTeslimatlar";
            this.dgvTeslimatlar.RowHeadersWidth = 51;
            this.dgvTeslimatlar.RowTemplate.Height = 24;
            this.dgvTeslimatlar.Size = new System.Drawing.Size(889, 358);
            this.dgvTeslimatlar.TabIndex = 0;
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.BackColor = System.Drawing.Color.IndianRed;
            this.btnTeslimEt.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeslimEt.Location = new System.Drawing.Point(356, 432);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(155, 61);
            this.btnTeslimEt.TabIndex = 1;
            this.btnTeslimEt.Text = "Teslim Ettim";
            this.btnTeslimEt.UseVisualStyleBackColor = false;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // FormSoforTeslimatlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(913, 551);
            this.Controls.Add(this.btnTeslimEt);
            this.Controls.Add(this.dgvTeslimatlar);
            this.Name = "FormSoforTeslimatlar";
            this.Text = "FormSoforTeslimatlar";
            this.Load += new System.EventHandler(this.FormSoforTeslimatlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeslimatlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeslimatlar;
        private System.Windows.Forms.Button btnTeslimEt;
    }
}