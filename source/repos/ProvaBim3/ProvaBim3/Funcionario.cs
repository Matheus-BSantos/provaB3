using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaBim3
{
    internal class Funcionario
    {
        //nome, CPF, matrícula, data de nascimento, sexo, salário.
        //crn string
        public string nome { get; set; }
        public string cpf { get; set;}
        public DateTime dataNascimento { get; set; }
        public string matricula { get; set; }
        public string sexo { get; set; }
        public double salario { get; set; }

        public double porcentagem;//calculo dos salarios

        public virtual void Salario()
        {
           
          
        }
    }
}
