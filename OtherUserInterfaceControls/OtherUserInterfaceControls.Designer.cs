namespace OtherUserInterfaceControls
{
    partial class frmOtherUserInterfaceControls
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFirstPage = new System.Windows.Forms.Label();
            this.txtFirstPage = new System.Windows.Forms.TextBox();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblNumericUpDown = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblRichTextBox = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "First Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblRichTextBox);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(963, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Second Page";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblFirstPage
            // 
            this.lblFirstPage.AutoSize = true;
            this.lblFirstPage.Location = new System.Drawing.Point(19, 10);
            this.lblFirstPage.Name = "lblFirstPage";
            this.lblFirstPage.Size = new System.Drawing.Size(76, 17);
            this.lblFirstPage.TabIndex = 0;
            this.lblFirstPage.Text = "First Page:";
            // 
            // txtFirstPage
            // 
            this.txtFirstPage.Location = new System.Drawing.Point(215, 7);
            this.txtFirstPage.Name = "txtFirstPage";
            this.txtFirstPage.Size = new System.Drawing.Size(167, 22);
            this.txtFirstPage.TabIndex = 1;
            this.txtFirstPage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(215, 68);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(167, 42);
            this.btnFirstPage.TabIndex = 2;
            this.btnFirstPage.Text = "First Page";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(215, 142);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(167, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // lblNumericUpDown
            // 
            this.lblNumericUpDown.AutoSize = true;
            this.lblNumericUpDown.Location = new System.Drawing.Point(22, 142);
            this.lblNumericUpDown.Name = "lblNumericUpDown";
            this.lblNumericUpDown.Size = new System.Drawing.Size(125, 17);
            this.lblNumericUpDown.TabIndex = 4;
            this.lblNumericUpDown.Text = "Numeric Up Down:";
            this.lblNumericUpDown.Click += new System.EventHandler(this.lblNumericUpDown_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNumericUpDown);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.btnFirstPage);
            this.panel1.Controls.Add(this.txtFirstPage);
            this.panel1.Controls.Add(this.lblFirstPage);
            this.panel1.Location = new System.Drawing.Point(14, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 184);
            this.panel1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(476, 295);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "This is an example of rich text control.\n\nyou can add multiple lines\n\nIt even pic" +
    "ks up urls: www.facebook.com";
            // 
            // lblRichTextBox
            // 
            this.lblRichTextBox.AutoSize = true;
            this.lblRichTextBox.Location = new System.Drawing.Point(28, 26);
            this.lblRichTextBox.Name = "lblRichTextBox";
            this.lblRichTextBox.Size = new System.Drawing.Size(98, 17);
            this.lblRichTextBox.TabIndex = 1;
            this.lblRichTextBox.Text = "Rich Text Box:";
            // 
            // frmOtherUserInterfaceControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 527);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmOtherUserInterfaceControls";
            this.Text = "Other User Interface Controls";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtFirstPage;
        private System.Windows.Forms.Label lblFirstPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblNumericUpDown;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRichTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

