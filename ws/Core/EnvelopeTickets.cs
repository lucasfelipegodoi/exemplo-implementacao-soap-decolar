using System.Collections.Generic;
using System.EnterpriseServices;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using ws.Core.Model;

namespace ws.Core
{
    [XmlRoot]
    public class EnvelopeSingleTicket : IEnvelope
    {
        public EnvelopeSingleTicket() { }

        public EnvelopeSingleTicket(Model.Ticket source)
        {
            Content = source;
        }

        [XmlElement("Message")]
        public string Message { get; set; }

        public Model.Ticket Content { get; set; }

    }
}