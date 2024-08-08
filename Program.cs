using AULA02RH.Models;
namespace AULA02RH{
    class Program{
    static void Main(string[] args){

        Funcionario funcionario = new Funcionario();
        
        //funcionario.Id = 10;
        //funcionario.Nome = "Carol Biazin";
        //funcionario.Cpf = "12345678910";
        //funcionario.DataAdmissao = DateTime.Parse("01/01/2000");
        //funcionario.Salario = 10000.00M;
        //funcionario.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;

        Console.WriteLine("Digite o Id do funcionário: ");
        funcionario.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Nome do funcionário: ");
        funcionario.Nome = Console.ReadLine();

        Console.WriteLine("Digite o Cpf ");
        funcionario.Cpf = Console.ReadLine();

        Console.WriteLine("Digite a data de admissão: ");
        funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Salário: ");
        funcionario.Salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Tipo funcionário (1 - CLT | 2 - Aprendiz): ");
        int opcao = int.Parse(Console.ReadLine());
        funcionario.TipoFuncionario = (opcao == 1) ? Models.Enuns.TipoFuncionarioEnum.CLT : Models.Enuns.TipoFuncionarioEnum.Aprendiz;

        funcionario.ReajustarSalario();
        decimal valorDescontoVT = funcionario.CalcularDescontoVT(6);

        Console.WriteLine("====================================");
        Console.WriteLine($"O salário reajustado é {funcionario.Salario}.\n");
        Console.WriteLine($"O desconto do VT é {valorDescontoVT}.\n");
        Console.WriteLine("====================================");

    }
}
}
