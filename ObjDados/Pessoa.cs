using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPessoas.ObjDados
{
    public class Pratos
    {
        public Pratos() { }
        public string NomePrato { get; set; }
        public string Ingredientes { get; set; }
        public string DescricaoPrato  { get; set; }
        public string URLFoto { get; set; }
        public string TempoPreparo { get; set; }

        public Pratos (string nomeprato, string ingredientes, string descricaoprato, string urlfoto, string tempopreparo)
        {
            this.NomePrato = nomeprato;
            this.Ingredientes = ingredientes;
            this.DescricaoPrato = descricaoprato;
            this.URLFoto = urlfoto;
            this.TempoPreparo = tempopreparo;
        }
    }
}
