using System;
using System.IO;

namespace TextEditor
{
    class Program
    {

//Programa principal, usado para chamar as funções.
        static void Main(string[] args)
        {
            Menu();
        }

//Função de criação do menu de Arquivos.
        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que você deseja fazer ?"); 
            Console.WriteLine("1 -Abrir Arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            //Armazenando o número que o usuário vai digitar na variável 'option'.
            short option = short.Parse(Console.ReadLine());
            
            switch(option)
            {
                // case 0 > sair do programa
                case 0 : System.Environment.Exit(0); break;
                case 1 : Abrir(); break;
                case 2 : Editar(); break;
                // default > volta para o menu se o usuário não digitar 0,1,2.
                default: Menu(); break;       
            }
        }

//Função para abrir o arquivo.
        static void Abrir(){ } 

// (Função Editar)Função para criar um arquivo.        
        static void Editar(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair");
            Console.WriteLine("---------------------");
            string text = "";

            do  {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);
            
            Console.Write(text);
         }
// (Função Salvar)Função para salvar o arquivo.         
         static void Salvar(string text){
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();
            // path em inglês é caminho.

            using (var file = new StreamWriter(path)){
                file.Write(text);
            }
         }
    }
}
