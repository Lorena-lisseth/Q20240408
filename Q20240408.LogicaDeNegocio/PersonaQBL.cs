using Q20240408.AccesoADatos;
using Q20240408.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q20240408.LogicaDeNegocio
{
    public class PersonaQBL
    {
        readonly PersonaQDAL _personaQBL;

        public PersonaQBL(PersonaQDAL personaDAL)
        {
            _personaQBL = personaDAL;
        }
        public async Task<int> Crear(PersonaQ personaQ)
        {
            return await _personaQBL.Crear(personaQ);
        }
        public async Task<int> Modificar(PersonaQ personaQ)
        {
            return await _personaQBL.Modificar(personaQ);
        }
        public async Task<int> Eliminar(PersonaQ personaQ)
        {
            return await _personaQBL.Eliminar(personaQ);
        }
        public async Task<PersonaQ> ObtenerPoId(PersonaQ personaQ)
        {
            return await _personaQBL.ObtenerPoId(personaQ);
        }
        public async Task<List<PersonaQ>> ObtenerTodos()
        {
            return await _personaQBL.ObtenerTodos();
        }
        public async Task<List<PersonaQ>> Buscar(PersonaQ personaQ)
        {
            return await _personaQBL.Buscar(personaQ);
        }
    }
}

