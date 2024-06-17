namespace CSharp_GiaiPTBac2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.btnGPT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKQ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(30, 100);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(55, 18);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "Nhập a";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(30, 175);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(55, 18);
            this.lblb.TabIndex = 1;
            this.lblb.Text = "Nhập b";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(30, 265);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(54, 18);
            this.lblc.TabIndex = 1;
            this.lblc.Text = "Nhập c";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(122, 92);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(181, 26);
            this.txta.TabIndex = 2;
            this.txta.Text = "0";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(122, 175);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(181, 26);
            this.txtb.TabIndex = 2;
            this.txtb.Text = "0";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(122, 257);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(181, 26);
            this.txtc.TabIndex = 2;
            this.txtc.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(345, 92);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(520, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(345, 167);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = -100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(520, 45);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(345, 257);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Minimum = -100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(520, 45);
            this.trackBar3.TabIndex = 3;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // btnGPT
            // 
            this.btnGPT.Location = new System.Drawing.Point(248, 308);
            this.btnGPT.Name = "btnGPT";
            this.btnGPT.Size = new System.Drawing.Size(328, 104);
            this.btnGPT.TabIndex = 4;
            this.btnGPT.Text = "Giải phương trình";
            this.btnGPT.UseVisualStyleBackColor = true;
            this.btnGPT.Click += new System.EventHandler(this.btnGPT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKQ);
            this.groupBox1.Location = new System.Drawing.Point(122, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KẾT QUẢ";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(29, 26);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(64, 18);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = "Kết quả ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 642);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGPT);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Button btnGPT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKQ;
    }
}

