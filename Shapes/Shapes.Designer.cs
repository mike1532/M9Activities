namespace Shapes
{
    partial class frmShapes
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
            this.lblSelectShape = new System.Windows.Forms.Label();
            this.cbSelectShape = new System.Windows.Forms.ComboBox();
            this.lblEnterLength = new System.Windows.Forms.Label();
            this.lblEnterWidth = new System.Windows.Forms.Label();
            this.txtEnterLength = new System.Windows.Forms.TextBox();
            this.txtEnterWidth = new System.Windows.Forms.TextBox();
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectShape
            // 
            this.lblSelectShape.AutoSize = true;
            this.lblSelectShape.Location = new System.Drawing.Point(93, 76);
            this.lblSelectShape.Name = "lblSelectShape";
            this.lblSelectShape.Size = new System.Drawing.Size(96, 17);
            this.lblSelectShape.TabIndex = 0;
            this.lblSelectShape.Text = "Select Shape:";
            // 
            // cbSelectShape
            // 
            this.cbSelectShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectShape.FormattingEnabled = true;
            this.cbSelectShape.Items.AddRange(new object[] {
            "Rectangle",
            "Square"});
            this.cbSelectShape.Location = new System.Drawing.Point(195, 73);
            this.cbSelectShape.Name = "cbSelectShape";
            this.cbSelectShape.Size = new System.Drawing.Size(130, 24);
            this.cbSelectShape.Sorted = true;
            this.cbSelectShape.TabIndex = 1;
            this.cbSelectShape.Text = "Choose a shape";
            // 
            // lblEnterLength
            // 
            this.lblEnterLength.AutoSize = true;
            this.lblEnterLength.Location = new System.Drawing.Point(93, 125);
            this.lblEnterLength.Name = "lblEnterLength";
            this.lblEnterLength.Size = new System.Drawing.Size(94, 17);
            this.lblEnterLength.TabIndex = 2;
            this.lblEnterLength.Text = "Enter Length:";
            // 
            // lblEnterWidth
            // 
            this.lblEnterWidth.AutoSize = true;
            this.lblEnterWidth.Location = new System.Drawing.Point(93, 173);
            this.lblEnterWidth.Name = "lblEnterWidth";
            this.lblEnterWidth.Size = new System.Drawing.Size(86, 17);
            this.lblEnterWidth.TabIndex = 3;
            this.lblEnterWidth.Text = "Enter Width:";
            // 
            // txtEnterLength
            // 
            this.txtEnterLength.Location = new System.Drawing.Point(195, 122);
            this.txtEnterLength.Name = "txtEnterLength";
            this.txtEnterLength.Size = new System.Drawing.Size(130, 22);
            this.txtEnterLength.TabIndex = 4;
            // 
            // txtEnterWidth
            // 
            this.txtEnterWidth.Location = new System.Drawing.Point(195, 170);
            this.txtEnterWidth.Name = "txtEnterWidth";
            this.txtEnterWidth.Size = new System.Drawing.Size(130, 22);
            this.txtEnterWidth.TabIndex = 5;
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.Location = new System.Drawing.Point(195, 218);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(130, 31);
            this.btnCalculateArea.TabIndex = 6;
            this.btnCalculateArea.Text = "&Calculate Area";
            this.btnCalculateArea.UseVisualStyleBackColor = true;
            this.btnCalculateArea.Click += new System.EventHandler(this.btnCalculateArea_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(93, 274);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result:";
            // 
            // frmShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 412);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculateArea);
            this.Controls.Add(this.txtEnterWidth);
            this.Controls.Add(this.txtEnterLength);
            this.Controls.Add(this.lblEnterWidth);
            this.Controls.Add(this.lblEnterLength);
            this.Controls.Add(this.cbSelectShape);
            this.Controls.Add(this.lblSelectShape);
            this.Name = "frmShapes";
            this.Text = "Shapes Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectShape;
        private System.Windows.Forms.ComboBox cbSelectShape;
        private System.Windows.Forms.Label lblEnterLength;
        private System.Windows.Forms.Label lblEnterWidth;
        private System.Windows.Forms.TextBox txtEnterLength;
        private System.Windows.Forms.TextBox txtEnterWidth;
        private System.Windows.Forms.Button btnCalculateArea;
        private System.Windows.Forms.Label lblResult;
    }
}

