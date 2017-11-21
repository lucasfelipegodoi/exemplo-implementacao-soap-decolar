using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ws.Core.Service
{
    public class Ticket
    {

        public Model.Ticket Insert(int idCliente, int idVoo, bool foiPago)
        {
            
            var clienteService = new Cliente();
            var vooServicce = new Voo();

            var clienteSelecionado = clienteService.RetonarPorId(idCliente);
            var vooSelecionado = vooServicce.RetornaPorId(idVoo);

            var modeloTicket = new Model.Ticket();

            modeloTicket.Voo = vooSelecionado;
            modeloTicket.Cliente = clienteSelecionado;
            modeloTicket.DataHoraCompra = DateTime.Now;
            modeloTicket.FoiPago = foiPago;
            modeloTicket.IdTicket = 1;

            return modeloTicket;
        }

    }
}