using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NeosoftPrograms
{
    public class WicketsNumber
    {
        public void CalculateMaxWicket()
        {
            List<LineUps> lineUp = new List<LineUps>()
        {
        new LineUps{playerId=21,PlayerName="Y.Chahal"},
        new LineUps{playerId=22,PlayerName="Bhuvneshwar Kumar"},
        new LineUps{playerId=23,PlayerName="Jasprit Bumrah"},
        new LineUps{playerId=24,PlayerName="Hardik Pandya"},
        new LineUps{playerId=25,PlayerName="Ravindra Jadeja"},
        new LineUps{playerId=26,PlayerName="Mohammad Shami"}
        };

            List<BollingStats> bolling = new List<BollingStats>() {

        new BollingStats{playerId=21,Wickets=2},
        new BollingStats{playerId=22,Wickets=1},
        new BollingStats{playerId=23,Wickets=3},
        new BollingStats{playerId=26,Wickets=1}
            };
            var result = (from a in lineUp
                          join b in bolling on a.playerId equals b.playerId
                          select new
                          {
                              a.playerId,
                              a.PlayerName,
                              b.Wickets
                          }).ToList();
            int MaxWicket = 0;
            String PlayerName = String.Empty;
            foreach (var item in result)
            {
                if (item.Wickets > MaxWicket) { 
                    MaxWicket = item.Wickets;
                    PlayerName = item.PlayerName;
                }
            }
            Console.WriteLine("The Player "+ PlayerName+ " has the max Wickets " +MaxWicket);
        }
    }
}
