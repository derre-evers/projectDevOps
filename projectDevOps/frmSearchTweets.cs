using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Dapper;
using Tweetinvi;
using Tweetinvi.Models;




namespace projectDevOps
{
    public partial class frmSearchTweets : Form
    {
        string name, fromAbout;
        string APIKey = "nMeqR8nxFILmR5JcJ5plrbnVx";
        string APISecret = "NhogYz10D7HM0ZXzfXYIZON2ELVgKpN4AEkdDVWgsJxeE9b6AX";
        string APIToken = "1153297082393989120-NALCLcur9NQLYFEeHiRuy8KWGC4HM6";
        string APITokenSecret = "kXMF2e4V0bpF9G93ZjjALamGrGt5X8ehhyikeT4CNyaBA";
        TwitterClient userClient;
        List<string> searchedText;
        List<string> searchedTweeter;
        List<string> searchedDate;


        public frmSearchTweets()
        {
            InitializeComponent();

            userClient = new TwitterClient(APIKey, APISecret, APIToken, APITokenSecret);

        }

        private void rbFrom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFrom.Checked == true)
            {
                rbAbout.Checked = false;

            }
        }
        private void rbAbout_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbout.Checked == true)
            {
                rbFrom.Checked = false;

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            rbFrom.Text = "From " + txtName.Text;
            rbAbout.Text = "About " + txtName.Text;
        }

        IEnumerable<ITweet> tweets;

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlInsert.Visible = true;
            btnBack.Visible = false;
            dataTweets.Visible = false;
            lblResult.Visible = false;
            dataTweets.Rows.Clear();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory hist = new frmHistory();
            hist.Show();
        }

        private async void btnTweets_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            pnlInsert.Visible = false;

            searchedText = new List<string>();
            searchedTweeter = new List<string>();
            searchedDate = new List<string>();
            if (rbAbout.Checked == true)
            {
                tweets = await userClient.Search.SearchTweetsAsync(name);
                fromAbout = "about";

            }
            else if (rbFrom.Checked == true)
            {

                tweets = await userClient.Timelines.GetUserTimelineAsync(name);
                fromAbout = "from";
            }
            lblResult.Visible = true;
            btnBack.Visible = true;

            foreach (ITweet tweet in tweets)
                {

                    searchedText.Add(tweet.Text.ToString());
                    searchedTweeter.Add(tweet.CreatedBy.ToString());
                    searchedDate.Add(tweet.CreatedAt.ToString("dd-MM-yyyy"));
                }
            if (searchedText.Count != 0)
            {
                dataTweets.Visible = true;
                
                int i = 0;
                while (i <= searchedText.Count - 1)
                {
                    dataTweets.Rows.Add(searchedTweeter[i], searchedDate[i], searchedText[i]);
                    i++;
                }
                searchHistory history = new searchHistory(name, fromAbout);
                lblResult.Text = "Tweets " + fromAbout + " " + name;
            }

            else
            {
                lblResult.Text = "There are no tweets " + fromAbout + " " + name;

            }
            



        }
    }
}
