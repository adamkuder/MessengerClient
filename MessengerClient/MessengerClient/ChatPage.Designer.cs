namespace MessengerClient
{
    partial class ChatPage
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
            this.ChatListBox = new System.Windows.Forms.ListBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteContactButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatListBox
            // 
            this.ChatListBox.FormattingEnabled = true;
            this.ChatListBox.Location = new System.Drawing.Point(199, 12);
            this.ChatListBox.Name = "ChatListBox";
            this.ChatListBox.Size = new System.Drawing.Size(573, 407);
            this.ChatListBox.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(697, 425);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 425);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 20);
            this.textBox1.TabIndex = 2;
            // 
            // AddContactButton
            // 
            this.AddContactButton.Location = new System.Drawing.Point(107, 12);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(86, 23);
            this.AddContactButton.TabIndex = 3;
            this.AddContactButton.Text = "AddContact";
            this.AddContactButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(181, 349);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contacts";
            // 
            // DeleteContactButton
            // 
            this.DeleteContactButton.Location = new System.Drawing.Point(12, 12);
            this.DeleteContactButton.Name = "DeleteContactButton";
            this.DeleteContactButton.Size = new System.Drawing.Size(86, 23);
            this.DeleteContactButton.TabIndex = 6;
            this.DeleteContactButton.Text = "DeleteContact";
            this.DeleteContactButton.UseVisualStyleBackColor = true;
            // 
            // ChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.DeleteContactButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.AddContactButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ChatListBox);
            this.Name = "ChatPage";
            this.Text = "ChatPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ChatListBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteContactButton;
    }
}