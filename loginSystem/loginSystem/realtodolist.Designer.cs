namespace loginSystem
{
    partial class realtodolist
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
            this.lists = new System.Windows.Forms.CheckedListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.listadder = new System.Windows.Forms.TextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lists
            // 
            this.lists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lists.FormattingEnabled = true;
            this.lists.Location = new System.Drawing.Point(25, 156);
            this.lists.Name = "lists";
            this.lists.Size = new System.Drawing.Size(406, 123);
            this.lists.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.HotPink;
            this.addBtn.Location = new System.Drawing.Point(278, 64);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 50);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // listadder
            // 
            this.listadder.BackColor = System.Drawing.Color.HotPink;
            this.listadder.Location = new System.Drawing.Point(25, 78);
            this.listadder.Name = "listadder";
            this.listadder.Size = new System.Drawing.Size(180, 22);
            this.listadder.TabIndex = 2;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Lime;
            this.Deletebtn.Location = new System.Drawing.Point(130, 330);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(122, 50);
            this.Deletebtn.TabIndex = 3;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // realtodolist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.listadder);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.lists);
            this.Name = "realtodolist";
            this.Text = "realtodolist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lists;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox listadder;
        private System.Windows.Forms.Button Deletebtn;
    }
}