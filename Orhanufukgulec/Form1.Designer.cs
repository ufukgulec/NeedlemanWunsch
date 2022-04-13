namespace Orhanufukgulec
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgw = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSecondArray = new System.Windows.Forms.TextBox();
            this.textBoxFirstArray = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMatch = new System.Windows.Forms.TextBox();
            this.textBoxMis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPoint = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            this.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgw.Location = new System.Drawing.Point(0, 211);
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersWidth = 51;
            this.dgw.RowTemplate.Height = 24;
            this.dgw.Size = new System.Drawing.Size(793, 486);
            this.dgw.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dizi 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dizi 1:";
            // 
            // textBoxSecondArray
            // 
            this.textBoxSecondArray.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.textBoxSecondArray.Location = new System.Drawing.Point(97, 43);
            this.textBoxSecondArray.Name = "textBoxSecondArray";
            this.textBoxSecondArray.Size = new System.Drawing.Size(691, 36);
            this.textBoxSecondArray.TabIndex = 1;
            // 
            // textBoxFirstArray
            // 
            this.textBoxFirstArray.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.textBoxFirstArray.Location = new System.Drawing.Point(97, 1);
            this.textBoxFirstArray.Name = "textBoxFirstArray";
            this.textBoxFirstArray.Size = new System.Drawing.Size(691, 36);
            this.textBoxFirstArray.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Match:";
            // 
            // textBoxMatch
            // 
            this.textBoxMatch.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.textBoxMatch.Location = new System.Drawing.Point(97, 85);
            this.textBoxMatch.Name = "textBoxMatch";
            this.textBoxMatch.Size = new System.Drawing.Size(163, 36);
            this.textBoxMatch.TabIndex = 2;
            // 
            // textBoxMis
            // 
            this.textBoxMis.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.textBoxMis.Location = new System.Drawing.Point(97, 127);
            this.textBoxMis.Name = "textBoxMis";
            this.textBoxMis.Size = new System.Drawing.Size(163, 36);
            this.textBoxMis.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(31, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gap:";
            // 
            // textBoxGap
            // 
            this.textBoxGap.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.textBoxGap.Location = new System.Drawing.Point(97, 169);
            this.textBoxGap.Name = "textBoxGap";
            this.textBoxGap.Size = new System.Drawing.Size(163, 36);
            this.textBoxGap.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(263, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 120);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hizala";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPoint);
            this.groupBox1.Controls.Add(this.labelTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(543, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonuç";
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.labelPoint.ForeColor = System.Drawing.Color.Red;
            this.labelPoint.Location = new System.Drawing.Point(103, 73);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(0, 29);
            this.labelPoint.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(103, 36);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 29);
            this.labelTime.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(26, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Puan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(9, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Zaman:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 697);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMatch);
            this.Controls.Add(this.textBoxMis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSecondArray);
            this.Controls.Add(this.textBoxFirstArray);
            this.Controls.Add(this.dgw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSecondArray;
        private System.Windows.Forms.TextBox textBoxFirstArray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMatch;
        private System.Windows.Forms.TextBox textBoxMis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

