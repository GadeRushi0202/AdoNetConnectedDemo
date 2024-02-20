namespace AdoNetConnectedDemo
{
    partial class Form1
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
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(121, 95);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(221, 22);
            this.textName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 95);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(121, 162);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(221, 22);
            this.textEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(24, 162);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(121, 229);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(221, 22);
            this.textAge.TabIndex = 7;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(24, 235);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 16);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age";
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(121, 297);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(221, 22);
            this.textSalary.TabIndex = 9;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(27, 303);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(46, 16);
            this.labelSalary.TabIndex = 8;
            this.labelSalary.Text = "Salary";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(121, 27);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(221, 22);
            this.textId.TabIndex = 11;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(27, 33);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 16);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "Id";
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(24, 370);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(77, 16);
            this.labelDept.TabIndex = 12;
            this.labelDept.Text = "Department";
            // 
            // comboDept
            // 
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Location = new System.Drawing.Point(121, 362);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(221, 24);
            this.comboDept.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(390, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 40);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(390, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 37);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(390, 192);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 37);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 36);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(504, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1108, 323);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnShowall
            // 
            this.btnShowall.Location = new System.Drawing.Point(1014, 387);
            this.btnShowall.Name = "btnShowall";
            this.btnShowall.Size = new System.Drawing.Size(118, 40);
            this.btnShowall.TabIndex = 19;
            this.btnShowall.Text = "Show All";
            this.btnShowall.UseVisualStyleBackColor = true;
            this.btnShowall.Click += new System.EventHandler(this.btnShowall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 450);
            this.Controls.Add(this.btnShowall);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboDept);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowall;
    }
}

