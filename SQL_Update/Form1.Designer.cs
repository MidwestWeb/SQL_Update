namespace SQL_Update
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
            this.Job_Number_Text = new System.Windows.Forms.Label();
            this.Job_Divider_Text = new System.Windows.Forms.Label();
            this.Job_Number_Entry = new System.Windows.Forms.RichTextBox();
            this.JobPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Sub_Job_Num_Search = new System.Windows.Forms.RichTextBox();
            this.AccountPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Account_Number_Text = new System.Windows.Forms.Label();
            this.Account_Entry = new System.Windows.Forms.RichTextBox();
            this.FieldPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Order_Number_Text = new System.Windows.Forms.Label();
            this.Order_Number_Search = new System.Windows.Forms.RichTextBox();
            this.SearchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Entry_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Comment_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Comments = new System.Windows.Forms.TextBox();
            this.Comment_Label = new System.Windows.Forms.Label();
            this.Date_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Date_Finished = new System.Windows.Forms.DateTimePicker();
            this.Date_Finished_Label = new System.Windows.Forms.Label();
            this.User_Entry_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.JobPanel.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            this.FieldPanel.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.Entry_Panel.SuspendLayout();
            this.Comment_Panel.SuspendLayout();
            this.Date_Panel.SuspendLayout();
            this.User_Entry_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Job_Number_Text
            // 
            this.Job_Number_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Job_Number_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Job_Number_Text.Location = new System.Drawing.Point(3, 4);
            this.Job_Number_Text.Name = "Job_Number_Text";
            this.Job_Number_Text.Size = new System.Drawing.Size(120, 18);
            this.Job_Number_Text.TabIndex = 0;
            this.Job_Number_Text.Text = "Job Number";
            this.Job_Number_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Job_Divider_Text
            // 
            this.Job_Divider_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Job_Divider_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Job_Divider_Text.Location = new System.Drawing.Point(225, 4);
            this.Job_Divider_Text.Name = "Job_Divider_Text";
            this.Job_Divider_Text.Size = new System.Drawing.Size(12, 18);
            this.Job_Divider_Text.TabIndex = 2;
            this.Job_Divider_Text.Text = "/";
            this.Job_Divider_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Job_Divider_Text.Click += new System.EventHandler(this.label1_Click);
            // 
            // Job_Number_Entry
            // 
            this.Job_Number_Entry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Job_Number_Entry.Location = new System.Drawing.Point(129, 3);
            this.Job_Number_Entry.MaxLength = 6;
            this.Job_Number_Entry.Multiline = false;
            this.Job_Number_Entry.Name = "Job_Number_Entry";
            this.Job_Number_Entry.Size = new System.Drawing.Size(90, 20);
            this.Job_Number_Entry.TabIndex = 1;
            this.Job_Number_Entry.Text = "";
            // 
            // JobPanel
            // 
            this.JobPanel.AutoSize = true;
            this.JobPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.JobPanel.Controls.Add(this.Job_Number_Text);
            this.JobPanel.Controls.Add(this.Job_Number_Entry);
            this.JobPanel.Controls.Add(this.Job_Divider_Text);
            this.JobPanel.Controls.Add(this.Sub_Job_Num_Search);
            this.JobPanel.Location = new System.Drawing.Point(3, 3);
            this.JobPanel.Name = "JobPanel";
            this.JobPanel.Size = new System.Drawing.Size(336, 26);
            this.JobPanel.TabIndex = 1;
            // 
            // Sub_Job_Num_Search
            // 
            this.Sub_Job_Num_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Sub_Job_Num_Search.Location = new System.Drawing.Point(243, 3);
            this.Sub_Job_Num_Search.MaxLength = 6;
            this.Sub_Job_Num_Search.Multiline = false;
            this.Sub_Job_Num_Search.Name = "Sub_Job_Num_Search";
            this.Sub_Job_Num_Search.Size = new System.Drawing.Size(90, 20);
            this.Sub_Job_Num_Search.TabIndex = 3;
            this.Sub_Job_Num_Search.Text = "";
            // 
            // AccountPanel
            // 
            this.AccountPanel.AutoSize = true;
            this.AccountPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccountPanel.Controls.Add(this.Account_Number_Text);
            this.AccountPanel.Controls.Add(this.Account_Entry);
            this.AccountPanel.Location = new System.Drawing.Point(3, 35);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(222, 26);
            this.AccountPanel.TabIndex = 2;
            // 
            // Account_Number_Text
            // 
            this.Account_Number_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Account_Number_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Account_Number_Text.Location = new System.Drawing.Point(3, 4);
            this.Account_Number_Text.Name = "Account_Number_Text";
            this.Account_Number_Text.Size = new System.Drawing.Size(120, 18);
            this.Account_Number_Text.TabIndex = 1;
            this.Account_Number_Text.Text = "Account Number";
            this.Account_Number_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Account_Number_Text.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Account_Entry
            // 
            this.Account_Entry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Account_Entry.Location = new System.Drawing.Point(129, 3);
            this.Account_Entry.MaxLength = 6;
            this.Account_Entry.Multiline = false;
            this.Account_Entry.Name = "Account_Entry";
            this.Account_Entry.Size = new System.Drawing.Size(90, 20);
            this.Account_Entry.TabIndex = 2;
            this.Account_Entry.Text = "";
            // 
            // FieldPanel
            // 
            this.FieldPanel.AutoSize = true;
            this.FieldPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FieldPanel.Controls.Add(this.JobPanel);
            this.FieldPanel.Controls.Add(this.AccountPanel);
            this.FieldPanel.Controls.Add(this.OrderPanel);
            this.FieldPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FieldPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FieldPanel.Location = new System.Drawing.Point(3, 3);
            this.FieldPanel.Name = "FieldPanel";
            this.FieldPanel.Size = new System.Drawing.Size(342, 96);
            this.FieldPanel.TabIndex = 2;
            // 
            // OrderPanel
            // 
            this.OrderPanel.AutoSize = true;
            this.OrderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OrderPanel.Controls.Add(this.Order_Number_Text);
            this.OrderPanel.Controls.Add(this.Order_Number_Search);
            this.OrderPanel.Location = new System.Drawing.Point(3, 67);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(222, 26);
            this.OrderPanel.TabIndex = 3;
            // 
            // Order_Number_Text
            // 
            this.Order_Number_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Order_Number_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Order_Number_Text.Location = new System.Drawing.Point(3, 4);
            this.Order_Number_Text.Name = "Order_Number_Text";
            this.Order_Number_Text.Size = new System.Drawing.Size(120, 18);
            this.Order_Number_Text.TabIndex = 1;
            this.Order_Number_Text.Text = "Order Number";
            this.Order_Number_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Order_Number_Text.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Order_Number_Search
            // 
            this.Order_Number_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Order_Number_Search.Location = new System.Drawing.Point(129, 3);
            this.Order_Number_Search.MaxLength = 6;
            this.Order_Number_Search.Multiline = false;
            this.Order_Number_Search.Name = "Order_Number_Search";
            this.Order_Number_Search.Size = new System.Drawing.Size(90, 20);
            this.Order_Number_Search.TabIndex = 2;
            this.Order_Number_Search.Text = "";
            // 
            // SearchPanel
            // 
            this.SearchPanel.AutoSize = true;
            this.SearchPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchPanel.Controls.Add(this.FieldPanel);
            this.SearchPanel.Controls.Add(this.Search_Button);
            this.SearchPanel.Location = new System.Drawing.Point(12, 12);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(419, 102);
            this.SearchPanel.TabIndex = 1;
            // 
            // Search_Button
            // 
            this.Search_Button.AutoSize = true;
            this.Search_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Search_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Search_Button.Location = new System.Drawing.Point(351, 71);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(65, 28);
            this.Search_Button.TabIndex = 3;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Update.Location = new System.Drawing.Point(351, 107);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(65, 28);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Entry_Panel
            // 
            this.Entry_Panel.AutoSize = true;
            this.Entry_Panel.Controls.Add(this.Date_Panel);
            this.Entry_Panel.Controls.Add(this.Comment_Panel);
            this.Entry_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Entry_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Entry_Panel.Location = new System.Drawing.Point(3, 3);
            this.Entry_Panel.MinimumSize = new System.Drawing.Size(342, 132);
            this.Entry_Panel.Name = "Entry_Panel";
            this.Entry_Panel.Size = new System.Drawing.Size(342, 132);
            this.Entry_Panel.TabIndex = 5;
            // 
            // Comment_Panel
            // 
            this.Comment_Panel.AutoSize = true;
            this.Comment_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Comment_Panel.Controls.Add(this.Comment_Label);
            this.Comment_Panel.Controls.Add(this.Comments);
            this.Comment_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Comment_Panel.Location = new System.Drawing.Point(3, 43);
            this.Comment_Panel.Name = "Comment_Panel";
            this.Comment_Panel.Padding = new System.Windows.Forms.Padding(5);
            this.Comment_Panel.Size = new System.Drawing.Size(320, 86);
            this.Comment_Panel.TabIndex = 7;
            // 
            // Comments
            // 
            this.Comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Comments.Location = new System.Drawing.Point(88, 8);
            this.Comments.MaxLength = 350;
            this.Comments.Multiline = true;
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(224, 70);
            this.Comments.TabIndex = 2;
            // 
            // Comment_Label
            // 
            this.Comment_Label.AutoSize = true;
            this.Comment_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Comment_Label.Location = new System.Drawing.Point(8, 5);
            this.Comment_Label.Name = "Comment_Label";
            this.Comment_Label.Size = new System.Drawing.Size(74, 18);
            this.Comment_Label.TabIndex = 1;
            this.Comment_Label.Text = "Comment";
            // 
            // Date_Panel
            // 
            this.Date_Panel.AutoSize = true;
            this.Date_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Date_Panel.Controls.Add(this.Date_Finished_Label);
            this.Date_Panel.Controls.Add(this.Date_Finished);
            this.Date_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Date_Panel.Location = new System.Drawing.Point(3, 3);
            this.Date_Panel.Name = "Date_Panel";
            this.Date_Panel.Padding = new System.Windows.Forms.Padding(5);
            this.Date_Panel.Size = new System.Drawing.Size(320, 34);
            this.Date_Panel.TabIndex = 6;
            // 
            // Date_Finished
            // 
            this.Date_Finished.Dock = System.Windows.Forms.DockStyle.Left;
            this.Date_Finished.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Date_Finished.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Date_Finished.Location = new System.Drawing.Point(112, 8);
            this.Date_Finished.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.Date_Finished.Name = "Date_Finished";
            this.Date_Finished.Size = new System.Drawing.Size(200, 24);
            this.Date_Finished.TabIndex = 2;
            // 
            // Date_Finished_Label
            // 
            this.Date_Finished_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Date_Finished_Label.Location = new System.Drawing.Point(8, 5);
            this.Date_Finished_Label.Name = "Date_Finished_Label";
            this.Date_Finished_Label.Size = new System.Drawing.Size(98, 24);
            this.Date_Finished_Label.TabIndex = 1;
            this.Date_Finished_Label.Text = "Date Finished";
            this.Date_Finished_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_Entry_Panel
            // 
            this.User_Entry_Panel.AutoSize = true;
            this.User_Entry_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.User_Entry_Panel.Controls.Add(this.Entry_Panel);
            this.User_Entry_Panel.Controls.Add(this.Update);
            this.User_Entry_Panel.Location = new System.Drawing.Point(12, 120);
            this.User_Entry_Panel.MinimumSize = new System.Drawing.Size(419, 138);
            this.User_Entry_Panel.Name = "User_Entry_Panel";
            this.User_Entry_Panel.Size = new System.Drawing.Size(419, 138);
            this.User_Entry_Panel.TabIndex = 4;
            this.User_Entry_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.User_Entry_Panel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(446, 272);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.User_Entry_Panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Vixen Table Update";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.JobPanel.ResumeLayout(false);
            this.AccountPanel.ResumeLayout(false);
            this.FieldPanel.ResumeLayout(false);
            this.FieldPanel.PerformLayout();
            this.OrderPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.Entry_Panel.ResumeLayout(false);
            this.Entry_Panel.PerformLayout();
            this.Comment_Panel.ResumeLayout(false);
            this.Comment_Panel.PerformLayout();
            this.Date_Panel.ResumeLayout(false);
            this.User_Entry_Panel.ResumeLayout(false);
            this.User_Entry_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Job_Number_Text;
        private System.Windows.Forms.Label Job_Divider_Text;
        private System.Windows.Forms.RichTextBox Job_Number_Entry;
        private System.Windows.Forms.FlowLayoutPanel JobPanel;
        private System.Windows.Forms.RichTextBox Sub_Job_Num_Search;
        private System.Windows.Forms.FlowLayoutPanel AccountPanel;
        private System.Windows.Forms.Label Account_Number_Text;
        private System.Windows.Forms.RichTextBox Account_Entry;
        private System.Windows.Forms.FlowLayoutPanel FieldPanel;
        private System.Windows.Forms.FlowLayoutPanel OrderPanel;
        private System.Windows.Forms.Label Order_Number_Text;
        private System.Windows.Forms.RichTextBox Order_Number_Search;
        private System.Windows.Forms.FlowLayoutPanel SearchPanel;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.FlowLayoutPanel Entry_Panel;
        private System.Windows.Forms.FlowLayoutPanel Date_Panel;
        private System.Windows.Forms.Label Date_Finished_Label;
        private System.Windows.Forms.DateTimePicker Date_Finished;
        private System.Windows.Forms.FlowLayoutPanel Comment_Panel;
        private System.Windows.Forms.Label Comment_Label;
        private System.Windows.Forms.TextBox Comments;
        private System.Windows.Forms.FlowLayoutPanel User_Entry_Panel;
    }
}

