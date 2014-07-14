using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudikApp2014.Classes
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class xml
    {
        public byte success{ get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable = false)]
        public xmlItem[] news { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmlItem
    {
        public int id { get; set; }

        public string nama_lokasi { get; set; }

        public string nama_kota { get; set; }

        public string arus { get; set; }

        public string cuaca { get; set; }

        public string cctv_view { get; set; }
        
        public string last_update { get; set; }
    }


}