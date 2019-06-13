namespace ToDoList
{
    partial class startForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstNote = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "To-Do List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNote
            // 
            this.firstNote.Location = new System.Drawing.Point(29, 85);
            this.firstNote.Name = "firstNote";
            this.firstNote.Size = new System.Drawing.Size(413, 23);
            this.firstNote.TabIndex = 1;
            this.firstNote.Text = "Note 1";
            this.firstNote.UseVisualStyleBackColor = true;
            this.firstNote.Click += new System.EventHandler(this.firstNote_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(415, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstNote);
            this.Controls.Add(this.label1);
            this.Name = "startForm";
            this.Text = "To-do list";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.startForm_FormClosed);
            this.Load += new System.EventHandler(this.startForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button firstNote;
        private System.Windows.Forms.Button button1;
    }
}

