using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Vale ressaltar que as classes criadas no Domain Layer só poderão ser usadas no projeto
 * UserInterface quando forem devidamente referenciadas. Portanto, abra o projeto UserInterface
 * e vá em "Referências", caso esteja usando o Visual Studio e clique em "adicionar referência" =>
 * "Projetos" e selecione o DomainLayer. Feito! Agora você pode criar objetos das classes criadas no
 * DomainLayer em programas no projeto UserInterface :)
 */
namespace DomainLayer
{
    //Classe Conta que herda atributos e métodos da classe Cliente, além de possuir atributos e métodos
    //prórpios como numero da conta e saldo da conta e métodos acessadores(getter's) e de configuração
    //(setter's) para cada um deles:
    public class Conta : Cliente
    {
        private int numeroConta;
        private double saldo;
        
        public void setNumeroConta(int numero)
        {
            numeroConta = numero;
        }
        public int getNumeroConta()
        {
            return numeroConta;
        }
        public void setSaldoConta(double valor)
        {
            saldo = valor;
        }
        public double getSaldoConta()
        {
            return saldo;
        }
        public void depositar(double deposito)
        {
            saldo += deposito;
        }
        public Boolean sacar(double saque)
        {
            if(saldo >= saque)
            {
                saldo -= saque;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
