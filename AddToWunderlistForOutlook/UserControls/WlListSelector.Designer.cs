namespace AddToWunderlistForOutlook.UserControls
{
    partial class WlListSelector
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
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.radioButtonInbox = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButtonNew = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inbox";
            // 
            // radioButtonList
            // 
            this.radioButtonList.AutoSize = true;
            this.radioButtonList.Location = new System.Drawing.Point(11, 33);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(14, 13);
            this.radioButtonList.TabIndex = 8;
            this.radioButtonList.UseVisualStyleBackColor = true;
            this.radioButtonList.Click += new System.EventHandler(this.radioButtonInbox_Click);
            // 
            // radioButtonInbox
            // 
            this.radioButtonInbox.AutoSize = true;
            this.radioButtonInbox.Checked = true;
            this.radioButtonInbox.Location = new System.Drawing.Point(11, 10);
            this.radioButtonInbox.Name = "radioButtonInbox";
            this.radioButtonInbox.Size = new System.Drawing.Size(14, 13);
            this.radioButtonInbox.TabIndex = 7;
            this.radioButtonInbox.TabStop = true;
            this.radioButtonInbox.UseVisualStyleBackColor = true;
            this.radioButtonInbox.Click += new System.EventHandler(this.radioButtonInbox_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // radioButtonNew
            // 
            this.radioButtonNew.AutoSize = true;
            this.radioButtonNew.Location = new System.Drawing.Point(11, 60);
            this.radioButtonNew.Name = "radioButtonNew";
            this.radioButtonNew.Size = new System.Drawing.Size(14, 13);
            this.radioButtonNew.TabIndex = 10;
            this.radioButtonNew.TabStop = true;
            this.radioButtonNew.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "New";
            // 
            // WlListSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonList);
            this.Controls.Add(this.radioButtonInbox);
            this.Controls.Add(this.comboBox1);
            this.Name = "WlListSelector";
            this.Size = new System.Drawing.Size(257, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonList;
        private System.Windows.Forms.RadioButton radioButtonInbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButtonNew;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
