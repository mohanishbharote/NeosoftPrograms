using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeosoftPrograms
{

    [Serializable]
    public class _3722
    {
        public string Position { get; set; }
        public string Name_Full { get; set; }
        public bool IsCaptain { get; set; }
    }

    [Serializable]
    public class _5380
    {
        public string Position { get; set; }
        public string Name_Full { get; set; }
        public bool IsCaptain { get; set; }
    }

    [Serializable]
    public class Players
    {
        [JsonProperty("5380")]
        public _5380 _5380 { get; set; }

        [JsonProperty("3722")]
        public _3722 _3722 { get; set; }
    }

    [Serializable]
    public class Root
    {
        public string Name_Full { get; set; }
        public string Name_Short { get; set; }
        public Players Players { get; set; }
    }
}
