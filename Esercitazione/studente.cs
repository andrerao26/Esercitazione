using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    class Studente : Persona
    {
        public string sezione { get; set; }
        public Studente(string nome, string cognome, int eta, string sezione) : base(nome, cognome, eta)
        {
            this.sezione = sezione;
        }
    }
}
