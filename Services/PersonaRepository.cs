using AppIMC.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIMC.Services
{
    public class PersonaRepository
    {

        private SQLiteAsyncConnection _database;

        public PersonaRepository()
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "Personas.db3");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Persona>().Wait();
        }

        public Task<List<Persona>> ObtenerPersonas()
        {
            return _database.Table<Persona>().ToListAsync();
        }

        public Task<int> AgregarPersona(Persona persona)
        {
            return _database.InsertAsync(persona);
        }



    }
}
