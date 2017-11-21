using System.Xml.Serialization;

namespace ws.Core.Model
{
    public class Voo
    {

        [XmlElement("IdVoo")]
        public int IdVoo { get; set; }

        [XmlElement("CodVoo")]
        public string CodVoo { get; set; }

        [XmlElement("FoiConfirmado")]
        public bool FoiConfirmado { get; set; }
    }
}