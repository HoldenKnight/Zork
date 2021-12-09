using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.MatchV5;

namespace RiotAPITesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string developersCode = "RGAPI-f3b13696-06e3-4b68-8173-cff02593adcb";
            string summonerName;
            
            var riotApi = RiotApi.NewInstance(developersCode);
            Console.WriteLine("Enter Summoner's Name\n");
            Console.Write("> ");
            summonerName = Console.ReadLine();
            
            var summoner = riotApi.SummonerV4.GetBySummonerName(Region.NA, summonerName);
            Console.WriteLine($"\nSummoner: {summoner.Name} \nlevel: {summoner.SummonerLevel}");
            
            string[] matchEntries = riotApi.MatchV5.GetMatchIdsByPUUID(Region.Americas, summoner.Puuid);
            var matchList = matchEntries.ToList();
            Console.WriteLine("Match Ids\n");
            matchList.ForEach(Console.WriteLine);
            Console.WriteLine($"\nEnter Match Id");
            Console.Write("> ");
            string matchID = Console.ReadLine();
            if (matchID != null)
            {
                Console.WriteLine(matchID);
                var selectedMatch = riotApi.MatchV5.GetMatch(Region.Americas, matchID);
                Console.WriteLine(selectedMatch);
            }
        }
    }
}
