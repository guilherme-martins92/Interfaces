using System;
using System.Globalization;
using ExercicioInterface.Entities;
using ExercicioInterface.Services;

namespace ExercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do contrato");
            Console.Write("Número do contrato: ");
            int numeroContrato = int.Parse(Console.ReadLine());

            Console.Write("Data do contrato (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.Parse(Console.ReadLine());

            Console.Write("Valor do contrato: ");
            double valorDoContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade de parcelas: ");
            int numeroParcelas = int.Parse(Console.ReadLine());

            Contract contrato = new Contract(numeroContrato, dataContrato, valorDoContrato);

            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(contrato, numeroParcelas);

            Console.WriteLine("");
            Console.WriteLine("Parcelas: ");
            Console.WriteLine("");

            foreach (Installment parcelas in contrato.Installments)
            {
                Console.WriteLine(parcelas);
            }

        }
    }
}
