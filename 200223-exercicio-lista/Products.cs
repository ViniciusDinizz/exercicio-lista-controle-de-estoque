using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200223_exercicio_lista
{
    internal class Products
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Quant { get; set; }

        public Products(string nome, int id, int quant)
        {
            Nome = nome;
            ID = id;
            Quant = quant;
        }

        public void EditNome (string nome)
        {
            this.Nome = nome.ToUpper();
        }

        public void EditID(int id)
        {
            this.ID = id;
        }

        public void EditQuant(int quant)
        {
            this.Quant = quant;
        }
        public override string ToString()
        {
            return $"\nDados do produto:\nNome: {Nome} | ID: {ID} | Total: {Quant}\n";
        }
    }
}
