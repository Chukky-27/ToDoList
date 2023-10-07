namespace ToDoList
{
    partial class toDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toDoList));
            panel1 = new Panel();
            header = new Label();
            lblCompleted = new Label();
            txtId = new Label();
            resetButton = new Button();
            completedcomboBox = new ComboBox();
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescription = new TextBox();
            dtpDate = new DateTimePicker();
            txtTitle = new TextBox();
            panel2 = new Panel();
            dvg = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel3 = new Panel();
            panel4 = new Panel();
            searchtextBox = new TextBox();
            searchcomboBox = new ComboBox();
            lblSearch = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvg).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(header);
            panel1.Controls.Add(lblCompleted);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(resetButton);
            panel1.Controls.Add(completedcomboBox);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(dtpDate);
            panel1.Controls.Add(txtTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 245);
            panel1.TabIndex = 0;
            // 
            // header
            // 
            header.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point);
            header.Image = (Image)resources.GetObject("header.Image");
            header.ImageAlign = ContentAlignment.TopLeft;
            header.Location = new Point(518, 21);
            header.Name = "header";
            header.Size = new Size(309, 49);
            header.TabIndex = 14;
            header.Text = "TO DO LIST";
            header.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCompleted
            // 
            lblCompleted.BackColor = Color.Linen;
            lblCompleted.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompleted.Location = new Point(763, 151);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(100, 32);
            lblCompleted.TabIndex = 13;
            lblCompleted.Text = "Completed";
            lblCompleted.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtId
            // 
            txtId.BackColor = Color.Linen;
            txtId.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(935, 109);
            txtId.Name = "txtId";
            txtId.Size = new Size(34, 29);
            txtId.TabIndex = 12;
            txtId.Text = "Id";
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Linen;
            resetButton.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(763, 190);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(210, 34);
            resetButton.TabIndex = 11;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += ResetButton_Click;
            // 
            // completedcomboBox
            // 
            completedcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            completedcomboBox.FormattingEnabled = true;
            completedcomboBox.Items.AddRange(new object[] { "NO", "YES" });
            completedcomboBox.Location = new Point(869, 151);
            completedcomboBox.Name = "completedcomboBox";
            completedcomboBox.Size = new Size(100, 33);
            completedcomboBox.TabIndex = 10;
            // 
            // deleteButton
            // 
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.BackgroundImageLayout = ImageLayout.None;
            deleteButton.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.ImageAlign = ContentAlignment.BottomLeft;
            deleteButton.Location = new Point(1107, 169);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(141, 55);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackgroundImage = (Image)resources.GetObject("updateButton.BackgroundImage");
            updateButton.BackgroundImageLayout = ImageLayout.None;
            updateButton.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.ImageAlign = ContentAlignment.TopLeft;
            updateButton.Location = new Point(1107, 119);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(141, 44);
            updateButton.TabIndex = 7;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.BackgroundImage = (Image)resources.GetObject("addButton.BackgroundImage");
            addButton.BackgroundImageLayout = ImageLayout.None;
            addButton.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ImageAlign = ContentAlignment.TopLeft;
            addButton.Location = new Point(1107, 56);
            addButton.Name = "addButton";
            addButton.Size = new Size(141, 57);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Linen;
            label3.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(134, 55);
            label3.TabIndex = 5;
            label3.Text = "Description";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Linen;
            label2.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(367, 93);
            label2.Name = "label2";
            label2.Size = new Size(69, 40);
            label2.TabIndex = 4;
            label2.Text = "Date";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Linen;
            label1.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 93);
            label1.Name = "label1";
            label1.Size = new Size(74, 40);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(152, 169);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(590, 55);
            txtDescription.TabIndex = 2;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDate.Location = new Point(442, 93);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(421, 40);
            dtpDate.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(152, 93);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.ShortcutsEnabled = false;
            txtTitle.Size = new Size(209, 40);
            txtTitle.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dvg);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 245);
            panel2.Name = "panel2";
            panel2.Size = new Size(1281, 405);
            panel2.TabIndex = 1;
            // 
            // dvg
            // 
            dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg.Location = new Point(3, 71);
            dvg.Name = "dvg";
            dvg.RowHeadersWidth = 62;
            dvg.RowTemplate.Height = 33;
            dvg.Size = new Size(1278, 420);
            dvg.TabIndex = 0;
            dvg.CellContentClick += dvg_CellContentClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(0, 245);
            panel3.Name = "panel3";
            panel3.Size = new Size(1281, 73);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(searchtextBox);
            panel4.Controls.Add(searchcomboBox);
            panel4.Controls.Add(lblSearch);
            panel4.Location = new Point(751, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(530, 73);
            panel4.TabIndex = 0;
            // 
            // searchtextBox
            // 
            searchtextBox.Location = new Point(322, 20);
            searchtextBox.Name = "searchtextBox";
            searchtextBox.Size = new Size(197, 31);
            searchtextBox.TabIndex = 2;
            searchtextBox.TextChanged += SearchtextBox_TextChanged;
            // 
            // searchcomboBox
            // 
            searchcomboBox.FormattingEnabled = true;
            searchcomboBox.Items.AddRange(new object[] { "TITLE", "DATE" });
            searchcomboBox.Location = new Point(100, 18);
            searchcomboBox.Name = "searchcomboBox";
            searchcomboBox.Size = new Size(182, 33);
            searchcomboBox.TabIndex = 1;
            searchcomboBox.SelectedIndexChanged += searchcomboBox_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(21, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(73, 26);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // toDoList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1281, 650);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "toDoList";
            Text = "To Do List";
            Load += toDoList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvg).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtDescription;
        private DateTimePicker dtpDate;
        private TextBox txtTitle;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button addButton;
        private DataGridView dvg;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button deleteButton;
        private Button updateButton;
        private ComboBox completedcomboBox;
        private Panel panel3;
        private Panel panel4;
        private TextBox searchtextBox;
        private ComboBox searchcomboBox;
        private Label lblSearch;
        private Button resetButton;
        private Label txtId;
        private Label lblCompleted;
        private Label header;
    }
}