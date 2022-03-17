namespace TownHallD.Views
{
    partial class UserHomepageForm
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
            this.TestLabel = new System.Windows.Forms.Label();
            this.AdminButton = new System.Windows.Forms.Button();
            this.IdUserLabel = new System.Windows.Forms.Label();
            this.EditHousesButton = new System.Windows.Forms.Button();
            this.EditRequestsButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.HousesPanel = new System.Windows.Forms.Panel();
            this.HouseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddressBox = new System.Windows.Forms.RichTextBox();
            this.RemoveHouseButton = new System.Windows.Forms.Button();
            this.AddHouseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RequestPanel = new System.Windows.Forms.Panel();
            this.UpdateRequestButton = new System.Windows.Forms.Button();
            this.RemoveRequestButton = new System.Windows.Forms.Button();
            this.AddRequestButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.HouseComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.HousesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.RequestPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Location = new System.Drawing.Point(12, 9);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(59, 25);
            this.TestLabel.TabIndex = 0;
            this.TestLabel.Text = "Name";
            // 
            // AdminButton
            // 
            this.AdminButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AdminButton.Location = new System.Drawing.Point(33, 166);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(188, 45);
            this.AdminButton.TabIndex = 1;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // IdUserLabel
            // 
            this.IdUserLabel.AutoSize = true;
            this.IdUserLabel.Location = new System.Drawing.Point(112, 36);
            this.IdUserLabel.Name = "IdUserLabel";
            this.IdUserLabel.Size = new System.Drawing.Size(63, 25);
            this.IdUserLabel.TabIndex = 2;
            this.IdUserLabel.Text = "IdUser";
            this.IdUserLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditHousesButton
            // 
            this.EditHousesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EditHousesButton.Location = new System.Drawing.Point(33, 270);
            this.EditHousesButton.Name = "EditHousesButton";
            this.EditHousesButton.Size = new System.Drawing.Size(188, 45);
            this.EditHousesButton.TabIndex = 3;
            this.EditHousesButton.Text = "Edit Houses";
            this.EditHousesButton.UseVisualStyleBackColor = true;
            this.EditHousesButton.Click += new System.EventHandler(this.EditHousesButton_Click);
            // 
            // EditRequestsButton
            // 
            this.EditRequestsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EditRequestsButton.Location = new System.Drawing.Point(33, 379);
            this.EditRequestsButton.Name = "EditRequestsButton";
            this.EditRequestsButton.Size = new System.Drawing.Size(188, 45);
            this.EditRequestsButton.TabIndex = 4;
            this.EditRequestsButton.Text = "Edit Requests";
            this.EditRequestsButton.UseVisualStyleBackColor = true;
            this.EditRequestsButton.Click += new System.EventHandler(this.EditRequestsButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LogoutButton.Location = new System.Drawing.Point(756, 19);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(136, 42);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // HousesPanel
            // 
            this.HousesPanel.Controls.Add(this.HouseTypeComboBox);
            this.HousesPanel.Controls.Add(this.AddressBox);
            this.HousesPanel.Controls.Add(this.RemoveHouseButton);
            this.HousesPanel.Controls.Add(this.AddHouseButton);
            this.HousesPanel.Controls.Add(this.dataGridView1);
            this.HousesPanel.Location = new System.Drawing.Point(244, 81);
            this.HousesPanel.Name = "HousesPanel";
            this.HousesPanel.Size = new System.Drawing.Size(667, 427);
            this.HousesPanel.TabIndex = 6;
            // 
            // HouseTypeComboBox
            // 
            this.HouseTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "APARTMENT",
            "HOUSE"});
            this.HouseTypeComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.HouseTypeComboBox.FormattingEnabled = true;
            this.HouseTypeComboBox.Items.AddRange(new object[] {
            "APARTAMENT",
            "HOUSE"});
            this.HouseTypeComboBox.Location = new System.Drawing.Point(205, 22);
            this.HouseTypeComboBox.Name = "HouseTypeComboBox";
            this.HouseTypeComboBox.Size = new System.Drawing.Size(146, 33);
            this.HouseTypeComboBox.TabIndex = 4;
            this.HouseTypeComboBox.Text = "Type";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(18, 17);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(181, 41);
            this.AddressBox.TabIndex = 3;
            this.AddressBox.Text = "";
            // 
            // RemoveHouseButton
            // 
            this.RemoveHouseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveHouseButton.Location = new System.Drawing.Point(512, 17);
            this.RemoveHouseButton.Name = "RemoveHouseButton";
            this.RemoveHouseButton.Size = new System.Drawing.Size(136, 41);
            this.RemoveHouseButton.TabIndex = 2;
            this.RemoveHouseButton.Text = "Remove House";
            this.RemoveHouseButton.UseVisualStyleBackColor = true;
            this.RemoveHouseButton.Click += new System.EventHandler(this.RemoveHouseButton_Click);
            // 
            // AddHouseButton
            // 
            this.AddHouseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddHouseButton.Location = new System.Drawing.Point(357, 17);
            this.AddHouseButton.Name = "AddHouseButton";
            this.AddHouseButton.Size = new System.Drawing.Size(136, 41);
            this.AddHouseButton.TabIndex = 1;
            this.AddHouseButton.Text = "Add House";
            this.AddHouseButton.UseVisualStyleBackColor = true;
            this.AddHouseButton.Click += new System.EventHandler(this.AddHouseButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(630, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RequestPanel
            // 
            this.RequestPanel.Controls.Add(this.UpdateRequestButton);
            this.RequestPanel.Controls.Add(this.RemoveRequestButton);
            this.RequestPanel.Controls.Add(this.AddRequestButton);
            this.RequestPanel.Controls.Add(this.comboBox2);
            this.RequestPanel.Controls.Add(this.HouseComboBox);
            this.RequestPanel.Controls.Add(this.dataGridView2);
            this.RequestPanel.Location = new System.Drawing.Point(247, 81);
            this.RequestPanel.Name = "RequestPanel";
            this.RequestPanel.Size = new System.Drawing.Size(664, 427);
            this.RequestPanel.TabIndex = 7;
            // 
            // UpdateRequestButton
            // 
            this.UpdateRequestButton.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateRequestButton.Location = new System.Drawing.Point(457, 61);
            this.UpdateRequestButton.Name = "UpdateRequestButton";
            this.UpdateRequestButton.Size = new System.Drawing.Size(139, 45);
            this.UpdateRequestButton.TabIndex = 5;
            this.UpdateRequestButton.Text = "Update";
            this.UpdateRequestButton.UseVisualStyleBackColor = true;
            this.UpdateRequestButton.Click += new System.EventHandler(this.UpdateRequestButton_Click);
            // 
            // RemoveRequestButton
            // 
            this.RemoveRequestButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveRequestButton.Location = new System.Drawing.Point(457, 10);
            this.RemoveRequestButton.Name = "RemoveRequestButton";
            this.RemoveRequestButton.Size = new System.Drawing.Size(139, 45);
            this.RemoveRequestButton.TabIndex = 4;
            this.RemoveRequestButton.Text = "Remove";
            this.RemoveRequestButton.UseVisualStyleBackColor = true;
            this.RemoveRequestButton.Click += new System.EventHandler(this.RemoveRequestButton_Click);
            // 
            // AddRequestButton
            // 
            this.AddRequestButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddRequestButton.Location = new System.Drawing.Point(244, 34);
            this.AddRequestButton.Name = "AddRequestButton";
            this.AddRequestButton.Size = new System.Drawing.Size(139, 45);
            this.AddRequestButton.TabIndex = 3;
            this.AddRequestButton.Text = "Add";
            this.AddRequestButton.UseVisualStyleBackColor = true;
            this.AddRequestButton.Click += new System.EventHandler(this.AddRequestButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 33);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Choose Document";
            // 
            // HouseComboBox
            // 
            this.HouseComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.HouseComboBox.FormattingEnabled = true;
            this.HouseComboBox.Location = new System.Drawing.Point(15, 17);
            this.HouseComboBox.Name = "HouseComboBox";
            this.HouseComboBox.Size = new System.Drawing.Size(182, 33);
            this.HouseComboBox.TabIndex = 1;
            this.HouseComboBox.Text = "Choose House";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 118);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(630, 292);
            this.dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "IdUser";
            // 
            // UserHomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequestPanel);
            this.Controls.Add(this.HousesPanel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.EditRequestsButton);
            this.Controls.Add(this.EditHousesButton);
            this.Controls.Add(this.IdUserLabel);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.TestLabel);
            this.Name = "UserHomepageForm";
            this.Text = "HomepageForm";
            this.HousesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.RequestPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TestLabel;

        public void setTestLabel(String username)
        {
            TestLabel.Text = username;
        }

        private Button AdminButton;
        private Label IdUserLabel;

        public void hideAdminButton()
        {
            AdminButton.Hide();
        }

        public void setIdUserLabel(String id)
        {
            IdUserLabel.Text = id;
        }

        private Button EditHousesButton;
        private Button EditRequestsButton;
        private Button LogoutButton;
        private Panel HousesPanel;
        private Button RemoveHouseButton;
        private Button AddHouseButton;
        private DataGridView dataGridView1;
        private ComboBox HouseTypeComboBox;
        private RichTextBox AddressBox;
        private Panel RequestPanel;
        private Button AddRequestButton;
        private ComboBox comboBox2;
        private ComboBox HouseComboBox;
        private DataGridView dataGridView2;
        private Button UpdateRequestButton;
        private Button RemoveRequestButton;
        private Label label1;
    }
}