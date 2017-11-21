using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ws.Core.Service
{
    public class Cliente
    {

        public Model.Cliente RetonarPorId(int id)
        {
            return this.ListarClientes().First(a => a.IdCliente == id); ;
        }

        public List<Model.Cliente> ListarClientes()
        {
            return new List<Model.Cliente>{
                new Model.Cliente
                {
                    IdCliente = 1,
                    NomeCompleto = "João Aparecido",
                    Cpf = "12345678910"
                },
                new Model.Cliente
                {
                    IdCliente = 2,
                    NomeCompleto = "Maria Aparecida",
                    Cpf = "87632412309"
                }
            };
        } 

    }
}