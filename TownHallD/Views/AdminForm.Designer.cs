using TownHallD.DTO;

namespace TownHallD.Views
{
    partial class AdminForm
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
            this.ShowUsersButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditDocumentButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RemoveDocumentButton = new System.Windows.Forms.Button();
            this.AddDocumentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentTypeBox = new System.Windows.Forms.RichTextBox();
            this.RequestPanel = new System.Windows.Forms.Panel();
            this.UpdateRequestButton = new System.Windows.Forms.Button();
            this.RemoveRequestButton = new System.Windows.Forms.Button();
            this.RequestGridView = new System.Windows.Forms.DataGridView();
            this.EditRequestsButton = new System.Windows.Forms.Button();
            this.Back2HomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.RequestPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowUsersButton
            // 
            this.ShowUsersButton.Location = new System.Drawing.Point(39, 41);
            this.ShowUsersButton.Name = "ShowUsersButton";
            this.ShowUsersButton.Size = new System.Drawing.Size(155, 42);
            this.ShowUsersButton.TabIndex = 0;
            this.ShowUsersButton.Text = "Show All Users";
            this.ShowUsersButton.UseVisualStyleBackColor = true;
            this.ShowUsersButton.Click += new System.EventHandler(this.ShowUsersButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(779, 427);
            this.dataGridView1.TabIndex = 1;
            // 
            // EditDocumentButton
            // 
            this.EditDocumentButton.Location = new System.Drawing.Point(39, 118);
            this.EditDocumentButton.Name = "EditDocumentButton";
            this.EditDocumentButton.Size = new System.Drawing.Size(155, 42);
            this.EditDocumentButton.TabIndex = 2;
            this.EditDocumentButton.Text = "Edit Document";
            this.EditDocumentButton.UseVisualStyleBackColor = true;
            this.EditDocumentButton.Click += new System.EventHandler(this.EditDocumentButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.RemoveDocumentButton);
            this.panel1.Controls.Add(this.AddDocumentButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DocumentTypeBox);
            this.panel1.Location = new System.Drawing.Point(337, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 462);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 77);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(679, 366);
            this.dataGridView2.TabIndex = 4;
            // 
            // RemoveDocumentButton
            // 
            this.RemoveDocumentButton.Location = new System.Drawing.Point(555, 20);
            this.RemoveDocumentButton.Name = "RemoveDocumentButton";
            this.RemoveDocumentButton.Size = new System.Drawing.Size(112, 37);
            this.RemoveDocumentButton.TabIndex = 3;
            this.RemoveDocumentButton.Text = "Remove";
            this.RemoveDocumentButton.UseVisualStyleBackColor = true;
            this.RemoveDocumentButton.Click += new System.EventHandler(this.RemoveDocumentButton_Click);
            // 
            // AddDocumentButton
            // 
            this.AddDocumentButton.Location = new System.Drawing.Point(410, 19);
            this.AddDocumentButton.Name = "AddDocumentButton";
            this.AddDocumentButton.Size = new System.Drawing.Size(112, 37);
            this.AddDocumentButton.TabIndex = 2;
            this.AddDocumentButton.Text = "Add";
            this.AddDocumentButton.UseVisualStyleBackColor = true;
            this.AddDocumentButton.Click += new System.EventHandler(this.AddDocumentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Document Type";
            // 
            // DocumentTypeBox
            // 
            this.DocumentTypeBox.Location = new System.Drawing.Point(176, 20);
            this.DocumentTypeBox.Name = "DocumentTypeBox";
            this.DocumentTypeBox.Size = new System.Drawing.Size(201, 37);
            this.DocumentTypeBox.TabIndex = 0;
            this.DocumentTypeBox.Text = "";
            // 
            // RequestPanel
            // 
            this.RequestPanel.Controls.Add(this.UpdateRequestButton);
            this.RequestPanel.Controls.Add(this.RemoveRequestButton);
            this.RequestPanel.Controls.Add(this.RequestGridView);
            this.RequestPanel.Location = new System.Drawing.Point(357, 26);
            this.RequestPanel.Name = "RequestPanel";
            this.RequestPanel.Size = new System.Drawing.Size(704, 474);
            this.RequestPanel.TabIndex = 4;
            // 
            // UpdateRequestButton
            // 
            this.UpdateRequestButton.Location = new System.Drawing.Point(387, 19);
            this.UpdateRequestButton.Name = "UpdateRequestButton";
            this.UpdateRequestButton.Size = new System.Drawing.Size(142, 38);
            this.UpdateRequestButton.TabIndex = 2;
            this.UpdateRequestButton.Text = "Update";
            this.UpdateRequestButton.UseVisualStyleBackColor = true;
            // 
            // RemoveRequestButton
            // 
            this.RemoveRequestButton.Location = new System.Drawing.Point(143, 18);
            this.RemoveRequestButton.Name = "RemoveRequestButton";
            this.RemoveRequestButton.Size = new System.Drawing.Size(142, 39);
            this.RemoveRequestButton.TabIndex = 1;
            this.RemoveRequestButton.Text = "Remove";
            this.RemoveRequestButton.UseVisualStyleBackColor = true;
            // 
            // RequestGridView
            // 
            this.RequestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestGridView.Location = new System.Drawing.Point(24, 78);
            this.RequestGridView.Name = "RequestGridView";
            this.RequestGridView.RowHeadersWidth = 62;
            this.RequestGridView.RowTemplate.Height = 33;
            this.RequestGridView.Size = new System.Drawing.Size(652, 380);
            this.RequestGridView.TabIndex = 0;
            // 
            // EditRequestsButton
            // 
            this.EditRequestsButton.Location = new System.Drawing.Point(39, 185);
            this.EditRequestsButton.Name = "EditRequestsButton";
            this.EditRequestsButton.Size = new System.Drawing.Size(155, 41);
            this.EditRequestsButton.TabIndex = 5;
            this.EditRequestsButton.Text = "Edit Request";
            this.EditRequestsButton.UseVisualStyleBackColor = true;
            this.EditRequestsButton.Click += new System.EventHandler(this.EditRequestsButton_Click);
            // 
            // Back2HomeButton
            // 
            this.Back2HomeButton.Location = new System.Drawing.Point(63, 301);
            this.Back2HomeButton.Name = "Back2HomeButton";
            this.Back2HomeButton.Size = new System.Drawing.Size(112, 34);
            this.Back2HomeButton.TabIndex = 6;
            this.Back2HomeButton.Text = "Back";
            this.Back2HomeButton.UseVisualStyleBackColor = true;
            this.Back2HomeButton.Click += new System.EventHandler(this.Back2HomeButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 515);
            this.Controls.Add(this.Back2HomeButton);
            this.Controls.Add(this.EditRequestsButton);
            this.Controls.Add(this.RequestPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EditDocumentButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowUsersButton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.RequestPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RequestGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ShowUsersButton;
        private DataGridView dataGridView1;

        void hideSelectUserGrid()
        {
            dataGridView1.Hide();

        }

        void showSelectUserGrid()
        {
            dataGridView1.Show();
        }

        void setSelectUserGrid(List<UserDTO> users)
        {
            dataGridView1.DataSource = users;
        }

        void setDocumentGrid(List<DocumentDTO> docs)
        {
            dataGridView2.DataSource = docs;
        }


        private Button EditDocumentButton;
        private Panel panel1;
        private DataGridView dataGridView2;
        private Button RemoveDocumentButton;
        private Button AddDocumentButton;
        private Label label1;
        private RichTextBox DocumentTypeBox;

        void hideEditDocument()
        {
            panel1.Hide();
        }

        void showEditDocument()
        {
            panel1.Show();
        }

        private Panel RequestPanel;
        private Button UpdateRequestButton;
        private Button RemoveRequestButton;
        private DataGridView RequestGridView;
        private Button EditRequestsButton;
        private Button Back2HomeButton;
    }
}