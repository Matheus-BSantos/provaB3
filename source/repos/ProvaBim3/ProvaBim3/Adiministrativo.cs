using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaBim3
{
    internal class Adiministrativo: Funcionario
    {
        public override void Salario()
        {
            salario = 1000;
            porcentagem = salario + salario % 17;
            salario = porcentagem + 250;
            Console.WriteLine(salario);

        }
    }
}
