using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace NeosoftPrograms
{
    public class SeariliseJson
    {
        public void SerializeObj()
        {
            Players playersList = new Players()
            {
                _5380 = new _5380()
                {
                    Position = "1",
                    Name_Full = "David Warner",
                    IsCaptain = true
                },
                _3722 = new _3722()
                {
                    Position = "2",
                    Name_Full = "Shikhar Dhawan",
                    IsCaptain = false
                }
            };
            Root root = new Root()
            {
                Name_Full = "Sunrisers Hyderabad",
                Name_Short = "SRH",
                Players = playersList
            };
           
            string jsonString = JsonSerializer.Serialize(root);
            Console.WriteLine(jsonString);
        }


    }
}
