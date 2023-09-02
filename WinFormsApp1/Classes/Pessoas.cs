using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Pessoas
    {
        public int id;
        public string nome;
        public string cidade;
        public DateTime dataNascimento;

        private int _idade;
        public int idade
        {
            get => CalcularIdade(dataNascimento);        
            set => _idade = value;
        }        
        public static int CalcularIdade(DateTime DtNascimento)
        {
            int idade = DateTime.Now.Year - DtNascimento.Year;
            if (DateTime.Now.Year < DtNascimento.Year)
            {
                idade = idade - 1;
            }
            return idade;
        }
    }    
}
