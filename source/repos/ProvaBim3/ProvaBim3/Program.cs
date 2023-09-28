using System;
using ProvaBim3;


Console.WriteLine("Digite 1 para cadastrar um Medico, 2 para cadastrar um Administrador ou 3 para parar o programa:");
int escolhaFuncionario = Convert.ToInt32(Console.ReadLine());

if(escolhaFuncionario == 1)
{
    Funcionario f = new Funcionario();

    Medico m = new Medico();
    Console.Write("Nome: ");
    m.nome = Console.ReadLine();
    Console.Write("CPF: ");
    m.cpf = Console.ReadLine();
    Console.Write("Data de nascimento: ");
    m.dataNascimento = DateTime.Parse(Console.ReadLine());
    Console.Write("Sexo: ");
    m.sexo = Console.ReadLine();
    Console.Write($"o salario  de {m.nome} é: ");
    m.Salario();
}

if(escolhaFuncionario == 2)
{
    Adiministrativo a = new Adiministrativo();
    a.nome = Console.ReadLine();
    Console.Write("CPF: ");
    a.cpf = Console.ReadLine();
    Console.Write("Data de nascimento: ");
    a.dataNascimento = DateTime.Parse(Console.ReadLine());
    Console.Write("Sexo: ");
    a.sexo = Console.ReadLine();
    Console.Write($"o salario  de {a.nome} é: ");
    a.Salario();
}

if(escolhaFuncionario != 1 ||  escolhaFuncionario != 2)
{
    Console.WriteLine("escolha apenas uma das opções!!");
}


List<Medico> listMedico = new List<Medico>();
listMedico.Add(new Medico());
List<Adiministrativo> listADM = new List<Adiministrativo>();
listADM.Add(new Adiministrativo());

listMedico = listMedico.Where(x => x.salario >= 20000).ToList();

foreach(Medico gz in listMedico)
{
    Console.WriteLine($"os maiores salarios entre os medicos são de: {gz.nome}");
}

foreach (Adiministrativo gHH in listADM)
{
    Console.WriteLine($"os maiores salarios entre os ADM são de: {gHH.nome}");
}








