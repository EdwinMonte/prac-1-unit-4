using prac_1_unit_4.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_1_unit_4.Datos
{
    public class Usuario
    {
        List<UsuarioModel>lista = new List<UsuarioModel>();
        public void Guardar(UsuarioModel moddelo)
        {
            lista.Add(moddelo);
        }
        public List<UsuarioModel>Consultar()
        {
            return lista;
        }

    }
}
