using System;
//Após a referenciação do projeto DomainLayer no UserInterface, devemos utilizar o "using" no projeto
//UserInterface para deixar claro para o compilador que desejamos implementar o projeto DomainLayer
//neste projeto:
using DomainLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Aluno: William Bruno Sales de Paula Lima
 * Curso: Fundamentos do Desenvolvimento de Aplicações com Visual C#
 * Tutor: Marcondes Alexandre
 * Oficina da Aula 5.2
 */
namespace UserInterface
{
    class Program
    {
        static void depositar(Conta[] conta)
        {
            /*
             * É perguntado ao usuário de qual cliente ele deseja relizar um depósito e é subtraído - 1
             *´para realizar as devidas operações com o índice certo, não sendo permitido digitar números
             *menores ou iguais a 0. Por fim, o valor do depósito é guardado em uma variável e passado
             *como argumento no método depositar pertencente ao objeto[i - 1] da matriz criada no método
             *main:
             */
            int i;
            Console.WriteLine("De que cliente deseja depositar dinheiro: ");
            do
            {
                i = int.Parse(Console.ReadLine());
                if (i <= 0) Console.WriteLine("Digite um número maior do que 0");
            } while (i <= 0);
            i = i - 1;
            Console.WriteLine("Digite o valor a ser depositado: ");
            double valor = double.Parse(Console.ReadLine());
            conta[i].depositar(valor);
            Console.WriteLine("Valor depositado com sucesso!");
        }
        static void saque(Conta[] conta)
        {
            /*
             * É perguntado ao usuário de qual cliente ele deseja relizar o saque e é subtraído - 1
             *para realizar as devidas operações com o índice certo, não sendo permitido digitar números
             *menores ou iguais a 0. Por fim, o valor do saque é guardado em uma variável e passado
             *como argumento no método sacar pertencente ao objeto[i - 1] da matriz criada no método
             *main. Se o saldo no objeto[i-1] instanciado da classe Conta for maior ou igual ao valor
             *a ser sacado, o saque é realizado, se não uma mensagem de aviso de "Saldo insuficiente"
             *é mostrada ao usuário:
             */
            int i;
            Console.WriteLine("De que cliente deseja sacar dinheiro: ");
            do
            {
                i = int.Parse(Console.ReadLine());
                if (i <= 0) Console.WriteLine("Digite um número maior do que 0");
            } while (i <= 0);
            i = i - 1;
            Console.WriteLine("Digite o valor a ser sacado: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine(conta[i].sacar(valor) == true ? "Saque realizado com sucesso!" : "Saldo " +
                "insuficiente!");
        }
        static void informacoesConta(Conta[] conta, int n)
        {
            /*
             * Esse método mostra ao usuário as informações guardadas nas variáveis de instância
             * dos n objetos instanciados da classe Conta:
             */
            int i;
            for(i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Cliente " + (i + 1) + ": ");
                Console.WriteLine();
                Console.WriteLine("Nome: "+(conta[i].getNomeCliente()));
                Console.WriteLine("CPF: " + (conta[i].getCpfCliente()));
                Console.WriteLine("Número da conta: " + (conta[i].getNumeroConta()));
                Console.WriteLine("Saldo da conta: " + (conta[i].getSaldoConta()));
            }
        }
        static void preencherDadosConta(Conta[] conta, int n)
        {
            /*
             * Este método lê do teclado do usuário informações e guarda nas variáveis de 
             * instância do i-ésimo objeto instanciado da classe Conta:
             */
            int i;
            for (i = 0; i < n; i++)
            {
                conta[i] = new Conta();
                Console.WriteLine("Digite o nome do cliente " + (i+1) + ": ");
                conta[i].setNomeCliente(Console.ReadLine());
                Console.WriteLine("Digite o cpf do cliente " + (i+1) + ": ");
                conta[i].setCpfCliente(Console.ReadLine());
                Console.WriteLine("Digite o número da conta do cliente " + (i+1) + ": ");
                conta[i].setNumeroConta(int.Parse(Console.ReadLine()));
                Console.WriteLine("Digite o saldo da conta do cliente " + (i + 1) + ": ");
                conta[i].setSaldoConta(double.Parse(Console.ReadLine()));
            }
        }
        static void Main(string[] args)
        {
            //Criação de duas variáveis, uma guarda a quantidade de objetos Conta que haverão
            //no programa e a variável i guarda um índice correspondente ao objeto Conta no qual
            //se deseja realizar operações:
            int n, i;
            do
            {
                Console.WriteLine("Digite quantas contas bancárias haverão no sistema: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0) Console.WriteLine("Digite um número maior do que 0");
            } while (n <= 0);

            //Crição de uma matriz de objetos do tipo Conta:
            Conta[] conta = new Conta[n];

            for (i = 0; i < n; i++)
            {
                conta[i] = new Conta();
            }

            //Método estático 
            //da classe Program que preenche os dados correspondentes dos n objetos da classe Conta:
            preencherDadosConta(conta, n);

            Boolean continuar = true;
            int opcao;
            //Loop que realiza saques e depósitos até que se deseje sair:
            do
            {
                Console.WriteLine("Digite que deseja realizar?");
                Console.WriteLine("[1] => Sacar dinheiro; [2] => Depositar Dinheiro ; [outro] => sair:");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        saque(conta);
                        break;
                    case 2:
                        depositar(conta);
                        break;
                    default:
                        Console.WriteLine("Saindo...");
                        break;
                }
                Console.WriteLine("Deseja continuar? ");
                //É perguntado se deseja continuar realizando saques e depósitos(true) ou sair(false):
                continuar = Boolean.Parse(Console.ReadLine());
            } while (continuar == true);

            //Método estático da classe Program que mostra para o usuário todas as informações dos n
            //objetos da classe Conta instanciados:
            informacoesConta(conta, n);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
