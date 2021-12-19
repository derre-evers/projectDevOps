using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;


namespace projectDevOps
{
    public partial class frmHistory : Form
    {
        string APIKey = "nMeqR8nxFILmR5JcJ5plrbnVx";
        string APISecret = "NhogYz10D7HM0ZXzfXYIZON2ELVgKpN4AEkdDVWgsJxeE9b6AX";
        string APIToken = "1153297082393989120-NALCLcur9NQLYFEeHiRuy8KWGC4HM6";
        string APITokenSecret = "kXMF2e4V0bpF9G93ZjjALamGrGt5X8ehhyikeT4CNyaBA";
        TwitterClient userClient;
        List<string> searchedText;
        List<string> searchedTweeter;
        List<string> searchedDate;
        IEnumerable<ITweet> tweets;
        public frmHistory()
        {
            InitializeComponent();
            userClient = new TwitterClient(APIKey, APISecret, APIToken, APITokenSecret);

        }

        private void frmHistory_Load(object sender, EventArgs e)
        {

            var results = searchHistory.get();
            foreach (string result in results)
            {
                lbHistory.Items.Add(result);
            }
        }


        private async void btnSearchHist_Click(object sender, EventArgs e)
        {
            string history = (string)lbHistory.SelectedItem;
            string[] historySplit = history.Split('-');
            string name = historySplit[0].Trim(' ');
            string fromAbout = historySplit[1].Trim(' ');
            lbHistory.Visible = false;
            btnSearchHist.Visible = false;
            btnBack.Visible = true;
            dataTweets.Visible = true;

            searchedText = new List<string>();
            searchedTweeter = new List<string>();
            searchedDate = new List<string>();
            if (fromAbout == "about")
            {
                tweets = await userClient.Search.SearchTweetsAsync(name);

            }
            else if (fromAbout == "from")
            {
                tweets = await userClient.Timelines.GetUserTimelineAsync(name);
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

                lblResult.Text = "Tweets " + fromAbout + " " + name;
            }

            else
            {
                lblResult.Text = "There are no tweets " + fromAbout + " " + name;

            }
        }
            private void btnBack_Click(object sender, EventArgs e)
        {
            dataTweets.Visible = false;
            btnBack.Visible = false;
            lblResult.Visible = false;
            lbHistory.Visible = true;
            btnSearchHist.Visible = true;
            dataTweets.Rows.Clear();
        }

        
    }
}
