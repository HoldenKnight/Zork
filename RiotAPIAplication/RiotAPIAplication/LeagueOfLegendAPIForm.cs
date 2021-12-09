using System;
using System.Linq;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.SummonerV4;

namespace RiotAPIAplication
{
    public partial class LeagueOfLegendAPIForm : Form
    {
        public LeagueOfLegendAPIForm()
        {
            InitializeComponent();
        }

        private void summonersNameInputTextBox_TextChanged(object sender, EventArgs e)
        {
            summonerName = summonersNameInputTextBox.Text;
        }

        private void summonersNameInputButton_Click(object sender, EventArgs e)
        {
            if (summonerName != null)
            {
                summoner = riotApi.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, summonerName);
                aPISummonerNameResultsRichTextBox.Text = $"{summoner.Name}, \n{summoner.SummonerLevel}, \n{summoner.Puuid}";
                
                puuidMatchInputText = puuidMatchInputTextBox1.Text = summoner.Puuid;
                puuidMatchInputSubmitted();
                matchIDSubmitted();
            }
        }

        private void puuidAccountInputTextBox_TextChanged(object sender, EventArgs e)
        {
            puuidAccountInput = puuidAccountInputTextBox.Text;
        }

        private void puuidAccountInputButton_Click(object sender, EventArgs e)
        {
            if (summonerName != null)
            {
                summoner = riotApi.SummonerV4.GetByPUUID(MingweiSamuel.Camille.Enums.Region.NA, puuidAccountInput);
                puuidAccountDetailsRichTextBox.Text = $"{summoner.Name}, \n{summoner.SummonerLevel}, \n{summoner.Puuid}";

                puuidMatchInputText = puuidMatchInputTextBox1.Text = summoner.Puuid;
                puuidMatchInputSubmitted();
                matchIDSubmitted();
            }
        }

        private void puuidMatchInputTextBox1_TextChanged(object sender, EventArgs e)
        {
            puuidMatchInputText = puuidMatchInputTextBox1.Text;
        }

        private void puuidMatchInputButton_Click(object sender, EventArgs e)
        {
            puuidMatchInputSubmitted();
            matchIDSubmitted();
        }
        private void matchInputTextBox_TextChanged(object sender, EventArgs e)
        {
            matchID = matchInputTextBox.Text;
        }

        private void matchInputButton_Click(object sender, EventArgs e)
        {
            matchIDSubmitted();
        }

        public void matchIDSubmitted()
        {
            var selectedMatch = riotApi.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, matchID);
            matchDetailRichTextBox.Text = selectedMatch.ToString();
        }

        public void puuidMatchInputSubmitted()
        {
            matchEntries = riotApi.MatchV5.GetMatchIdsByPUUID(MingweiSamuel.Camille.Enums.Region.Americas, puuidMatchInputText);
            matchListRichTextBox.Text = string.Join(Environment.NewLine, matchEntries);

            matchID = matchInputTextBox.Text = matchEntries.FirstOrDefault();
        }

        Summoner summoner;
        string puuidMatchInputText;
        string matchID;
        string summonerName;
        string puuidAccountInput;
        string[] matchEntries;
        RiotApi riotApi = RiotApi.NewInstance("RGAPI-f3b13696-06e3-4b68-8173-cff02593adcb");
    }
}
