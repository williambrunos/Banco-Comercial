using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    //Classe que representa um Cliente em nosso banco comercial com atributos nome e cpf privados
    //(encapsulados) e métodos acessadores(getter's) e de configuração(setter's) para ambos os
    //atributos:
    public class Cliente
    {
        private string nome;
        private string cpf;
        public void setNomeCliente(string name)
        {
            nome = name;
        }
        public string getNomeCliente()
        {
            return nome;
        }
        public void setCpfCliente(string cadastroPessoaFisica)
        {
            cpf = cadastroPessoaFisica;
        }
        public string getCpfCliente()
        {
            return cpf;
        }
    }
}
