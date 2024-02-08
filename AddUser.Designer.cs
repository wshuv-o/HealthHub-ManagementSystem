namespace HospitalManagementSystem
{
    partial class AddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.useNameTextBox = new System.Windows.Forms.TextBox();
            this.useNameLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.lastNametextBox = new System.Windows.Forms.TextBox();
            this.firstNametextBox = new System.Windows.Forms.TextBox();
            this.contactLlabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.DobLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.panel4);
            this.bodyPanel.Controls.Add(this.panel3);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 0);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1315, 945);
            this.bodyPanel.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.Controls.Add(this.passwordTextBox);
            this.panel4.Controls.Add(this.passwordLabel);
            this.panel4.Controls.Add(this.useNameTextBox);
            this.panel4.Controls.Add(this.useNameLabel);
            this.panel4.Controls.Add(this.salaryTextBox);
            this.panel4.Controls.Add(this.salaryLabel);
            this.panel4.Controls.Add(this.genderComboBox);
            this.panel4.Controls.Add(this.addButton);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.contactTextBox);
            this.panel4.Controls.Add(this.lastNametextBox);
            this.panel4.Controls.Add(this.firstNametextBox);
            this.panel4.Controls.Add(this.contactLlabel);
            this.panel4.Controls.Add(this.genderLabel);
            this.panel4.Controls.Add(this.DobLabel);
            this.panel4.Controls.Add(this.lastNameLabel);
            this.panel4.Controls.Add(this.firstNameLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 59);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1315, 886);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(996, 549);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(261, 22);
            this.passwordTextBox.TabIndex = 43;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(751, 537);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(202, 42);
            this.passwordLabel.TabIndex = 42;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // useNameTextBox
            // 
            this.useNameTextBox.Location = new System.Drawing.Point(996, 430);
            this.useNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.useNameTextBox.Name = "useNameTextBox";
            this.useNameTextBox.Size = new System.Drawing.Size(261, 22);
            this.useNameTextBox.TabIndex = 41;
            this.useNameTextBox.TextChanged += new System.EventHandler(this.useNameTextBox_TextChanged);
            // 
            // useNameLabel
            // 
            this.useNameLabel.AutoSize = true;
            this.useNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useNameLabel.ForeColor = System.Drawing.Color.Black;
            this.useNameLabel.Location = new System.Drawing.Point(747, 414);
            this.useNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.useNameLabel.Name = "useNameLabel";
            this.useNameLabel.Size = new System.Drawing.Size(226, 42);
            this.useNameLabel.TabIndex = 40;
            this.useNameLabel.Text = "User Name:";
            this.useNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.useNameLabel.Click += new System.EventHandler(this.useNameLabel_Click);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(984, 271);
            this.salaryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(261, 22);
            this.salaryTextBox.TabIndex = 39;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.ForeColor = System.Drawing.Color.Black;
            this.salaryLabel.Location = new System.Drawing.Point(739, 258);
            this.salaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(141, 42);
            this.salaryLabel.TabIndex = 38;
            this.salaryLabel.Text = "Salary:";
            this.salaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(357, 545);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(268, 24);
            this.genderComboBox.TabIndex = 37;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Green;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(772, 642);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(500, 63);
            this.addButton.TabIndex = 33;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.sumitButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(357, 414);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 22);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(984, 135);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(261, 22);
            this.contactTextBox.TabIndex = 31;
            // 
            // lastNametextBox
            // 
            this.lastNametextBox.Location = new System.Drawing.Point(344, 271);
            this.lastNametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNametextBox.Name = "lastNametextBox";
            this.lastNametextBox.Size = new System.Drawing.Size(261, 22);
            this.lastNametextBox.TabIndex = 29;
            this.lastNametextBox.TextChanged += new System.EventHandler(this.lastNametextBox_TextChanged);
            // 
            // firstNametextBox
            // 
            this.firstNametextBox.Location = new System.Drawing.Point(357, 123);
            this.firstNametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNametextBox.Name = "firstNametextBox";
            this.firstNametextBox.Size = new System.Drawing.Size(268, 22);
            this.firstNametextBox.TabIndex = 28;
            // 
            // contactLlabel
            // 
            this.contactLlabel.AutoSize = true;
            this.contactLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLlabel.ForeColor = System.Drawing.Color.Black;
            this.contactLlabel.Location = new System.Drawing.Point(739, 123);
            this.contactLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactLlabel.Name = "contactLlabel";
            this.contactLlabel.Size = new System.Drawing.Size(165, 42);
            this.contactLlabel.TabIndex = 25;
            this.contactLlabel.Text = "Contact:";
            this.contactLlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.Color.Black;
            this.genderLabel.Location = new System.Drawing.Point(112, 533);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(160, 42);
            this.genderLabel.TabIndex = 24;
            this.genderLabel.Text = "Gender:";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DobLabel
            // 
            this.DobLabel.AutoSize = true;
            this.DobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DobLabel.ForeColor = System.Drawing.Color.Black;
            this.DobLabel.Location = new System.Drawing.Point(112, 409);
            this.DobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DobLabel.Name = "DobLabel";
            this.DobLabel.Size = new System.Drawing.Size(105, 42);
            this.DobLabel.TabIndex = 23;
            this.DobLabel.Text = "DoB:";
            this.DobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.Black;
            this.lastNameLabel.Location = new System.Drawing.Point(99, 255);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(218, 42);
            this.lastNameLabel.TabIndex = 22;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.Black;
            this.firstNameLabel.Location = new System.Drawing.Point(112, 107);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(220, 42);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1315, 58);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(568, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddUser";
            this.Size = new System.Drawing.Size(1315, 945);
            this.bodyPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox lastNametextBox;
        private System.Windows.Forms.TextBox firstNametextBox;
        private System.Windows.Forms.Label contactLlabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label DobLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox useNameTextBox;
        private System.Windows.Forms.Label useNameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
    }
}
