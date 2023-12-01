double Salario;

Console.Write("Digite seu salário por hora: ");
double Salariohora;
Salariohora = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.Write("Digite suas horas totais: ");
double Horastotais;
Horastotais = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.Write("Digite suas horas extras: ");
double Horasextras;
Horasextras = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

void CalSalario()
{
    Salario = (Salariohora * (Horastotais - Horasextras)) + (double)(Salariohora * Horasextras * 1.4);
    Console.WriteLine($"salario-hora {Salariohora:C}, {Horastotais} horas, sendo {Horasextras} horas-extra, salário = {Salario:C}");
}

CalSalario();
