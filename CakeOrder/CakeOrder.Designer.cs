namespace CakeOrder
{
    partial class frmCakeOrder
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
            this.lbCakes = new System.Windows.Forms.ListBox();
            this.lblSelectedCake = new System.Windows.Forms.Label();
            this.lblCakeList = new System.Windows.Forms.Label();
            this.chkMacaroons = new System.Windows.Forms.CheckBox();
            this.chkStrawberries = new System.Windows.Forms.CheckBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkChocolateFlakes = new System.Windows.Forms.CheckBox();
            this.lblAdditionalPrice = new System.Windows.Forms.Label();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.rbPickUp = new System.Windows.Forms.RadioButton();
            this.lblDeliveryOption = new System.Windows.Forms.Label();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.gbToppings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCakes
            // 
            this.lbCakes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCakes.FormattingEnabled = true;
            this.lbCakes.ItemHeight = 18;
            this.lbCakes.Items.AddRange(new object[] {
            "Chocolate Cake",
            "Vanilla Cake",
            "Strawberry Cheesecake",
            "Upside Down Pineapple Cake",
            "Fig Cake",
            "Oreo Cheesecake",
            "Mud Cake",
            "Black Forrest Cake",
            "White Forrest Cake",
            "Carrot Cake"});
            this.lbCakes.Location = new System.Drawing.Point(47, 74);
            this.lbCakes.Name = "lbCakes";
            this.lbCakes.Size = new System.Drawing.Size(226, 184);
            this.lbCakes.TabIndex = 0;
            this.lbCakes.SelectedIndexChanged += new System.EventHandler(this.lbCakes_SelectedIndexChanged);
            // 
            // lblSelectedCake
            // 
            this.lblSelectedCake.AutoSize = true;
            this.lblSelectedCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCake.Location = new System.Drawing.Point(41, 277);
            this.lblSelectedCake.Name = "lblSelectedCake";
            this.lblSelectedCake.Size = new System.Drawing.Size(108, 18);
            this.lblSelectedCake.TabIndex = 1;
            this.lblSelectedCake.Text = "Selected Cake:";
            // 
            // lblCakeList
            // 
            this.lblCakeList.AutoSize = true;
            this.lblCakeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCakeList.Location = new System.Drawing.Point(44, 33);
            this.lblCakeList.Name = "lblCakeList";
            this.lblCakeList.Size = new System.Drawing.Size(104, 18);
            this.lblCakeList.TabIndex = 2;
            this.lblCakeList.Text = "Select a Cake:";
            // 
            // chkMacaroons
            // 
            this.chkMacaroons.AutoSize = true;
            this.chkMacaroons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMacaroons.Location = new System.Drawing.Point(6, 41);
            this.chkMacaroons.Name = "chkMacaroons";
            this.chkMacaroons.Size = new System.Drawing.Size(135, 22);
            this.chkMacaroons.TabIndex = 4;
            this.chkMacaroons.Text = "Macaroons - $7";
            this.chkMacaroons.UseVisualStyleBackColor = true;
            this.chkMacaroons.CheckedChanged += new System.EventHandler(this.chkMacaroons_CheckedChanged);
            // 
            // chkStrawberries
            // 
            this.chkStrawberries.AutoSize = true;
            this.chkStrawberries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStrawberries.Location = new System.Drawing.Point(6, 68);
            this.chkStrawberries.Name = "chkStrawberries";
            this.chkStrawberries.Size = new System.Drawing.Size(142, 22);
            this.chkStrawberries.TabIndex = 5;
            this.chkStrawberries.Text = "Strawberries - $4";
            this.chkStrawberries.UseVisualStyleBackColor = true;
            this.chkStrawberries.CheckedChanged += new System.EventHandler(this.chkStrawberries_CheckedChanged);
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNuts.Location = new System.Drawing.Point(6, 95);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(90, 22);
            this.chkNuts.TabIndex = 6;
            this.chkNuts.Text = "Nuts - $5";
            this.chkNuts.UseVisualStyleBackColor = true;
            this.chkNuts.CheckedChanged += new System.EventHandler(this.chkNuts_CheckedChanged);
            // 
            // chkChocolateFlakes
            // 
            this.chkChocolateFlakes.AutoSize = true;
            this.chkChocolateFlakes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChocolateFlakes.Location = new System.Drawing.Point(6, 122);
            this.chkChocolateFlakes.Name = "chkChocolateFlakes";
            this.chkChocolateFlakes.Size = new System.Drawing.Size(175, 22);
            this.chkChocolateFlakes.TabIndex = 7;
            this.chkChocolateFlakes.Text = "Chocolate Flakes - $3";
            this.chkChocolateFlakes.UseVisualStyleBackColor = true;
            this.chkChocolateFlakes.CheckedChanged += new System.EventHandler(this.chkChocolateFlakes_CheckedChanged);
            // 
            // lblAdditionalPrice
            // 
            this.lblAdditionalPrice.AutoSize = true;
            this.lblAdditionalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalPrice.Location = new System.Drawing.Point(6, 186);
            this.lblAdditionalPrice.Name = "lblAdditionalPrice";
            this.lblAdditionalPrice.Size = new System.Drawing.Size(113, 18);
            this.lblAdditionalPrice.TabIndex = 8;
            this.lblAdditionalPrice.Text = "Additional Price:";
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDelivery.Location = new System.Drawing.Point(6, 40);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(81, 22);
            this.rbDelivery.TabIndex = 10;
            this.rbDelivery.TabStop = true;
            this.rbDelivery.Text = "Delivery";
            this.rbDelivery.UseVisualStyleBackColor = true;
            this.rbDelivery.CheckedChanged += new System.EventHandler(this.rbDelivery_CheckedChanged);
            // 
            // rbPickUp
            // 
            this.rbPickUp.AutoSize = true;
            this.rbPickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPickUp.Location = new System.Drawing.Point(6, 67);
            this.rbPickUp.Name = "rbPickUp";
            this.rbPickUp.Size = new System.Drawing.Size(81, 22);
            this.rbPickUp.TabIndex = 11;
            this.rbPickUp.TabStop = true;
            this.rbPickUp.Text = "Pick Up";
            this.rbPickUp.UseVisualStyleBackColor = true;
            this.rbPickUp.CheckedChanged += new System.EventHandler(this.rbPickUp_CheckedChanged);
            // 
            // lblDeliveryOption
            // 
            this.lblDeliveryOption.AutoSize = true;
            this.lblDeliveryOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryOption.Location = new System.Drawing.Point(6, 186);
            this.lblDeliveryOption.Name = "lblDeliveryOption";
            this.lblDeliveryOption.Size = new System.Drawing.Size(112, 18);
            this.lblDeliveryOption.TabIndex = 12;
            this.lblDeliveryOption.Text = "Delivery Option:";
            this.lblDeliveryOption.Click += new System.EventHandler(this.lblDeliveryOption_Click);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkMacaroons);
            this.gbToppings.Controls.Add(this.chkStrawberries);
            this.gbToppings.Controls.Add(this.chkNuts);
            this.gbToppings.Controls.Add(this.chkChocolateFlakes);
            this.gbToppings.Controls.Add(this.lblAdditionalPrice);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(44, 332);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(199, 225);
            this.gbToppings.TabIndex = 13;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDelivery);
            this.groupBox1.Controls.Add(this.rbPickUp);
            this.groupBox1.Controls.Add(this.lblDeliveryOption);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(324, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 225);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Options";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(340, 33);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(85, 18);
            this.lblOrderDate.TabIndex = 15;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderDate.Location = new System.Drawing.Point(337, 74);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(269, 24);
            this.dtpOrderDate.TabIndex = 16;
            // 
            // frmCakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 585);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.lblCakeList);
            this.Controls.Add(this.lblSelectedCake);
            this.Controls.Add(this.lbCakes);
            this.Name = "frmCakeOrder";
            this.Text = "Cake Order";
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCakes;
        private System.Windows.Forms.Label lblSelectedCake;
        private System.Windows.Forms.Label lblCakeList;
        private System.Windows.Forms.CheckBox chkMacaroons;
        private System.Windows.Forms.CheckBox chkStrawberries;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkChocolateFlakes;
        private System.Windows.Forms.Label lblAdditionalPrice;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.RadioButton rbPickUp;
        private System.Windows.Forms.Label lblDeliveryOption;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
    }
}

