using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace NeosoftPrograms
{
    public class BattingMomentum
    {
       
        public void CalculateBattingMomentum()
        {
            List<BattingModel> battingModels = new List<BattingModel>()
        {
            new BattingModel
            {
                Batsman = "Virat Kholi",
                RunsScored= 50,
                StrikeRate = 78.30
            },
           new BattingModel
           {
             Batsman = "M.S.Dhoni",
                RunsScored= 61,
                StrikeRate = 58.90
           },

           new BattingModel
           {
                Batsman = "Rohit Sharma",
                RunsScored= 13,
                StrikeRate = 124.0
           }
        };
            double maxbat = 0;
            string name = string.Empty;
            foreach (var item in battingModels)
            {
                
                var bat = item.StrikeRate * item.RunsScored;
                if (maxbat < bat)
                {
                    maxbat = bat;
                    name = item.Batsman;
                }
            }
            Console.WriteLine("The batsman "+ name + " has the best score "+maxbat);

        }
    }
}
