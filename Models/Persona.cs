using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIMC.Models
{

    
    public class Persona
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double IMC { get; set; }
    }
}
