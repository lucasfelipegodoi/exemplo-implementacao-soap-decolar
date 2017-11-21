using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ws.Core.Service
{
    public class Voo
    {


        public Model.Voo RetornaPorId(int id)
        {
            return this._retornarVoos().First(a => a.IdVoo == id);
        }

        public List<Model.Voo> ListarVoo(bool? foiConfirmado)
        {
            var dados = this._retornarVoos();

            if (foiConfirmado != null)
            {
                dados = dados.Where(a => a.FoiConfirmado = Convert.ToBoolean(foiConfirmado)).ToList();
            }

            return dados;
        }


        private List<Model.Voo> _retornarVoos()
        {
            return new List<Model.Voo>{
                new Model.Voo
                {
                    IdVoo = 1,
                    CodVoo = "001AA",
                    FoiConfirmado = true
                },
                new Model.Voo
                {
                    IdVoo = 2,
                    CodVoo = "002BB",
                    FoiConfirmado = true
                },
                new Model.Voo
                {
                    IdVoo = 3,
                    CodVoo = "003CC",
                    FoiConfirmado = true
                },
                new Model.Voo
                {
                    IdVoo = 4,
                    CodVoo = "004DD",
                    FoiConfirmado = true
                },
                new Model.Voo
                {
                    IdVoo = 5,
                    CodVoo = "005EE",
                    FoiConfirmado = true
                },
                new Model.Voo
                {
                    IdVoo = 6,
                    CodVoo = "006FF",
                    FoiConfirmado = false
                },
                new Model.Voo
                {
                    IdVoo = 7,
                    CodVoo = "007GG",
                    FoiConfirmado = true
                },
                new Model.Voo
                {
                    IdVoo = 8,
                    CodVoo = "008HI",
                    FoiConfirmado = false
                },
                new Model.Voo
                {
                    IdVoo = 9,
                    CodVoo = "009AS",
                    FoiConfirmado = true
                },
            };

        }

    }
}