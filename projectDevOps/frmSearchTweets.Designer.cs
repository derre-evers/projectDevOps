
namespace projectDevOps
{
    partial class frmSearchTweets
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbFrom = new System.Windows.Forms.RadioButton();
            this.rbAbout = new System.Windows.Forms.RadioButton();
            this.btnTweets = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.pnlInsert = new System.Windows.Forms.Panel();
            this.dataTweets = new System.Windows.Forms.DataGridView();
            this.Tweeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofTweet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tweet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTweets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Tweets from/about someone";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(33, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insert name";
            // 
            // rbFrom
            // 
            this.rbFrom.AutoSize = true;
            this.rbFrom.Checked = true;
            this.rbFrom.Location = new System.Drawing.Point(386, 58);
            this.rbFrom.Name = "rbFrom";
            this.rbFrom.Size = new System.Drawing.Size(123, 21);
            this.rbFrom.TabIndex = 3;
            this.rbFrom.TabStop = true;
            this.rbFrom.Text = "From someone";
            this.rbFrom.UseVisualStyleBackColor = true;
            this.rbFrom.CheckedChanged += new System.EventHandler(this.rbFrom_CheckedChanged);
            // 
            // rbAbout
            // 
            this.rbAbout.AutoSize = true;
            this.rbAbout.Location = new System.Drawing.Point(386, 85);
            this.rbAbout.Name = "rbAbout";
            this.rbAbout.Size = new System.Drawing.Size(128, 21);
            this.rbAbout.TabIndex = 4;
            this.rbAbout.Text = "About someone";
            this.rbAbout.UseVisualStyleBackColor = true;
            // 
            // btnTweets
            // 
            this.btnTweets.Location = new System.Drawing.Point(36, 159);
            this.btnTweets.Name = "btnTweets";
            this.btnTweets.Size = new System.Drawing.Size(137, 52);
            this.btnTweets.TabIndex = 7;
            this.btnTweets.Text = "Search Tweets";
            this.btnTweets.UseVisualStyleBackColor = true;
            this.btnTweets.Click += new System.EventHandler(this.btnTweets_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(239, 159);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(137, 52);
            this.btnHistory.TabIndex = 8;
            this.btnHistory.Text = "Search in history";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // pnlInsert
            // 
            this.pnlInsert.Controls.Add(this.btnHistory);
            this.pnlInsert.Controls.Add(this.label1);
            this.pnlInsert.Controls.Add(this.btnTweets);
            this.pnlInsert.Controls.Add(this.rbAbout);
            this.pnlInsert.Controls.Add(this.rbFrom);
            this.pnlInsert.Controls.Add(this.label2);
            this.pnlInsert.Controls.Add(this.txtName);
            this.pnlInsert.Location = new System.Drawing.Point(138, 127);
            this.pnlInsert.Name = "pnlInsert";
            this.pnlInsert.Size = new System.Drawing.Size(732, 415);
            this.pnlInsert.TabIndex = 9;
            // 
            // dataTweets
            // 
            this.dataTweets.AllowUserToAddRows = false;
            this.dataTweets.AllowUserToDeleteRows = false;
            this.dataTweets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTweets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tweeter,
            this.DateofTweet,
            this.Tweet});
            this.dataTweets.Location = new System.Drawing.Point(26, 81);
            this.dataTweets.Name = "dataTweets";
            this.dataTweets.ReadOnly = true;
            this.dataTweets.RowHeadersWidth = 51;
            this.dataTweets.RowTemplate.Height = 24;
            this.dataTweets.Size = new System.Drawing.Size(1105, 519);
            this.dataTweets.TabIndex = 9;
            this.dataTweets.Visible = false;
            // 
            // Tweeter
            // 
            this.Tweeter.HeaderText = "Tweeter";
            this.Tweeter.MinimumWidth = 6;
            this.Tweeter.Name = "Tweeter";
            this.Tweeter.ReadOnly = true;
            this.Tweeter.Width = 125;
            // 
            // DateofTweet
            // 
            this.DateofTweet.HeaderText = "Date of Tweet";
            this.DateofTweet.MinimumWidth = 6;
            this.DateofTweet.Name = "DateofTweet";
            this.DateofTweet.ReadOnly = true;
            this.DateofTweet.Width = 125;
            // 
            // Tweet
            // 
            this.Tweet.HeaderText = "Tweet";
            this.Tweet.MinimumWidth = 6;
            this.Tweet.Name = "Tweet";
            this.Tweet.ReadOnly = true;
            this.Tweet.Width = 125;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(174, 775);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 52);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(132, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 36);
            this.lblResult.TabIndex = 11;
            // 
            // frmSearchTweets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 889);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlInsert);
            this.Controls.Add(this.dataTweets);
            this.Name = "frmSearchTweets";
            this.Text = "Search Tweets";
            this.pnlInsert.ResumeLayout(false);
            this.pnlInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTweets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbFrom;
        private System.Windows.Forms.RadioButton rbAbout;
        private System.Windows.Forms.Button btnTweets;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel pnlInsert;
        private System.Windows.Forms.DataGridView dataTweets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tweeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofTweet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tweet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblResult;
    }
}

