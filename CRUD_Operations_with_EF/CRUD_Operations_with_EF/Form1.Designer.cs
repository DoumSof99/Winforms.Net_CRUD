namespace CRUD_Operations_with_EF
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
            grvPerson = new DataGridView();
            ctrlID = new DataGridViewTextBoxColumn();
            ctrlFirstName = new DataGridViewTextBoxColumn();
            ctrlLastName = new DataGridViewTextBoxColumn();
            ctrlAge = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ctrlIdTxt = new Label();
            loId = new Label();
            loFirstName = new Label();
            LoLastName = new Label();
            loAge = new Label();
            ctrlAgeTxt = new TextBox();
            ctrlLastNameTxt = new TextBox();
            ctrlFirstNameTxt = new TextBox();
            ctrlSave = new Button();
            ctrlAdd = new Button();
            ctrlEdit = new Button();
            ctrlDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)grvPerson).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grvPerson
            // 
            grvPerson.AllowUserToAddRows = false;
            grvPerson.AllowUserToDeleteRows = false;
            grvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvPerson.Columns.AddRange(new DataGridViewColumn[] { ctrlID, ctrlFirstName, ctrlLastName, ctrlAge });
            grvPerson.Location = new Point(12, 222);
            grvPerson.Name = "grvPerson";
            grvPerson.ReadOnly = true;
            grvPerson.RowTemplate.Height = 25;
            grvPerson.Size = new Size(646, 321);
            grvPerson.TabIndex = 0;
            grvPerson.CellClick += grvPerson_CellClick;
            // 
            // ctrlID
            // 
            ctrlID.DataPropertyName = "Id";
            ctrlID.HeaderText = "ID";
            ctrlID.Name = "ctrlID";
            ctrlID.ReadOnly = true;
            // 
            // ctrlFirstName
            // 
            ctrlFirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ctrlFirstName.DataPropertyName = "FirstName";
            ctrlFirstName.HeaderText = "First Name";
            ctrlFirstName.Name = "ctrlFirstName";
            ctrlFirstName.ReadOnly = true;
            // 
            // ctrlLastName
            // 
            ctrlLastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ctrlLastName.DataPropertyName = "LastName";
            ctrlLastName.HeaderText = "Last Name";
            ctrlLastName.Name = "ctrlLastName";
            ctrlLastName.ReadOnly = true;
            // 
            // ctrlAge
            // 
            ctrlAge.DataPropertyName = "Age";
            ctrlAge.HeaderText = "Age";
            ctrlAge.Name = "ctrlAge";
            ctrlAge.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ctrlIdTxt);
            groupBox1.Controls.Add(loId);
            groupBox1.Controls.Add(loFirstName);
            groupBox1.Controls.Add(LoLastName);
            groupBox1.Controls.Add(loAge);
            groupBox1.Controls.Add(ctrlAgeTxt);
            groupBox1.Controls.Add(ctrlLastNameTxt);
            groupBox1.Controls.Add(ctrlFirstNameTxt);
            groupBox1.Controls.Add(ctrlSave);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(646, 204);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial Narrow", 1.5F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(120, 44);
            label1.Name = "label1";
            label1.Size = new Size(40, 10);
            label1.TabIndex = 14;
            // 
            // ctrlIdTxt
            // 
            ctrlIdTxt.AutoSize = true;
            ctrlIdTxt.Location = new Point(135, 29);
            ctrlIdTxt.Name = "ctrlIdTxt";
            ctrlIdTxt.Size = new Size(0, 15);
            ctrlIdTxt.TabIndex = 13;
            // 
            // loId
            // 
            loId.AutoSize = true;
            loId.Location = new Point(103, 29);
            loId.Name = "loId";
            loId.Size = new Size(21, 15);
            loId.TabIndex = 12;
            loId.Text = "ID:";
            // 
            // loFirstName
            // 
            loFirstName.AutoSize = true;
            loFirstName.Location = new Point(59, 151);
            loFirstName.Name = "loFirstName";
            loFirstName.Size = new Size(67, 15);
            loFirstName.TabIndex = 11;
            loFirstName.Text = "First Name:";
            // 
            // LoLastName
            // 
            LoLastName.AutoSize = true;
            LoLastName.Location = new Point(59, 88);
            LoLastName.Name = "LoLastName";
            LoLastName.Size = new Size(66, 15);
            LoLastName.TabIndex = 10;
            LoLastName.Text = "Last Name:";
            // 
            // loAge
            // 
            loAge.AutoSize = true;
            loAge.Location = new Point(233, 35);
            loAge.Name = "loAge";
            loAge.Size = new Size(31, 15);
            loAge.TabIndex = 9;
            loAge.Text = "Age:";
            // 
            // ctrlAgeTxt
            // 
            ctrlAgeTxt.Location = new Point(300, 32);
            ctrlAgeTxt.Name = "ctrlAgeTxt";
            ctrlAgeTxt.Size = new Size(189, 23);
            ctrlAgeTxt.TabIndex = 8;
            // 
            // ctrlLastNameTxt
            // 
            ctrlLastNameTxt.Location = new Point(145, 85);
            ctrlLastNameTxt.Name = "ctrlLastNameTxt";
            ctrlLastNameTxt.Size = new Size(344, 23);
            ctrlLastNameTxt.TabIndex = 7;
            // 
            // ctrlFirstNameTxt
            // 
            ctrlFirstNameTxt.Location = new Point(145, 148);
            ctrlFirstNameTxt.Name = "ctrlFirstNameTxt";
            ctrlFirstNameTxt.Size = new Size(344, 23);
            ctrlFirstNameTxt.TabIndex = 6;
            // 
            // ctrlSave
            // 
            ctrlSave.BackColor = SystemColors.Control;
            ctrlSave.Location = new Point(561, 130);
            ctrlSave.Name = "ctrlSave";
            ctrlSave.Size = new Size(70, 57);
            ctrlSave.TabIndex = 5;
            ctrlSave.Text = "Save";
            ctrlSave.UseVisualStyleBackColor = false;
            // 
            // ctrlAdd
            // 
            ctrlAdd.BackColor = SystemColors.Control;
            ctrlAdd.Location = new Point(583, 548);
            ctrlAdd.Name = "ctrlAdd";
            ctrlAdd.Size = new Size(75, 23);
            ctrlAdd.TabIndex = 2;
            ctrlAdd.Text = "Add";
            ctrlAdd.UseVisualStyleBackColor = false;
            // 
            // ctrlEdit
            // 
            ctrlEdit.BackColor = SystemColors.Control;
            ctrlEdit.Location = new Point(502, 548);
            ctrlEdit.Name = "ctrlEdit";
            ctrlEdit.Size = new Size(75, 23);
            ctrlEdit.TabIndex = 3;
            ctrlEdit.Text = "Edit";
            ctrlEdit.UseVisualStyleBackColor = false;
            // 
            // ctrlDelete
            // 
            ctrlDelete.BackColor = SystemColors.Control;
            ctrlDelete.Location = new Point(421, 549);
            ctrlDelete.Name = "ctrlDelete";
            ctrlDelete.Size = new Size(75, 23);
            ctrlDelete.TabIndex = 4;
            ctrlDelete.Text = "Delete";
            ctrlDelete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 583);
            Controls.Add(ctrlDelete);
            Controls.Add(ctrlEdit);
            Controls.Add(ctrlAdd);
            Controls.Add(groupBox1);
            Controls.Add(grvPerson);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grvPerson).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grvPerson;
        private DataGridViewTextBoxColumn ctrlID;
        private DataGridViewTextBoxColumn ctrlFirstName;
        private DataGridViewTextBoxColumn ctrlLastName;
        private DataGridViewTextBoxColumn ctrlAge;
        private GroupBox groupBox1;
        private Label label1;
        private Label ctrlIdTxt;
        private Label loId;
        private Label loFirstName;
        private Label LoLastName;
        private Label loAge;
        private TextBox ctrlAgeTxt;
        private TextBox ctrlLastNameTxt;
        private TextBox ctrlFirstNameTxt;
        private Button ctrlSave;
        private Button ctrlAdd;
        private Button ctrlEdit;
        private Button ctrlDelete;
    }
}