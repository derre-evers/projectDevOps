
namespace projectDevOps
{
    partial class frmHistory
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
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.btnSearchHist = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataTweets = new System.Windows.Forms.DataGridView();
            this.Tweeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofTweet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tweet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTweets)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 16;
            this.lbHistory.Location = new System.Drawing.Point(12, 91);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(398, 292);
            this.lbHistory.TabIndex = 0;
            // 
            // btnSearchHist
            // 
            this.btnSearchHist.Location = new System.Drawing.Point(488, 91);
            this.btnSearchHist.Name = "btnSearchHist";
            this.btnSearchHist.Size = new System.Drawing.Size(159, 72);
            this.btnSearchHist.TabIndex = 1;
            this.btnSearchHist.Text = "Search with selected values";
            this.btnSearchHist.UseVisualStyleBackColor = true;
            this.btnSearchHist.Click += new System.EventHandler(this.btnSearchHist_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(110, 743);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 52);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.dataTweets.Location = new System.Drawing.Point(110, 178);
            this.dataTweets.Name = "dataTweets";
            this.dataTweets.ReadOnly = true;
            this.dataTweets.RowHeadersWidth = 51;
            this.dataTweets.RowTemplate.Height = 24;
            this.dataTweets.Size = new System.Drawing.Size(1105, 519);
            this.dataTweets.TabIndex = 12;
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
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(161, 29);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 36);
            this.lblResult.TabIndex = 13;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 816);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dataTweets);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchHist);
            this.Controls.Add(this.lbHistory);
            this.Name = "frmHistory";
            this.Text = "Search in History";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTweets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button btnSearchHist;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataTweets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tweeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofTweet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tweet;
        private System.Windows.Forms.Label lblResult;
    }
}