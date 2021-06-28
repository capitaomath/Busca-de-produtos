using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;


class MainClass {

   
  public static void Cadastrar(){
 
    Console.WriteLine("\n\nCadastro de Produto");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Preço: ");
    double preco = Convert.ToDouble(Console.ReadLine());
    Produto p = new Produto(nome, preco);
    p.Persistir();

  }

  public static void Listar()
  {
    Console.WriteLine("\n");
    List<Produto> produtos = Produto.ConsultarProdutos();
    foreach(var produto in produtos)
    {
      produto.Imprimir();
    }

    Console.WriteLine("Aperte qualquer tecla para voltar");

  }


  public static void Procurar()
  {  
    Console.Clear();
    
    Console.WriteLine("Escreva o nome do produto de que deseja procurar");
    

    string procurar_ = Console.ReadLine();
 
    Console.Clear();
    
    Console.WriteLine("Mostrando todos os registros de: {0}", procurar_);
    
  
    List<Produto> produtos = Produto.ProcurarProdutos(procurar_);
    foreach(var produto in produtos)
    {
      produto.Imprimir();
    }
  
   
    Console.WriteLine("Aperte qualquer tecla para voltar");
   
  }
 

 
    public static void Main(string[] args)
          {                 
                bool MostrarMenu = true;
                while (MostrarMenu)
                {
                    MostrarMenu = MenuPrincipal();
                }
          }




          private static bool MenuPrincipal()
            {

                Console.Clear();

                Console.WriteLine("Bem vindo à loja Games confiáveis!!! ");

                Console.WriteLine("\n");

                Console.WriteLine("Aperte '1' para Listar os produtos");

                Console.WriteLine("Aperte '2' para Cadastrar um produto");

                Console.WriteLine("Aperte '3' para Deletar todos os produtos");

                Console.WriteLine("Aperte '4' para Pesquisar um produto");

                Console.WriteLine("Aperte '5' para Fechar a loja");

                Console.WriteLine("\n");
              
                switch (Console.ReadLine())
                {
                        
                        case "1":
                            Listar();
                            Console.Read();    
                         return true;

                        case "2":
                            Cadastrar();
                            Console.Read();                          
                        return true;

                        case "3":
                            Produto.Deletar();
                            Console.Read();                          
                        return true;

                        case "4":                       
                            Procurar();
                            Console.Read();   
                        return true;


                        
                        case "5":
                        
                           Console.Clear();
                           Console.WriteLine("Você fechou a loja :(");

                           return false;
                           

                        
                        default:
                            return true;



                }




            }


}