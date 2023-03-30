namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            PanelMain = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ListViewMain = new System.Windows.Forms.ListView();
            PanelTitle = new System.Windows.Forms.Label();
            DrinksPanel = new System.Windows.Forms.Panel();
            AmountTxtBox = new System.Windows.Forms.TextBox();
            PriceTxtBox = new System.Windows.Forms.TextBox();
            NameTxtBox = new System.Windows.Forms.TextBox();
            AddDrinkBtn = new System.Windows.Forms.Button();
            DeleteDrinkBtn = new System.Windows.Forms.Button();
            UpdateDrinksBtn = new System.Windows.Forms.Button();
            IsAlcoholicCheckBox = new System.Windows.Forms.CheckBox();
            NonAlcoholicCheckBox = new System.Windows.Forms.CheckBox();
            AmountLabel = new System.Windows.Forms.Label();
            TypeLabel = new System.Windows.Forms.Label();
            PriceLabel = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            DrinksListView = new System.Windows.Forms.ListView();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            DrinksPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, drinksToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            menuStrip1.Size = new System.Drawing.Size(1787, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(262, 44);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(262, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(127, 38);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(129, 38);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(106, 38);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(101, 38);
            drinksToolStripMenuItem.Text = "Drinks";
            drinksToolStripMenuItem.Click += drinksToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(22, 58);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(6);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1742, 994);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(24, 28);
            lblDashboard.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(421, 32);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // PanelMain
            // 
            PanelMain.Controls.Add(pictureBox2);
            PanelMain.Controls.Add(ListViewMain);
            PanelMain.Controls.Add(PanelTitle);
            PanelMain.Location = new System.Drawing.Point(28, 62);
            PanelMain.Margin = new System.Windows.Forms.Padding(6);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new System.Drawing.Size(1742, 994);
            PanelMain.TabIndex = 3;
            PanelMain.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1495, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(241, 262);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // ListViewMain
            // 
            ListViewMain.Location = new System.Drawing.Point(30, 90);
            ListViewMain.Margin = new System.Windows.Forms.Padding(6);
            ListViewMain.Name = "ListViewMain";
            ListViewMain.Size = new System.Drawing.Size(1419, 650);
            ListViewMain.TabIndex = 1;
            ListViewMain.UseCompatibleStateImageBehavior = false;
            // 
            // PanelTitle
            // 
            PanelTitle.AutoSize = true;
            PanelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PanelTitle.Location = new System.Drawing.Point(24, 15);
            PanelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            PanelTitle.Name = "PanelTitle";
            PanelTitle.Size = new System.Drawing.Size(220, 65);
            PanelTitle.TabIndex = 0;
            PanelTitle.Text = "Lecturers";
            // 
            // DrinksPanel
            // 
            DrinksPanel.Controls.Add(AmountTxtBox);
            DrinksPanel.Controls.Add(PriceTxtBox);
            DrinksPanel.Controls.Add(NameTxtBox);
            DrinksPanel.Controls.Add(AddDrinkBtn);
            DrinksPanel.Controls.Add(DeleteDrinkBtn);
            DrinksPanel.Controls.Add(UpdateDrinksBtn);
            DrinksPanel.Controls.Add(IsAlcoholicCheckBox);
            DrinksPanel.Controls.Add(NonAlcoholicCheckBox);
            DrinksPanel.Controls.Add(AmountLabel);
            DrinksPanel.Controls.Add(TypeLabel);
            DrinksPanel.Controls.Add(PriceLabel);
            DrinksPanel.Controls.Add(NameLabel);
            DrinksPanel.Controls.Add(DrinksListView);
            DrinksPanel.Location = new System.Drawing.Point(19, 58);
            DrinksPanel.Name = "DrinksPanel";
            DrinksPanel.Size = new System.Drawing.Size(1745, 779);
            DrinksPanel.TabIndex = 3;
            DrinksPanel.Visible = false;
            // 
            // AmountTxtBox
            // 
            AmountTxtBox.Location = new System.Drawing.Point(1098, 532);
            AmountTxtBox.Name = "AmountTxtBox";
            AmountTxtBox.Size = new System.Drawing.Size(264, 39);
            AmountTxtBox.TabIndex = 12;
            // 
            // PriceTxtBox
            // 
            PriceTxtBox.Location = new System.Drawing.Point(1098, 225);
            PriceTxtBox.Name = "PriceTxtBox";
            PriceTxtBox.Size = new System.Drawing.Size(264, 39);
            PriceTxtBox.TabIndex = 11;
            // 
            // NameTxtBox
            // 
            NameTxtBox.Location = new System.Drawing.Point(1098, 94);
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.Size = new System.Drawing.Size(264, 39);
            NameTxtBox.TabIndex = 10;
            // 
            // AddDrinkBtn
            // 
            AddDrinkBtn.Location = new System.Drawing.Point(893, 634);
            AddDrinkBtn.Name = "AddDrinkBtn";
            AddDrinkBtn.Size = new System.Drawing.Size(221, 90);
            AddDrinkBtn.TabIndex = 9;
            AddDrinkBtn.Text = "Add Drink";
            AddDrinkBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteDrinkBtn
            // 
            DeleteDrinkBtn.Location = new System.Drawing.Point(1192, 634);
            DeleteDrinkBtn.Name = "DeleteDrinkBtn";
            DeleteDrinkBtn.Size = new System.Drawing.Size(190, 90);
            DeleteDrinkBtn.TabIndex = 8;
            DeleteDrinkBtn.Text = "Delete Drink";
            DeleteDrinkBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateDrinksBtn
            // 
            UpdateDrinksBtn.Location = new System.Drawing.Point(1477, 634);
            UpdateDrinksBtn.Name = "UpdateDrinksBtn";
            UpdateDrinksBtn.Size = new System.Drawing.Size(203, 90);
            UpdateDrinksBtn.TabIndex = 7;
            UpdateDrinksBtn.Text = "Update Drinks";
            UpdateDrinksBtn.UseVisualStyleBackColor = true;
            // 
            // IsAlcoholicCheckBox
            // 
            IsAlcoholicCheckBox.AutoSize = true;
            IsAlcoholicCheckBox.Location = new System.Drawing.Point(1139, 407);
            IsAlcoholicCheckBox.Name = "IsAlcoholicCheckBox";
            IsAlcoholicCheckBox.Size = new System.Drawing.Size(143, 36);
            IsAlcoholicCheckBox.TabIndex = 6;
            IsAlcoholicCheckBox.Text = "Alcoholic";
            IsAlcoholicCheckBox.UseVisualStyleBackColor = true;
            // 
            // NonAlcoholicCheckBox
            // 
            NonAlcoholicCheckBox.AutoSize = true;
            NonAlcoholicCheckBox.Location = new System.Drawing.Point(1139, 344);
            NonAlcoholicCheckBox.Name = "NonAlcoholicCheckBox";
            NonAlcoholicCheckBox.Size = new System.Drawing.Size(196, 36);
            NonAlcoholicCheckBox.TabIndex = 5;
            NonAlcoholicCheckBox.Text = "Non Alcoholic";
            NonAlcoholicCheckBox.UseVisualStyleBackColor = true;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new System.Drawing.Point(893, 539);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new System.Drawing.Size(100, 32);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Amount";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new System.Drawing.Point(893, 385);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new System.Drawing.Size(158, 32);
            TypeLabel.TabIndex = 3;
            TypeLabel.Text = "Type of Drink";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new System.Drawing.Point(893, 225);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new System.Drawing.Size(65, 32);
            PriceLabel.TabIndex = 2;
            PriceLabel.Text = "Price";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(893, 94);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(78, 32);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // DrinksListView
            // 
            DrinksListView.Location = new System.Drawing.Point(46, 28);
            DrinksListView.Name = "DrinksListView";
            DrinksListView.Size = new System.Drawing.Size(731, 716);
            DrinksListView.TabIndex = 0;
            DrinksListView.UseCompatibleStateImageBehavior = false;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1787, 1060);
            Controls.Add(DrinksPanel);
            Controls.Add(menuStrip1);
            Controls.Add(PanelMain);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            PanelMain.ResumeLayout(false);
            PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            DrinksPanel.ResumeLayout(false);
            DrinksPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView ListViewMain;
        private System.Windows.Forms.Label PanelTitle;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.Panel DrinksPanel;
        private System.Windows.Forms.TextBox PriceTxtBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Button AddDrinkBtn;
        private System.Windows.Forms.Button DeleteDrinkBtn;
        private System.Windows.Forms.Button UpdateDrinksBtn;
        private System.Windows.Forms.CheckBox IsAlcoholicCheckBox;
        private System.Windows.Forms.CheckBox NonAlcoholicCheckBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListView DrinksListView;
        private System.Windows.Forms.TextBox AmountTxtBox;
    }
}