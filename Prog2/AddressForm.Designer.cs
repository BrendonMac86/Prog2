namespace UPVApp
{
    partial class AddressForm
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
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.addressLabel1 = new System.Windows.Forms.Label();
            this.addressTextBox1 = new System.Windows.Forms.TextBox();
            this.addressTextBox2 = new System.Windows.Forms.TextBox();
            this.cityTextBox1 = new System.Windows.Forms.TextBox();
            this.stateComboBox1 = new System.Windows.Forms.ComboBox();
            this.zipTextBox1 = new System.Windows.Forms.TextBox();
            this.cityLabel1 = new System.Windows.Forms.Label();
            this.stateLabel1 = new System.Windows.Forms.Label();
            this.zipLabel1 = new System.Windows.Forms.Label();
            this.cancelButton1 = new System.Windows.Forms.Button();
            this.okButton1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Location = new System.Drawing.Point(22, 9);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(38, 13);
            this.nameLabel1.TabIndex = 0;
            this.nameLabel1.Text = "Name:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(66, 8);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(105, 20);
            this.nameTextBox1.TabIndex = 1;
            this.nameTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.NewName_Validating);
            this.nameTextBox1.Validated += new System.EventHandler(this.NewName_Validated);
            // 
            // addressLabel1
            // 
            this.addressLabel1.AutoSize = true;
            this.addressLabel1.Location = new System.Drawing.Point(12, 34);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(48, 13);
            this.addressLabel1.TabIndex = 2;
            this.addressLabel1.Text = "Address:";
            // 
            // addressTextBox1
            // 
            this.addressTextBox1.Location = new System.Drawing.Point(66, 34);
            this.addressTextBox1.Name = "addressTextBox1";
            this.addressTextBox1.Size = new System.Drawing.Size(105, 20);
            this.addressTextBox1.TabIndex = 3;
            this.addressTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.NewAddress1_Validating);
            this.addressTextBox1.Validated += new System.EventHandler(this.NewAddress1_Validated);
            // 
            // addressTextBox2
            // 
            this.addressTextBox2.Location = new System.Drawing.Point(66, 60);
            this.addressTextBox2.Name = "addressTextBox2";
            this.addressTextBox2.Size = new System.Drawing.Size(105, 20);
            this.addressTextBox2.TabIndex = 4;
            // 
            // cityTextBox1
            // 
            this.cityTextBox1.Location = new System.Drawing.Point(66, 86);
            this.cityTextBox1.Name = "cityTextBox1";
            this.cityTextBox1.Size = new System.Drawing.Size(105, 20);
            this.cityTextBox1.TabIndex = 5;
            this.cityTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.NewCity_Validating);
            this.cityTextBox1.Validated += new System.EventHandler(this.NewCity_Validated);
            // 
            // stateComboBox1
            // 
            this.stateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox1.FormattingEnabled = true;
            this.stateComboBox1.Items.AddRange(new object[] {
            "KY",
            "WV",
            "VA",
            "CA",
            "NY"});
            this.stateComboBox1.Location = new System.Drawing.Point(66, 112);
            this.stateComboBox1.Name = "stateComboBox1";
            this.stateComboBox1.Size = new System.Drawing.Size(105, 21);
            this.stateComboBox1.TabIndex = 6;
            this.stateComboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.NewState_Validating);
            this.stateComboBox1.Validated += new System.EventHandler(this.NewState_Validated);
            // 
            // zipTextBox1
            // 
            this.zipTextBox1.Location = new System.Drawing.Point(66, 139);
            this.zipTextBox1.Name = "zipTextBox1";
            this.zipTextBox1.Size = new System.Drawing.Size(105, 20);
            this.zipTextBox1.TabIndex = 7;
            this.zipTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.NewZip_Validating);
            this.zipTextBox1.Validated += new System.EventHandler(this.NewZip_Validated);
            // 
            // cityLabel1
            // 
            this.cityLabel1.AutoSize = true;
            this.cityLabel1.Location = new System.Drawing.Point(33, 86);
            this.cityLabel1.Name = "cityLabel1";
            this.cityLabel1.Size = new System.Drawing.Size(27, 13);
            this.cityLabel1.TabIndex = 8;
            this.cityLabel1.Text = "City:";
            // 
            // stateLabel1
            // 
            this.stateLabel1.AutoSize = true;
            this.stateLabel1.Location = new System.Drawing.Point(25, 112);
            this.stateLabel1.Name = "stateLabel1";
            this.stateLabel1.Size = new System.Drawing.Size(35, 13);
            this.stateLabel1.TabIndex = 9;
            this.stateLabel1.Text = "State:";
            // 
            // zipLabel1
            // 
            this.zipLabel1.AutoSize = true;
            this.zipLabel1.Location = new System.Drawing.Point(35, 139);
            this.zipLabel1.Name = "zipLabel1";
            this.zipLabel1.Size = new System.Drawing.Size(25, 13);
            this.zipLabel1.TabIndex = 10;
            this.zipLabel1.Text = "Zip:";
            // 
            // cancelButton1
            // 
            this.cancelButton1.Location = new System.Drawing.Point(96, 165);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(75, 23);
            this.cancelButton1.TabIndex = 11;
            this.cancelButton1.Text = "Cancel";
            this.cancelButton1.UseVisualStyleBackColor = true;
            this.cancelButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton1_MouseDown);
            // 
            // okButton1
            // 
            this.okButton1.Location = new System.Drawing.Point(15, 165);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(75, 23);
            this.okButton1.TabIndex = 12;
            this.okButton1.Text = "OK";
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 204);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.zipLabel1);
            this.Controls.Add(this.stateLabel1);
            this.Controls.Add(this.cityLabel1);
            this.Controls.Add(this.zipTextBox1);
            this.Controls.Add(this.stateComboBox1);
            this.Controls.Add(this.cityTextBox1);
            this.Controls.Add(this.addressTextBox2);
            this.Controls.Add(this.addressTextBox1);
            this.Controls.Add(this.addressLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.nameLabel1);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Label addressLabel1;
        private System.Windows.Forms.TextBox addressTextBox1;
        private System.Windows.Forms.TextBox addressTextBox2;
        private System.Windows.Forms.TextBox cityTextBox1;
        private System.Windows.Forms.ComboBox stateComboBox1;
        private System.Windows.Forms.TextBox zipTextBox1;
        private System.Windows.Forms.Label cityLabel1;
        private System.Windows.Forms.Label stateLabel1;
        private System.Windows.Forms.Label zipLabel1;
        private System.Windows.Forms.Button cancelButton1;
        private System.Windows.Forms.Button okButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}