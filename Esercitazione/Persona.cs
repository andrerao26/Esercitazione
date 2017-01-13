﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    class Persona
    {
        public string nome { get; set; }

        public string cognome { get; set; }

        private int _eta;
        public int eta
        {
            get
            {
                return _anni;
            }
            set
            {
                if (value <= 0) value = 1;
                _anni = value;
            }

        }

        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;

        }

        public string describe()
        {
            string output ="Nome: " + nome + "\r\n";
            output +="Cognome: " + cognome + "\r\n";
            output +="Età: " + eta + "\r\n";
            return output;
        }
}
