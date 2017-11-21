using System.Collections.Generic;
using System.EnterpriseServices;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using ws.Core.Model;

namespace ws.Core
{
    [XmlRoot]
    public class EnvelopeVoos
    {
        public EnvelopeVoos() { }

        public EnvelopeVoos(List<Model.Voo> voos)
        {
            Content = voos;
        }

        [XmlElement("Message")]
        public string Message { get; set; }

        public List<Model.Voo> Content { get; set; }

    }
}