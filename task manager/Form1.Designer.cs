namespace task_manager
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
            this.taskname = new System.Windows.Forms.Label();
            this.taskpending = new System.Windows.Forms.Label();
            this.taskfinished = new System.Windows.Forms.Label();
            this.taskstatus = new System.Windows.Forms.Label();
            this.taskprogress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.comstatus = new System.Windows.Forms.ComboBox();
            this.list1 = new System.Windows.Forms.ListBox();
            this.list3 = new System.Windows.Forms.ListBox();
            this.list2 = new System.Windows.Forms.ListBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskname
            // 
            this.taskname.AutoSize = true;
            this.taskname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskname.Location = new System.Drawing.Point(134, 176);
            this.taskname.Name = "taskname";
            this.taskname.Size = new System.Drawing.Size(166, 32);
            this.taskname.TabIndex = 0;
            this.taskname.Text = "Task Name";
            // 
            // taskpending
            // 
            this.taskpending.AutoSize = true;
            this.taskpending.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskpending.Location = new System.Drawing.Point(361, 452);
            this.taskpending.Name = "taskpending";
            this.taskpending.Size = new System.Drawing.Size(200, 32);
            this.taskpending.TabIndex = 1;
            this.taskpending.Text = "Task Pending";
            // 
            // taskfinished
            // 
            this.taskfinished.AutoSize = true;
            this.taskfinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskfinished.Location = new System.Drawing.Point(125, 452);
            this.taskfinished.Name = "taskfinished";
            this.taskfinished.Size = new System.Drawing.Size(204, 32);
            this.taskfinished.TabIndex = 2;
            this.taskfinished.Text = "Task Finished";
            // 
            // taskstatus
            // 
            this.taskstatus.AutoSize = true;
            this.taskstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskstatus.Location = new System.Drawing.Point(134, 251);
            this.taskstatus.Name = "taskstatus";
            this.taskstatus.Size = new System.Drawing.Size(174, 32);
            this.taskstatus.TabIndex = 3;
            this.taskstatus.Text = "Task Status";
            // 
            // taskprogress
            // 
            this.taskprogress.AutoSize = true;
            this.taskprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskprogress.Location = new System.Drawing.Point(639, 452);
            this.taskprogress.Name = "taskprogress";
            this.taskprogress.Size = new System.Drawing.Size(241, 32);
            this.taskprogress.TabIndex = 4;
            this.taskprogress.Text = "Task in Progress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Task Manager";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(386, 176);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(267, 34);
            this.txtname.TabIndex = 6;
            // 
            // comstatus
            // 
            this.comstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.comstatus.FormattingEnabled = true;
            this.comstatus.Items.AddRange(new object[] {
            "Finished",
            "Pending",
            "In Progress"});
            this.comstatus.Location = new System.Drawing.Point(386, 258);
            this.comstatus.Name = "comstatus";
            this.comstatus.Size = new System.Drawing.Size(284, 38);
            this.comstatus.TabIndex = 7;
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 16;
            this.list1.Location = new System.Drawing.Point(131, 494);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(179, 196);
            this.list1.TabIndex = 8;
            // 
            // list3
            // 
            this.list3.FormattingEnabled = true;
            this.list3.ItemHeight = 16;
            this.list3.Location = new System.Drawing.Point(645, 494);
            this.list3.Name = "list3";
            this.list3.Size = new System.Drawing.Size(179, 196);
            this.list3.TabIndex = 11;
            // 
            // list2
            // 
            this.list2.FormattingEnabled = true;
            this.list2.ItemHeight = 16;
            this.list2.Location = new System.Drawing.Point(367, 494);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(179, 196);
            this.list2.TabIndex = 12;
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.savebtn.Location = new System.Drawing.Point(444, 329);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(136, 53);
            this.savebtn.TabIndex = 13;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.clearbtn.Location = new System.Drawing.Point(792, 329);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(136, 53);
            this.clearbtn.TabIndex = 15;
            this.clearbtn.Text = "Clear";
            this.clearbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 762);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.list3);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.comstatus);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.taskprogress);
            this.Controls.Add(this.taskstatus);
            this.Controls.Add(this.taskfinished);
            this.Controls.Add(this.taskpending);
            this.Controls.Add(this.taskname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskname;
        private System.Windows.Forms.Label taskpending;
        private System.Windows.Forms.Label taskfinished;
        private System.Windows.Forms.Label taskstatus;
        private System.Windows.Forms.Label taskprogress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox comstatus;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.ListBox list3;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button clearbtn;
    }
}

