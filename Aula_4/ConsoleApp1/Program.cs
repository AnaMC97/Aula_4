using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int x = 0, y = 6;

            if (x < y && x > y) Console.WriteLine("X é maior que Y");

            bool parseOK = false;

            if (!parseOK) Console.WriteLine("Atenção que o parse N OK");

            //Controlos de Fluxo//
            //If (condição){ -> usar se for mais que uma condição
            //}else if (condição2){
            //} else{
            //}
            //bool hojeChove = true;
            //string mensagemUtilizador = "Olá XX, hoje ";
            //mensagemUtilizador = hojeChove ? mensagemUtilizador + "Chove" : mensagemUtilizador + "não Chove";
            //Console.WriteLine(mensagemUtilizador);

            //Switch(expressão)
            // {
            //case x:
            //code block
            //break;
            //default:
            //}

            //LOOPS//
            //for (int i = 0 -> declaração e inicialização; i < valor -> enquando for positivo corre o codigo; i++ -> incrementa);
            //{
            //    Console.WriteLine(i);
            //}
            //foreach(type variableName in arrayName)
            //{
            //code block a executar
            //}
            //EXEMPLO//
            //List<string> listaNomes = new List<string>();
            //listaNomes.Add("Manuel");
            //listaNomes.Add("Isabelle");
            //listaNomes.Add("Thati");
            //foreach(string nome in listaNomes)
            //{
            //    Console.WriteLine(nome.ToUpper);
            //}

            //While(condição)
            //{
            //codigo a executar
            //}
            //Do while//
            //do
            //{
            //codigo a executar
            //}
            //while (condição);

            //Instruções de saltos//
            //break -> para quando certa condição é correspondida
            //continue -> passa á frente
            //return -> termina a execução e retorna o resultado ou controlo
            //throw -> indica a ocurrência de uma expção

            /*int[] nomeVariavel = { 1, 2, 3, 4 };
            int[] nomeVariavel1 = new int[] { 1, 2, 3 };

            list<int> listaInts = new List<int>();

            for (int i = 0; i < nomeVariavel1.Length; i++)
            {
                //Console.WriteLine(i);
                if (nomeVariavel1[i] == 20) break;
                Console.WriteLine(nomeVariavel1[i]);
            }*/

            /*string nome = "João";
            string tempoAtual = "Chuva";
            string temperaturaAtual = "18º";

            Console.WriteLine("Olá {0}. Hoje o dia está de {1}. Estão {2}", "João", "Chuva", "18º");
            Console.WriteLine("Olá {0}. Hoje o dia está de {1}. Estão {2}", nome, tempoAtual, temperaturaAtual);
            Console.WriteLine($"Olá {nome}. Hoje o dia está de {tempoAtual}. Estão {temperaturaAtual}");*/

            //Função Return//
            /*static double CalculaOCubo(int numeroACalcular)
            {
                return Math.Pow(numeroACalcular, 3);
            }
            /*Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            if (args[1].Length)
            {
                throw new ArgumentException("Monsier");
            }

            //Gestão de erros e excepções
            try 
            {
                //codigo que pode ter excepções
                if (args.Lenght > 1)
                {
                    //throw new ArgumentException("Monsier Tem um argumento a mais",);
                    throw new IndexOutOfRangeException;
                }
            }
            catch (Exception e)
            {
                //handle exception
                Console.WriteLine("Ocorreu um erro. Por favor tente mais tarde");
                Console.WriteLine();
                Console.WriteLine(e.InnerException);
            }
            finally
            {
                //opecional
                //final clean up code
            }*/
            //executavel na pasta bin//

            //Console.WriteLine("Introduza um valor: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduza outro valor: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //if (n == n1) Console.WriteLine("Valores são iguais");
            //else Console.WriteLine("Valores são diferentes. Introduza outra vez");

            /*try
            {
                Console.WriteLine("Introduza um valor: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduza outro valor: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                if (n == n1) Console.WriteLine("Valores são iguais");
                else Console.WriteLine("Valores são diferentes.");
            }
            catch (FormatException) //-> letra se se pede int
            {
                Console.WriteLine("Valor introduzido invalido. Tente outra vez");
            }
            catch(Exception e)
            {

            }*/

            /*for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("Introduza a idade: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    if (n2 >= 18) Console.WriteLine("Pode votar!");
                    else Console.WriteLine("Não tem idade para votar");
                }
                catch (FormatException)
                {
                    Console.WriteLine("idade invalida Tente outra vez");
                }
                catch (Exception)
                {

                }
            }*/

            //devolva o nome do dia da semana
            int dia; 
            do
            {
                Console.WriteLine(">>>>>>>>>MENU<<<<<<<<<<");
                Console.WriteLine("Escolha o dia da semana");
                Console.WriteLine("1 - Segunda feira");
                Console.WriteLine("2 - Terça feira");
                Console.WriteLine("3 - Quarta feira");
                Console.WriteLine("4 - Quinta feira");
                Console.WriteLine("5 - Sexta feira");
                Console.WriteLine("6 - Sabado");
                Console.WriteLine("7 - Domingo");
                Console.WriteLine("0 - Sair...");
                dia = Convert.ToInt32(Console.ReadLine());

                switch (dia)
                {
                    case 1: Console.WriteLine("Segunda feira"); break;
                    case 2: Console.WriteLine("Terça feira"); break;
                    case 3: Console.WriteLine("Quarta feira"); break;
                    case 4: Console.WriteLine("Quinta feira"); break;
                    case 5: Console.WriteLine("Sexta feira"); break;
                    case 6: Console.WriteLine("Sabado"); break;
                    case 7: Console.WriteLine("Domingo"); break; 
                    case 0: Console.WriteLine("Sair..."); break;
                    //default: Console.WriteLine("Invalido");
                }
            } while (dia! = 0);


        }
    }
}
