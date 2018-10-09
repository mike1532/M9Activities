namespace CakeOrderMenu
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cakesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardCakesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanillaCakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chocolateCakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackForrestCakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteForrestCakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheesecakesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oreoCheesecakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strawberryCheeseCakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toppingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macaroonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strawberriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chocolateFlakesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDisplayOptions = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblDeliveryOptions = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cakesToolStripMenuItem,
            this.toppingsToolStripMenuItem,
            this.deliveryOptionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cakesToolStripMenuItem
            // 
            this.cakesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardCakesToolStripMenuItem,
            this.cheesecakesToolStripMenuItem});
            this.cakesToolStripMenuItem.Name = "cakesToolStripMenuItem";
            this.cakesToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.cakesToolStripMenuItem.Text = "Cakes";
            // 
            // standardCakesToolStripMenuItem
            // 
            this.standardCakesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vanillaCakeToolStripMenuItem,
            this.chocolateCakeToolStripMenuItem,
            this.blackForrestCakeToolStripMenuItem,
            this.whiteForrestCakeToolStripMenuItem});
            this.standardCakesToolStripMenuItem.Name = "standardCakesToolStripMenuItem";
            this.standardCakesToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.standardCakesToolStripMenuItem.Text = "Standard Cakes";
            // 
            // vanillaCakeToolStripMenuItem
            // 
            this.vanillaCakeToolStripMenuItem.Name = "vanillaCakeToolStripMenuItem";
            this.vanillaCakeToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.vanillaCakeToolStripMenuItem.Text = "Vanilla Cake";
            this.vanillaCakeToolStripMenuItem.Click += new System.EventHandler(this.vanillaCakeToolStripMenuItem_Click);
            // 
            // chocolateCakeToolStripMenuItem
            // 
            this.chocolateCakeToolStripMenuItem.Name = "chocolateCakeToolStripMenuItem";
            this.chocolateCakeToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.chocolateCakeToolStripMenuItem.Text = "Chocolate Cake";
            this.chocolateCakeToolStripMenuItem.Click += new System.EventHandler(this.chocolateCakeToolStripMenuItem_Click);
            // 
            // blackForrestCakeToolStripMenuItem
            // 
            this.blackForrestCakeToolStripMenuItem.Name = "blackForrestCakeToolStripMenuItem";
            this.blackForrestCakeToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.blackForrestCakeToolStripMenuItem.Text = "Black Forest Cake";
            this.blackForrestCakeToolStripMenuItem.Click += new System.EventHandler(this.blackForrestCakeToolStripMenuItem_Click);
            // 
            // whiteForrestCakeToolStripMenuItem
            // 
            this.whiteForrestCakeToolStripMenuItem.Name = "whiteForrestCakeToolStripMenuItem";
            this.whiteForrestCakeToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.whiteForrestCakeToolStripMenuItem.Text = "White Forest Cake";
            this.whiteForrestCakeToolStripMenuItem.Click += new System.EventHandler(this.whiteForrestCakeToolStripMenuItem_Click);
            // 
            // cheesecakesToolStripMenuItem
            // 
            this.cheesecakesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oreoCheesecakeToolStripMenuItem,
            this.strawberryCheeseCakeToolStripMenuItem});
            this.cheesecakesToolStripMenuItem.Name = "cheesecakesToolStripMenuItem";
            this.cheesecakesToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.cheesecakesToolStripMenuItem.Text = "Cheesecakes";
            // 
            // oreoCheesecakeToolStripMenuItem
            // 
            this.oreoCheesecakeToolStripMenuItem.Name = "oreoCheesecakeToolStripMenuItem";
            this.oreoCheesecakeToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.oreoCheesecakeToolStripMenuItem.Text = "Oreo Cheesecake";
            this.oreoCheesecakeToolStripMenuItem.Click += new System.EventHandler(this.oreoCheesecakeToolStripMenuItem_Click);
            // 
            // strawberryCheeseCakeToolStripMenuItem
            // 
            this.strawberryCheeseCakeToolStripMenuItem.Name = "strawberryCheeseCakeToolStripMenuItem";
            this.strawberryCheeseCakeToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.strawberryCheeseCakeToolStripMenuItem.Text = "Strawberry Cheesecake";
            this.strawberryCheeseCakeToolStripMenuItem.Click += new System.EventHandler(this.strawberryCheeseCakeToolStripMenuItem_Click);
            // 
            // toppingsToolStripMenuItem
            // 
            this.toppingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.macaroonsToolStripMenuItem,
            this.strawberriesToolStripMenuItem,
            this.nutsToolStripMenuItem,
            this.chocolateFlakesToolStripMenuItem});
            this.toppingsToolStripMenuItem.Name = "toppingsToolStripMenuItem";
            this.toppingsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.toppingsToolStripMenuItem.Text = "Toppings";
            // 
            // macaroonsToolStripMenuItem
            // 
            this.macaroonsToolStripMenuItem.Name = "macaroonsToolStripMenuItem";
            this.macaroonsToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.macaroonsToolStripMenuItem.Text = "Macaroons";
            this.macaroonsToolStripMenuItem.Click += new System.EventHandler(this.macaroonsToolStripMenuItem_Click);
            // 
            // strawberriesToolStripMenuItem
            // 
            this.strawberriesToolStripMenuItem.Name = "strawberriesToolStripMenuItem";
            this.strawberriesToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.strawberriesToolStripMenuItem.Text = "Fruits";
            this.strawberriesToolStripMenuItem.Click += new System.EventHandler(this.strawberriesToolStripMenuItem_Click);
            // 
            // nutsToolStripMenuItem
            // 
            this.nutsToolStripMenuItem.Name = "nutsToolStripMenuItem";
            this.nutsToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.nutsToolStripMenuItem.Text = "Nuts";
            this.nutsToolStripMenuItem.Click += new System.EventHandler(this.nutsToolStripMenuItem_Click);
            // 
            // chocolateFlakesToolStripMenuItem
            // 
            this.chocolateFlakesToolStripMenuItem.Name = "chocolateFlakesToolStripMenuItem";
            this.chocolateFlakesToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.chocolateFlakesToolStripMenuItem.Text = "Chocolate Flakes";
            this.chocolateFlakesToolStripMenuItem.Click += new System.EventHandler(this.chocolateFlakesToolStripMenuItem_Click);
            // 
            // deliveryOptionsToolStripMenuItem
            // 
            this.deliveryOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpToolStripMenuItem,
            this.deliveryToolStripMenuItem});
            this.deliveryOptionsToolStripMenuItem.Name = "deliveryOptionsToolStripMenuItem";
            this.deliveryOptionsToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.deliveryOptionsToolStripMenuItem.Text = "Delivery Options";
            // 
            // pickUpToolStripMenuItem
            // 
            this.pickUpToolStripMenuItem.Name = "pickUpToolStripMenuItem";
            this.pickUpToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.pickUpToolStripMenuItem.Text = "Pick-Up";
            this.pickUpToolStripMenuItem.Click += new System.EventHandler(this.pickUpToolStripMenuItem_Click);
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.deliveryToolStripMenuItem.Text = "Delivery";
            this.deliveryToolStripMenuItem.Click += new System.EventHandler(this.deliveryToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblDisplayOptions
            // 
            this.lblDisplayOptions.AutoSize = true;
            this.lblDisplayOptions.ContextMenuStrip = this.contextMenuStrip1;
            this.lblDisplayOptions.Location = new System.Drawing.Point(13, 213);
            this.lblDisplayOptions.Name = "lblDisplayOptions";
            this.lblDisplayOptions.Size = new System.Drawing.Size(119, 17);
            this.lblDisplayOptions.TabIndex = 1;
            this.lblDisplayOptions.Text = "Customer Choice:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColuToolStripMenuItem,
            this.backColourToolStripMenuItem});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.colourToolStripMenuItem.Text = "Colour";
            // 
            // foreColuToolStripMenuItem
            // 
            this.foreColuToolStripMenuItem.Name = "foreColuToolStripMenuItem";
            this.foreColuToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.foreColuToolStripMenuItem.Text = "Fore Colour";
            this.foreColuToolStripMenuItem.Click += new System.EventHandler(this.foreColuToolStripMenuItem_Click);
            // 
            // backColourToolStripMenuItem
            // 
            this.backColourToolStripMenuItem.Name = "backColourToolStripMenuItem";
            this.backColourToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.backColourToolStripMenuItem.Text = "Back Colour";
            this.backColourToolStripMenuItem.Click += new System.EventHandler(this.backColourToolStripMenuItem_Click);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(12, 264);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(109, 17);
            this.lblToppings.TabIndex = 2;
            this.lblToppings.Text = "Toppings: None";
            // 
            // lblDeliveryOptions
            // 
            this.lblDeliveryOptions.AutoSize = true;
            this.lblDeliveryOptions.Location = new System.Drawing.Point(16, 314);
            this.lblDeliveryOptions.Name = "lblDeliveryOptions";
            this.lblDeliveryOptions.Size = new System.Drawing.Size(116, 17);
            this.lblDeliveryOptions.TabIndex = 3;
            this.lblDeliveryOptions.Text = "Delivery Options:";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDeliveryOptions);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblDisplayOptions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cakesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardCakesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanillaCakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chocolateCakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackForrestCakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteForrestCakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheesecakesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oreoCheesecakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strawberryCheeseCakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toppingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macaroonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strawberriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chocolateFlakesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblDisplayOptions;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblDeliveryOptions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColourToolStripMenuItem;
    }
}

