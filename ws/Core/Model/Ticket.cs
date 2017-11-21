using System;
using System.Xml.Serialization;

namespace ws.Core.Model
{
    public class Ticket
    {
        [XmlElement("IdTicket")]
        public int IdTicket { get; set; }

        [XmlElement("DataHoraCompra")]
        public DateTime DataHoraCompra { get; set; }

        [XmlElement("FoiPago")]
        public bool FoiPago { get; set; }

        [XmlElement("Cliente")]
        public Cliente Cliente { get; set; }

        [XmlElement("Voo")]
        public Voo Voo { get; set; }
    }
}