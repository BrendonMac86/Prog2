namespace UPVApp
{
    partial class LetterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationComboBox2 = new System.Windows.Forms.ComboBox();
            this.costTextBox1 = new System.Windows.Forms.TextBox();
            this.okButton2 = new System.Windows.Forms.Button();
            this.cancelButton2 = new System.Windows.Forms.Button();
            this.originComboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origin Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fixed Cost:";
            // 
            // destinationComboBox2
            // 
            this.destinationComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationComboBox2.FormattingEnabled = true;
            this.destinationComboBox2.Location = new System.Drawing.Point(128, 32);
            this.destinationComboBox2.Name = "destinationComboBox2";
            this.destinationComboBox2.Size = new System.Drawing.Size(121, 21);
            this.destinationComboBox2.TabIndex = 4;
            this.destinationComboBox2.Validating += new System.ComponentModel.CancelEventHandler(this.ToAddress_Validating);
            this.destinationComboBox2.Validated += new System.EventHandler(this.ToAddress_Validated);
            // 
            // costTextBox1
            // 
            this.costTextBox1.Location = new System.Drawing.Point(128, 60);
            this.costTextBox1.Name = "costTextBox1";
            this.costTextBox1.Size = new System.Drawing.Size(121, 20);
            this.costTextBox1.TabIndex = 5;
            this.costTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.NewCost_Validating);
            this.costTextBox1.Validated += new System.EventHandler(this.NewCost_Validated);
            // 
            // okButton2
            // 
            this.okButton2.Location = new System.Drawing.Point(21, 103);
            this.okButton2.Name = "okButton2";
            this.okButton2.Size = new System.Drawing.Size(75, 23);
            this.okButton2.TabIndex = 6;
            this.okButton2.Text = "OK";
            this.okButton2.UseVisualStyleBackColor = true;
            this.okButton2.Click += new System.EventHandler(this.okButton2_Click);
            // 
            // cancelButton2
            // 
            this.cancelButton2.Location = new System.Drawing.Point(174, 103);
            this.cancelButton2.Name = "cancelButton2";
            this.cancelButton2.Size = new System.Drawing.Size(75, 23);
            this.cancelButton2.TabIndex = 7;
            this.cancelButton2.Text = "Cancel";
            this.cancelButton2.UseVisualStyleBackColor = true;
            this.cancelButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton2_MouseDown);
            // 
            // originComboBox1
            // 
            this.originComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originComboBox1.FormattingEnabled = true;
            this.originComboBox1.Location = new System.Drawing.Point(128, 5);
            this.originComboBox1.Name = "originComboBox1";
            this.originComboBox1.Size = new System.Drawing.Size(121, 21);
            this.originComboBox1.TabIndex = 1;
            this.originComboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.FromAddress_Validating);
            this.originComboBox1.Validated += new System.EventHandler(this.FromAddress_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 145);
            this.Controls.Add(this.originComboBox1);
            this.Controls.Add(this.cancelButton2);
            this.Controls.Add(this.okButton2);
            this.Controls.Add(this.costTextBox1);
            this.Controls.Add(this.destinationComboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox destinationComboBox2;
        private System.Windows.Forms.TextBox costTextBox1;
        private System.Windows.Forms.Button okButton2;
        private System.Windows.Forms.Button cancelButton2;
        private System.Windows.Forms.ComboBox originComboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}