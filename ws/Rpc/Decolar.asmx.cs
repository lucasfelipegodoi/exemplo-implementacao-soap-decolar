using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Xml.Serialization;
using ws.Core;

namespace ws.Rpc
{
    /// <summary>
    /// Summary description for Voos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Decolar : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        public EnvelopeCliente ObterTodosClientes()
        {
            var clienteService = new Core.Service.Cliente();

            var dados = clienteService.ListarClientes();

            var saida = new EnvelopeCliente(dados);
            saida.Message = "Sucesso";

            return saida;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        public EnvelopeVoos ObterTodosVoos(bool? foiConfirmado)
        {
            var clienteService = new Core.Service.Voo();

            var dados = clienteService.ListarVoo(foiConfirmado);

            var saida = new EnvelopeVoos(dados);

            saida.Message = "Sucesso";

            return saida;
        }

        
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        public EnvelopeSingleTicket ComprarTicket(int idCliente, int idVoo, bool foiPago)
        {
            var ticketService = new Core.Service.Ticket();

            var dados = ticketService.Insert(idCliente, idVoo, foiPago);

            var saida = new EnvelopeSingleTicket(dados);

            saida.Message = "Sucesso";

            return saida;
        }



    }
}
