
namespace CurrencyConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_display = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.combofrom1 = new System.Windows.Forms.ComboBox();
            this.comboto1 = new System.Windows.Forms.ComboBox();
            this.btn_conv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convert From :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convert To :";
            // 
            // txt_display
            // 
            this.txt_display.AutoSize = true;
            this.txt_display.Location = new System.Drawing.Point(44, 297);
            this.txt_display.Name = "txt_display";
            this.txt_display.Size = new System.Drawing.Size(83, 15);
            this.txt_display.TabIndex = 3;
            this.txt_display.Text = "Converted To :";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(136, 120);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(121, 23);
            this.txt_amount.TabIndex = 4;
            // 
            // combofrom1
            // 
            this.combofrom1.FormattingEnabled = true;
            this.combofrom1.Items.AddRange(new object[] {
            "Rupiah",
            "Dollar",
            "Euro"});
            this.combofrom1.Location = new System.Drawing.Point(136, 164);
            this.combofrom1.Name = "combofrom1";
            this.combofrom1.Size = new System.Drawing.Size(121, 23);
            this.combofrom1.TabIndex = 5;
            // 
            // comboto1
            // 
            this.comboto1.FormattingEnabled = true;
            this.comboto1.Items.AddRange(new object[] {
            "Rupiah",
            "Dollar",
            "Euro"});
            this.comboto1.Location = new System.Drawing.Point(136, 213);
            this.comboto1.Name = "comboto1";
            this.comboto1.Size = new System.Drawing.Size(121, 23);
            this.comboto1.TabIndex = 6;
            // 
            // btn_conv
            // 
            this.btn_conv.Location = new System.Drawing.Point(273, 120);
            this.btn_conv.Name = "btn_conv";
            this.btn_conv.Size = new System.Drawing.Size(75, 23);
            this.btn_conv.TabIndex = 7;
            this.btn_conv.Text = "Convert";
            this.btn_conv.UseVisualStyleBackColor = true;
            this.btn_conv.Click += new System.EventHandler(this.btn_conv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(102, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Currency Converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_conv);
            this.Controls.Add(this.comboto1);
            this.Controls.Add(this.combofrom1);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_display);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_display;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.ComboBox combofrom1;
        private System.Windows.Forms.ComboBox comboto1;
        private System.Windows.Forms.Button btn_conv;
        private System.Windows.Forms.Label label5;
    }
}

