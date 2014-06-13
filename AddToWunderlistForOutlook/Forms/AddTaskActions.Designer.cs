namespace AddToWunderlistForOutlook.Forms
{
    partial class AddTaskActions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskActions));
            this.dateDueDate = new System.Windows.Forms.DateTimePicker();
            this.dateRemindDate = new System.Windows.Forms.DateTimePicker();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picDueDateCancel = new System.Windows.Forms.PictureBox();
            this.picRemindMeAccept = new System.Windows.Forms.PictureBox();
            this.picRemindMeCancel = new System.Windows.Forms.PictureBox();
            this.picDueDateAccept = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picDueDateCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemindMeAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemindMeCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDueDateAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateDueDate
            // 
            this.dateDueDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dateDueDate.Enabled = false;
            this.dateDueDate.Location = new System.Drawing.Point(122, 87);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Size = new System.Drawing.Size(200, 20);
            this.dateDueDate.TabIndex = 4;
            // 
            // dateRemindDate
            // 
            this.dateRemindDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dateRemindDate.Enabled = false;
            this.dateRemindDate.Location = new System.Drawing.Point(122, 121);
            this.dateRemindDate.Name = "dateRemindDate";
            this.dateRemindDate.Size = new System.Drawing.Size(200, 20);
            this.dateRemindDate.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtTitle.Location = new System.Drawing.Point(26, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(536, 22);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "subject";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Info;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNote.Location = new System.Drawing.Point(13, 16);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(577, 175);
            this.txtNote.TabIndex = 1;
            this.txtNote.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(429, 388);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&Add to Wunderlist";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(555, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Set due date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(24, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Remind me";
            // 
            // picDueDateCancel
            // 
            this.picDueDateCancel.Location = new System.Drawing.Point(351, 91);
            this.picDueDateCancel.Name = "picDueDateCancel";
            this.picDueDateCancel.Size = new System.Drawing.Size(16, 16);
            this.picDueDateCancel.TabIndex = 18;
            this.picDueDateCancel.TabStop = false;
            this.picDueDateCancel.Click += new System.EventHandler(this.picDueDateCancel_Click);
            // 
            // picRemindMeAccept
            // 
            this.picRemindMeAccept.Location = new System.Drawing.Point(329, 125);
            this.picRemindMeAccept.Name = "picRemindMeAccept";
            this.picRemindMeAccept.Size = new System.Drawing.Size(16, 16);
            this.picRemindMeAccept.TabIndex = 17;
            this.picRemindMeAccept.TabStop = false;
            // 
            // picRemindMeCancel
            // 
            this.picRemindMeCancel.Location = new System.Drawing.Point(351, 125);
            this.picRemindMeCancel.Name = "picRemindMeCancel";
            this.picRemindMeCancel.Size = new System.Drawing.Size(16, 16);
            this.picRemindMeCancel.TabIndex = 16;
            this.picRemindMeCancel.TabStop = false;
            this.picRemindMeCancel.Click += new System.EventHandler(this.picRemindMeCancel_Click);
            // 
            // picDueDateAccept
            // 
            this.picDueDateAccept.Location = new System.Drawing.Point(329, 91);
            this.picDueDateAccept.Name = "picDueDateAccept";
            this.picDueDateAccept.Size = new System.Drawing.Size(16, 16);
            this.picDueDateAccept.TabIndex = 15;
            this.picDueDateAccept.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(585, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 60);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Location = new System.Drawing.Point(26, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 208);
            this.panel1.TabIndex = 19;
            // 
            // AddTaskActions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(655, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picDueDateCancel);
            this.Controls.Add(this.picRemindMeAccept);
            this.Controls.Add(this.picRemindMeCancel);
            this.Controls.Add(this.picDueDateAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.dateRemindDate);
            this.Controls.Add(this.dateDueDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTaskActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add to Wunderlist";
            this.Load += new System.EventHandler(this.SelectListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDueDateCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemindMeAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemindMeCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDueDateAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateDueDate;
        private System.Windows.Forms.DateTimePicker dateRemindDate;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picDueDateAccept;
        private System.Windows.Forms.PictureBox picRemindMeCancel;
        private System.Windows.Forms.PictureBox picRemindMeAccept;
        private System.Windows.Forms.PictureBox picDueDateCancel;
        private System.Windows.Forms.Panel panel1;
        
     

    }
}