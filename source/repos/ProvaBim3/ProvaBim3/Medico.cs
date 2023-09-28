using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaBim3
{
    internal class Medico:Funcionario
    {
        public string crn;
        

        public override void Salario()
        {
            salario = 1000;
            porcentagem = salario + salario % 22;
            salario = porcentagem;
            Console.WriteLine(salario);
           
        }
    }
}
