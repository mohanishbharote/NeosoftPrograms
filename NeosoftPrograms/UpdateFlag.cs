using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeosoftPrograms
{
    public class UpdateFlag
    {
        public void UpdatePlayerListFlag()
        {
            List<PlayerModel> battingModelsList = new List<PlayerModel>()
        {
            new PlayerModel
            {
                PlayerName = "Virat Kholi",
                IsRetired= 1
            },
            new PlayerModel
            {
                PlayerName = "M.S.Dhoni",
                IsRetired= 1
            },
            new PlayerModel
            {
                PlayerName = "Hardik Pandya",
                IsRetired= 1
            },
            new PlayerModel
            {
                PlayerName = "Rohit Sharma",
                IsRetired= 1
                },
            new PlayerModel
            {
                PlayerName = "Sachin Tendulkar",
                IsRetired= 0
            },
            new PlayerModel
            {
                PlayerName = "Rahul Dravid",
                IsRetired= 0
            },
            new PlayerModel
            {
                PlayerName = "Saurav Ganguly",
                IsRetired= 0
            },
            new PlayerModel
            {
                PlayerName = "V.V.S.lakshuman",
                IsRetired= 0
            }
        };
            var result = battingModelsList.Select(a => { 
                if (a.IsRetired == 0) a.IsRetired = 1; 
                else a.IsRetired = 0; 
                return a; 
            });
            //used foreach to print the result
            foreach (var item in result)
            {
                Console.WriteLine(item.PlayerName + " " + item.IsRetired);
            }
            
        }
    }
}
