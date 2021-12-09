using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
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
                matchEntries = riotApi.MatchV5.GetMatchIdsByPUUID(MingweiSamuel.Camille.Enums.Region.Americas, puuidMatchInputText);
                matchListRichTextBox.Text = string.Join(Environment.NewLine, matchEntries);
                
                matchID = matchInputTextBox.Text = matchEntries.FirstOrDefault();
                var selectedMatch = riotApi.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, matchID);
                matchDetailRichTextBox.Text = selectedMatch.ToString();
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
                aPISummonerNameResultsRichTextBox.Text = $"{summoner.Name}, \n{summoner.SummonerLevel}, \n{summoner.Puuid}";

                puuidMatchInputText = puuidMatchInputTextBox1.Text = summoner.Puuid;
                matchEntries = riotApi.MatchV5.GetMatchIdsByPUUID(MingweiSamuel.Camille.Enums.Region.Americas, puuidMatchInputText);
                matchListRichTextBox.Text = string.Join(Environment.NewLine, matchEntries);

                matchID = matchInputTextBox.Text = matchEntries.FirstOrDefault();
                var selectedMatch = riotApi.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, matchID);
                matchDetailRichTextBox.Text = selectedMatch.ToString();
            }
        }

        private void aPICodeTextBox_Click(object sender, EventArgs e)
        {

        }

        private void puuidMatchInputTextBox1_TextChanged(object sender, EventArgs e)
        {
            puuidMatchInputText = puuidMatchInputTextBox1.Text;
        }

        private void puuidMatchInputButton_Click(object sender, EventArgs e)
        {
            matchEntries = riotApi.MatchV5.GetMatchIdsByPUUID(MingweiSamuel.Camille.Enums.Region.Americas, puuidMatchInputText);
            matchListRichTextBox.Text = string.Join(Environment.NewLine, matchEntries);

            matchID = matchInputTextBox.Text = matchEntries.FirstOrDefault();
            var selectedMatch = riotApi.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, matchID);
            matchDetailRichTextBox.Text = selectedMatch.ToString();
        }
        private void matchInputTextBox_TextChanged(object sender, EventArgs e)
        {
            matchID = matchInputTextBox.Text;
        }

        private void matchInputButton_Click(object sender, EventArgs e)
        {
            var selectedMatch = riotApi.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, matchID);
            matchDetailRichTextBox.Text = selectedMatch.ToString();
        }

        Summoner summoner;
        string puuidMatchInputText;
        string matchID;
        string developersCode = "RGAPI-f3b13696-06e3-4b68-8173-cff02593adcb";
        string summonerName;
        string puuidAccountInput;
        string[] matchEntries;
        RiotApi riotApi = RiotApi.NewInstance("RGAPI-f3b13696-06e3-4b68-8173-cff02593adcb");
    }
}
