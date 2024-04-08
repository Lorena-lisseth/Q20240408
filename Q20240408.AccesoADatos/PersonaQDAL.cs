using Microsoft.EntityFrameworkCore;
using Q20240408.EntidadesDeNegocio;
        

namespace Q20240408.AccesoADatos
{
   public class PersonaQDAL
    {
        readonly AppDbContext _appDbContext;
        public PersonaQDAL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> Crear(PersonaQ personaq)
        {
            _appDbContext.Add(personaq);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaQ personaq)
        {
            var PersonaData = await _appDbContext.Persona.FirstOrDefaultAsync(s => s.Id == personaq.Id);
            if (PersonaData != null)
            {
                PersonaData.NombreQ = personaq.NombreQ;
                PersonaData.ApellidoQ = personaq.ApellidoQ;
                PersonaData.FechaNacimientoQ = personaq.FechaNacimientoQ;
                PersonaData.SueldoQ = personaq.SueldoQ;
                PersonaData.StatusQ = personaq.StatusQ;
                _appDbContext.Update(PersonaData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaQ personaM)
        {
            var PersonaData = await _appDbContext.Persona.FirstOrDefaultAsync(s => s.Id == personaM.Id);
            if (PersonaData != null)
                _appDbContext.Remove(PersonaData);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<PersonaQ> ObtenerPoId(PersonaQ personaM)
        {
            var PersonaData = await _appDbContext.Persona.FirstOrDefaultAsync(s => s.Id == personaM.Id);
            if (PersonaData != null)
                return PersonaData;
            else
                return new PersonaQ();
        }
        public async Task<List<PersonaQ>> ObtenerTodos()
        {
            return await _appDbContext.Persona.ToListAsync();
        }
        public async Task<List<PersonaQ>> Buscar(PersonaQ personaM)
        {
            var query = _appDbContext.Persona.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personaM.NombreQ))
            {
                query = query.Where(s => s.NombreQ.Contains(personaM.NombreQ));
            }
            if (!string.IsNullOrWhiteSpace(personaM.ApellidoQ))
            {
                query = query.Where(s => s.NombreQ.Contains(personaM.ApellidoQ));
            }
            return await query.ToListAsync();
        }
    }
}

