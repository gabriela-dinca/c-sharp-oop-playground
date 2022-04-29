namespace FiFoKlasse
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbValueToWrite = new System.Windows.Forms.TextBox();
            this.btbWriteValueInFiFo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHead = new System.Windows.Forms.TextBox();
            this.tbTail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbState = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFiFo = new System.Windows.Forms.ListBox();
            this.lbSortedFiFo = new System.Windows.Forms.ListBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btbWriteValueInFiFo);
            this.groupBox1.Controls.Add(this.tbValueToWrite);
            this.groupBox1.Location = new System.Drawing.Point(50, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingabe der Werte";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbFiFo);
            this.groupBox2.Location = new System.Drawing.Point(285, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 424);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pufferinhelt";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbSortedFiFo);
            this.groupBox3.Location = new System.Drawing.Point(531, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 424);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FiFo-Inhalt";
            // 
            // tbValueToWrite
            // 
            this.tbValueToWrite.Location = new System.Drawing.Point(18, 35);
            this.tbValueToWrite.Name = "tbValueToWrite";
            this.tbValueToWrite.Size = new System.Drawing.Size(100, 20);
            this.tbValueToWrite.TabIndex = 0;
            // 
            // btbWriteValueInFiFo
            // 
            this.btbWriteValueInFiFo.Location = new System.Drawing.Point(18, 73);
            this.btbWriteValueInFiFo.Name = "btbWriteValueInFiFo";
            this.btbWriteValueInFiFo.Size = new System.Drawing.Size(145, 23);
            this.btbWriteValueInFiFo.TabIndex = 1;
            this.btbWriteValueInFiFo.Text = "Wert in FiFo schreiben";
            this.btbWriteValueInFiFo.UseVisualStyleBackColor = true;
            this.btbWriteValueInFiFo.Click += new System.EventHandler(this.btbWriteValueInFiFo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(18, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "FiFo leeren";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbMin);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbMax);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbState);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbSize);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbTail);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbHead);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(50, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 242);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eingeschaften der FiFo-Buffer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Head";
            // 
            // tbHead
            // 
            this.tbHead.Location = new System.Drawing.Point(63, 28);
            this.tbHead.Name = "tbHead";
            this.tbHead.Size = new System.Drawing.Size(100, 20);
            this.tbHead.TabIndex = 1;
            // 
            // tbTail
            // 
            this.tbTail.Location = new System.Drawing.Point(63, 63);
            this.tbTail.Name = "tbTail";
            this.tbTail.Size = new System.Drawing.Size(100, 20);
            this.tbTail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tail";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(63, 98);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(100, 20);
            this.tbSize.TabIndex = 5;
        
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size";
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(63, 133);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(100, 20);
            this.tbState.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "State";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(63, 168);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 20);
            this.tbMax.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Maxwert";
            // 
            // lbFiFo
            // 
            this.lbFiFo.FormattingEnabled = true;
            this.lbFiFo.Location = new System.Drawing.Point(18, 28);
            this.lbFiFo.Name = "lbFiFo";
            this.lbFiFo.Size = new System.Drawing.Size(163, 381);
            this.lbFiFo.TabIndex = 0;
            // 
            // lbSortedFiFo
            // 
            this.lbSortedFiFo.FormattingEnabled = true;
            this.lbSortedFiFo.Location = new System.Drawing.Point(18, 28);
            this.lbSortedFiFo.Name = "lbSortedFiFo";
            this.lbSortedFiFo.Size = new System.Drawing.Size(163, 381);
            this.lbSortedFiFo.TabIndex = 1;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(63, 201);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 20);
            this.tbMin.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Minwert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btbWriteValueInFiFo;
        private System.Windows.Forms.TextBox tbValueToWrite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbFiFo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbSortedFiFo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHead;
        private System.Windows.Forms.Label label1;
    }
}

