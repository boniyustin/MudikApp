using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudikApp2014.Classes
{
    public class RootObjectLaluLintas
    {
        public Cctv[] cctv { get; set; }
    }

    public class Cctv
    {
        public string lokasi { get; set; }
        public string alamat { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string altitude { get; set; }
        public string id_api { get; set; }
    }
}
