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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.DrinksPanel = new System.Windows.Forms.Panel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.activitiesPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxActivities = new System.Windows.Forms.TextBox();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.buttonDeleteActivity = new System.Windows.Forms.Button();
            this.buttonUpdateActivity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ListViewMain = new System.Windows.Forms.ListView();
            this.PanelTitle = new System.Windows.Forms.Label();
            this.PriceTxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.AddDrinkBtn = new System.Windows.Forms.Button();
            this.DeleteDrinkBtn = new System.Windows.Forms.Button();
            this.UpdateDrinksBtn = new System.Windows.Forms.Button();
            this.IsAlcoholicCheckBox = new System.Windows.Forms.CheckBox();
            this.NonAlcoholicCheckBox = new System.Windows.Forms.CheckBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DrinksListView = new System.Windows.Forms.ListView();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.DrinksPanel.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.activitiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.drinksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // drinksToolStripMenuItem
            // 
            this.drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            this.drinksToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.drinksToolStripMenuItem.Text = "Drinks";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.DrinksPanel);
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(12, 27);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(938, 466);
            this.pnlDashboard.TabIndex = 1;
            // 
            // DrinksPanel
            // 
            this.DrinksPanel.Controls.Add(this.PanelMain);
            this.DrinksPanel.Controls.Add(this.PriceTxtBox);
            this.DrinksPanel.Controls.Add(this.NameTxtBox);
            this.DrinksPanel.Controls.Add(this.AddDrinkBtn);
            this.DrinksPanel.Controls.Add(this.DeleteDrinkBtn);
            this.DrinksPanel.Controls.Add(this.UpdateDrinksBtn);
            this.DrinksPanel.Controls.Add(this.IsAlcoholicCheckBox);
            this.DrinksPanel.Controls.Add(this.NonAlcoholicCheckBox);
            this.DrinksPanel.Controls.Add(this.AmountLabel);
            this.DrinksPanel.Controls.Add(this.TypeLabel);
            this.DrinksPanel.Controls.Add(this.PriceLabel);
            this.DrinksPanel.Controls.Add(this.NameLabel);
            this.DrinksPanel.Controls.Add(this.DrinksListView);
            this.DrinksPanel.Location = new System.Drawing.Point(0, 0);
            this.DrinksPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DrinksPanel.Name = "DrinksPanel";
            this.DrinksPanel.Size = new System.Drawing.Size(940, 365);
            this.DrinksPanel.TabIndex = 3;
            this.DrinksPanel.Visible = false;
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.activitiesPanel);
            this.PanelMain.Controls.Add(this.pictureBox2);
            this.PanelMain.Controls.Add(this.ListViewMain);
            this.PanelMain.Controls.Add(this.PanelTitle);
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(938, 466);
            this.PanelMain.TabIndex = 3;
            this.PanelMain.Visible = false;
            // 
            // activitiesPanel
            // 
            this.activitiesPanel.Controls.Add(this.dateTimePicker2);
            this.activitiesPanel.Controls.Add(this.dateTimePicker1);
            this.activitiesPanel.Controls.Add(this.txtBoxActivities);
            this.activitiesPanel.Controls.Add(this.buttonAddActivity);
            this.activitiesPanel.Controls.Add(this.buttonDeleteActivity);
            this.activitiesPanel.Controls.Add(this.buttonUpdateActivity);
            this.activitiesPanel.Controls.Add(this.label1);
            this.activitiesPanel.Controls.Add(this.label3);
            this.activitiesPanel.Controls.Add(this.label4);
            this.activitiesPanel.Controls.Add(this.listViewActivities);
            this.activitiesPanel.Location = new System.Drawing.Point(0, 0);
            this.activitiesPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.activitiesPanel.Name = "activitiesPanel";
            this.activitiesPanel.Size = new System.Drawing.Size(940, 438);
            this.activitiesPanel.TabIndex = 4;
            this.activitiesPanel.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(591, 161);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.Value = new System.DateTime(2023, 4, 7, 20, 52, 15, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(591, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // txtBoxActivities
            // 
            this.txtBoxActivities.Location = new System.Drawing.Point(591, 44);
            this.txtBoxActivities.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBoxActivities.Name = "txtBoxActivities";
            this.txtBoxActivities.Size = new System.Drawing.Size(144, 23);
            this.txtBoxActivities.TabIndex = 10;
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Location = new System.Drawing.Point(472, 239);
            this.buttonAddActivity.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(119, 42);
            this.buttonAddActivity.TabIndex = 9;
            this.buttonAddActivity.Text = "Add Activity";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // buttonDeleteActivity
            // 
            this.buttonDeleteActivity.Location = new System.Drawing.Point(805, 239);
            this.buttonDeleteActivity.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonDeleteActivity.Name = "buttonDeleteActivity";
            this.buttonDeleteActivity.Size = new System.Drawing.Size(102, 42);
            this.buttonDeleteActivity.TabIndex = 8;
            this.buttonDeleteActivity.Text = "Delete Activity ";
            this.buttonDeleteActivity.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateActivity
            // 
            this.buttonUpdateActivity.Location = new System.Drawing.Point(642, 239);
            this.buttonUpdateActivity.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonUpdateActivity.Name = "buttonUpdateActivity";
            this.buttonUpdateActivity.Size = new System.Drawing.Size(109, 42);
            this.buttonUpdateActivity.TabIndex = 7;
            this.buttonUpdateActivity.Text = "Update Activity";
            this.buttonUpdateActivity.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // listViewActivities
            // 
            this.listViewActivities.Location = new System.Drawing.Point(25, 13);
            this.listViewActivities.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(412, 351);
            this.listViewActivities.TabIndex = 0;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(805, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 123);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // ListViewMain
            // 
            this.ListViewMain.Location = new System.Drawing.Point(16, 42);
            this.ListViewMain.Name = "ListViewMain";
            this.ListViewMain.Size = new System.Drawing.Size(766, 307);
            this.ListViewMain.TabIndex = 1;
            this.ListViewMain.UseCompatibleStateImageBehavior = false;
            // 
            // PanelTitle
            // 
            this.PanelTitle.AutoSize = true;
            this.PanelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PanelTitle.Location = new System.Drawing.Point(26, 7);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(110, 32);
            this.PanelTitle.TabIndex = 0;
            this.PanelTitle.Text = "Lecturers";
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.Location = new System.Drawing.Point(591, 105);
            this.PriceTxtBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.Size = new System.Drawing.Size(144, 23);
            this.PriceTxtBox.TabIndex = 11;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(591, 44);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(144, 23);
            this.NameTxtBox.TabIndex = 10;
            // 
            // AddDrinkBtn
            // 
            this.AddDrinkBtn.Location = new System.Drawing.Point(481, 297);
            this.AddDrinkBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddDrinkBtn.Name = "AddDrinkBtn";
            this.AddDrinkBtn.Size = new System.Drawing.Size(119, 42);
            this.AddDrinkBtn.TabIndex = 9;
            this.AddDrinkBtn.Text = "Add Drink";
            this.AddDrinkBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteDrinkBtn
            // 
            this.DeleteDrinkBtn.Location = new System.Drawing.Point(642, 297);
            this.DeleteDrinkBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DeleteDrinkBtn.Name = "DeleteDrinkBtn";
            this.DeleteDrinkBtn.Size = new System.Drawing.Size(102, 42);
            this.DeleteDrinkBtn.TabIndex = 8;
            this.DeleteDrinkBtn.Text = "Delete Drink";
            this.DeleteDrinkBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateDrinksBtn
            // 
            this.UpdateDrinksBtn.Location = new System.Drawing.Point(795, 297);
            this.UpdateDrinksBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.UpdateDrinksBtn.Name = "UpdateDrinksBtn";
            this.UpdateDrinksBtn.Size = new System.Drawing.Size(109, 42);
            this.UpdateDrinksBtn.TabIndex = 7;
            this.UpdateDrinksBtn.Text = "Update Drinks";
            this.UpdateDrinksBtn.UseVisualStyleBackColor = true;
            // 
            // IsAlcoholicCheckBox
            // 
            this.IsAlcoholicCheckBox.AutoSize = true;
            this.IsAlcoholicCheckBox.Location = new System.Drawing.Point(613, 191);
            this.IsAlcoholicCheckBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.IsAlcoholicCheckBox.Name = "IsAlcoholicCheckBox";
            this.IsAlcoholicCheckBox.Size = new System.Drawing.Size(76, 19);
            this.IsAlcoholicCheckBox.TabIndex = 6;
            this.IsAlcoholicCheckBox.Text = "Alcoholic";
            this.IsAlcoholicCheckBox.UseVisualStyleBackColor = true;
            // 
            // NonAlcoholicCheckBox
            // 
            this.NonAlcoholicCheckBox.AutoSize = true;
            this.NonAlcoholicCheckBox.Location = new System.Drawing.Point(613, 161);
            this.NonAlcoholicCheckBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NonAlcoholicCheckBox.Name = "NonAlcoholicCheckBox";
            this.NonAlcoholicCheckBox.Size = new System.Drawing.Size(102, 19);
            this.NonAlcoholicCheckBox.TabIndex = 5;
            this.NonAlcoholicCheckBox.Text = "Non Alcoholic";
            this.NonAlcoholicCheckBox.UseVisualStyleBackColor = true;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(481, 253);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(51, 15);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Amount";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(481, 180);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(76, 15);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Type of Drink";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(481, 105);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 15);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(481, 44);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // DrinksListView
            // 
            this.DrinksListView.Location = new System.Drawing.Point(25, 13);
            this.DrinksListView.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DrinksListView.Name = "DrinksListView";
            this.DrinksListView.Size = new System.Drawing.Size(395, 338);
            this.DrinksListView.TabIndex = 0;
            this.DrinksListView.UseCompatibleStateImageBehavior = false;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(13, 13);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(208, 15);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 497);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlDashboard);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.Text = "SomerenApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.DrinksPanel.ResumeLayout(false);
            this.DrinksPanel.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.activitiesPanel.ResumeLayout(false);
            this.activitiesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel activitiesPanel;
        private System.Windows.Forms.TextBox txtBoxActivities;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Button buttonDeleteActivity;
        private System.Windows.Forms.Button buttonUpdateActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}