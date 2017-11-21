using System.Xml.Serialization;

namespace ws.Core.Model
{


    public class Cliente
    {
        [XmlElement("IdCliente")]
        public int IdCliente { get; set; }

        [XmlElement("NomeCompleto")]
        public string NomeCompleto { get; set; }

        [XmlElement("Cpf")]
        public string Cpf { get; set; }
    }
}