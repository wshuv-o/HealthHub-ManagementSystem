namespace HospitalManagementSystem
{
    partial class AddMedicineUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.expireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExpireLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.manufactureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.medNametextBox = new System.Windows.Forms.TextBox();
            this.contactLlabel = new System.Windows.Forms.Label();
            this.manufactureLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.medNameLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(568, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Medicine";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1315, 58);
            this.panel3.TabIndex = 1;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.panel4);
            this.bodyPanel.Controls.Add(this.panel3);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 0);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1315, 942);
            this.bodyPanel.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.expireDateTimePicker);
            this.panel4.Controls.Add(this.ExpireLabel);
            this.panel4.Controls.Add(this.addButton);
            this.panel4.Controls.Add(this.manufactureDateTimePicker);
            this.panel4.Controls.Add(this.priceTextBox);
            this.panel4.Controls.Add(this.quantitytextBox);
            this.panel4.Controls.Add(this.medNametextBox);
            this.panel4.Controls.Add(this.contactLlabel);
            this.panel4.Controls.Add(this.manufactureLabel);
            this.panel4.Controls.Add(this.quantityLabel);
            this.panel4.Controls.Add(this.medNameLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1315, 886);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // expireDateTimePicker
            // 
            this.expireDateTimePicker.Location = new System.Drawing.Point(488, 346);
            this.expireDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expireDateTimePicker.Name = "expireDateTimePicker";
            this.expireDateTimePicker.Size = new System.Drawing.Size(735, 22);
            this.expireDateTimePicker.TabIndex = 45;
            // 
            // ExpireLabel
            // 
            this.ExpireLabel.AutoSize = true;
            this.ExpireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpireLabel.ForeColor = System.Drawing.Color.Black;
            this.ExpireLabel.Location = new System.Drawing.Point(103, 334);
            this.ExpireLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpireLabel.Name = "ExpireLabel";
            this.ExpireLabel.Size = new System.Drawing.Size(235, 42);
            this.ExpireLabel.TabIndex = 44;
            this.ExpireLabel.Text = "Expire Date:";
            this.ExpireLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Green;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(423, 665);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(500, 63);
            this.addButton.TabIndex = 33;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // manufactureDateTimePicker
            // 
            this.manufactureDateTimePicker.Location = new System.Drawing.Point(488, 286);
            this.manufactureDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manufactureDateTimePicker.Name = "manufactureDateTimePicker";
            this.manufactureDateTimePicker.Size = new System.Drawing.Size(735, 22);
            this.manufactureDateTimePicker.TabIndex = 32;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(488, 422);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(735, 22);
            this.priceTextBox.TabIndex = 31;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Location = new System.Drawing.Point(488, 229);
            this.quantitytextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(735, 22);
            this.quantitytextBox.TabIndex = 29;
            // 
            // medNametextBox
            // 
            this.medNametextBox.Location = new System.Drawing.Point(488, 175);
            this.medNametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medNametextBox.Name = "medNametextBox";
            this.medNametextBox.Size = new System.Drawing.Size(735, 22);
            this.medNametextBox.TabIndex = 28;
            // 
            // contactLlabel
            // 
            this.contactLlabel.AutoSize = true;
            this.contactLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLlabel.ForeColor = System.Drawing.Color.Black;
            this.contactLlabel.Location = new System.Drawing.Point(103, 406);
            this.contactLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactLlabel.Name = "contactLlabel";
            this.contactLlabel.Size = new System.Drawing.Size(287, 42);
            this.contactLlabel.TabIndex = 25;
            this.contactLlabel.Text = "Price(Per Unit):";
            this.contactLlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manufactureLabel
            // 
            this.manufactureLabel.AutoSize = true;
            this.manufactureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufactureLabel.ForeColor = System.Drawing.Color.Black;
            this.manufactureLabel.Location = new System.Drawing.Point(103, 273);
            this.manufactureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manufactureLabel.Name = "manufactureLabel";
            this.manufactureLabel.Size = new System.Drawing.Size(342, 42);
            this.manufactureLabel.TabIndex = 23;
            this.manufactureLabel.Text = "Manufacture Date:";
            this.manufactureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.Black;
            this.quantityLabel.Location = new System.Drawing.Point(97, 213);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(176, 42);
            this.quantityLabel.TabIndex = 22;
            this.quantityLabel.Text = "Quantity:";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medNameLabel
            // 
            this.medNameLabel.AutoSize = true;
            this.medNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medNameLabel.ForeColor = System.Drawing.Color.Black;
            this.medNameLabel.Location = new System.Drawing.Point(97, 159);
            this.medNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medNameLabel.Name = "medNameLabel";
            this.medNameLabel.Size = new System.Drawing.Size(301, 42);
            this.medNameLabel.TabIndex = 21;
            this.medNameLabel.Text = "Medicine Name:";
            this.medNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddMedicineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMedicineUserControl";
            this.Size = new System.Drawing.Size(1315, 942);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker manufactureDateTimePicker;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantitytextBox;
        private System.Windows.Forms.TextBox medNametextBox;
        private System.Windows.Forms.Label contactLlabel;
        private System.Windows.Forms.Label manufactureLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label medNameLabel;
        private System.Windows.Forms.DateTimePicker expireDateTimePicker;
        private System.Windows.Forms.Label ExpireLabel;
    }
}
