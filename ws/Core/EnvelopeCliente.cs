using System.Collections.Generic;
using System.EnterpriseServices;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using ws.Core.Model;

namespace ws.Core
{
    [XmlRoot]
    public class EnvelopeCliente 
    {

        public EnvelopeCliente() { }

        public EnvelopeCliente(List<Model.Cliente> clientes)
        {
            Content = clientes;
        }

        [XmlElement("Message")]
        public string Message { get; set; }

        public List<Model.Cliente> Content { get; set; }

    }
}