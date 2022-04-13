using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_TI14T
{
    class controlexercicicos
    {
        // ligar classes 
        modelexercicios model;
        private int opcao;
        
        

        public controlexercicicos()
        {
            model = new modelexercicios();
            
        }//Fim do construtor 

        public int Consultaropcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
                  
            }
        }// fim opcao 

        public void Menu()
        {
            Console.WriteLine("---------MENU---------" +
                              "\n1. Exercicio 1\n" +
                              "\n2. Exercicio 2\n" +
                              "\n3. Exercicio 3\n" +
                              "\n4. Exercicio 4\n" +
                              "\n5. Exercicio 5\n" +
                              "\n6. Exercicio 6\n" +
                              "\n7. Exercicio 7\n" +
                              "\n8. Exercicio 8\n" +
                              "\n9. Exercicio 9\n" +
                              "\n10. Exercicio 10\n"+
                              "\n11. Exercicio 11\n");
            Console.WriteLine("Escolha uma das opções acima");
            Consultaropcao = Convert.ToInt32(Console.ReadLine());
        }// fim menu

        public void executar()
        {
            Menu();
            switch (Consultaropcao)
            {
                default:

                    Console.WriteLine("codigo digitado nao valido");
                        break;

                case 1:
                   Console.WriteLine (model.Exercicio1());
                    break;

                case 2:
                    Console.WriteLine("escreva um numero");
                        int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("O antecessor de " + num + " é " + model.Exercicio2(num));
                    break;
                case 3:
                    
                        Console.WriteLine("digite o valor da altura do retângulo");
                        int numero1 = Convert.ToInt32(Console.ReadLine());
                 
                    Console.WriteLine("Digite o valor da base do retângulo");
                    int numero2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A area do retangulo é " + model.Exercicio3(numero1, numero2));
                    break;
                 case 4:

                    Console.WriteLine("Digite sua idade completa, primeiro os anos : ");
                    int anos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Agora os meses : ");
                    int meses = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Agora os dias : ");
                    int dias = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sua idade total em dias é " + model.exercicio4(dias, anos, meses));
                    break;

                case 5:
                    Console.WriteLine("Digite a quantidade total de votos :");
                    int eleitores  = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de Votos Brancos:");
                    int branco = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de Votos Nulos: ");
                    int nulo = Convert.ToInt32(Console.ReadLine()); 
                    Console.WriteLine("Digite a quantidade de Votos Validos: ");
                    int voto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(model.exercicio5(voto, nulo, branco, eleitores));
                    break;


                case 6:

                    Console.WriteLine("digite o valor do salario mensal");
                    int sm = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor do reajuste");
                    int percen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Seu salario com reajuste é " + model.Exercicio6(sm, percen));
                    break;

                case 8:
                    Console.WriteLine("Digite a primeira nota : ");
                    double nota1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a segunda nota: ");
                    double nota2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a terceira nota : ");
                    double nota3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sua nota final é " + model.exercicio8(nota1, nota2, nota3));
                    break;
               


            }
        }

      



    }// fim class 
}
