using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_TI14T
{
    class modelexercicios
    {
        private int num1;
        private int num2;
        private int num3; // declara variaveis 

        // declarar construtor 
        public modelexercicios()
        {
            ModificarNum1 = 10;
            ModificarNum2 = 20;
            ModificarNum3 = 0;

        }// fim construtor 
        public int ModificarNum1
        {
            get
            {
                return num1;
            }
            set
            {
                this.num1 = value;
            }
        }// fim modificar num 1

        public int ModificarNum2
        {
            get
            {
                return num2;
            }
            set
            {
                this.num2 = value;
            }
        }// fim modificar num 2 

        public int ModificarNum3
        {
            get
            {
                return num3;

            }
            set
            {
                this.num3 = value;
            }
        }// fim modificar num3 

        // metodo para exercicio 1 
        public string Exercicio1()
        // para retornar varias variaveis usar string, numeros retornam um valor 
        {
            ModificarNum3 = ModificarNum1;
            ModificarNum1 = ModificarNum2;
            ModificarNum2 = ModificarNum3;
            return "num1: " + ModificarNum1 + "\nnum2:" + ModificarNum2;


        }// fim metodo exercicio1 










        // exercicio 2 


        public int Exercicio2(int num)

        {
            return num - 1;
        }


        // exxercicio 3 

        public int Exercicio3(int numero1, int numero2)
        {

            return numero1 * numero2;

        }

        // exercicio 4 
         
      
        
        public double exercicio4(int anos, int meses, int dias)
        {
            anos = anos * 365;
            meses = meses * 30;
            return dias + meses + anos;
           
        }


        // exercicio 5 
       
        public string exercicio5( double voto, double nulo, double branco, double
            eleitores)
        {
            branco =(branco / eleitores) * 100;
            nulo = (nulo / eleitores) * 100;
            voto = (voto / eleitores) * 100;
            string msg = "Porcentagem de Votos Brancos: " + branco + "%\n" +
                         "Porcentagem de Votos Nulos: " + nulo + "% \n" +
                         "Porcentagem de Votos Validos: " + voto + "%"; 
            return msg;

        }


        // exercicio 6 

        public double Exercicio6(double sm, double percen )
        {

            percen = percen / 100;
            return sm *percen + sm;
        
        }

        //Exercicio 7 
        
        public double exercicio8( double nota1, double nota2,double nota3)
        {
            nota3 = nota1 + nota2 + nota3;
            return nota3 / 3;

        }

        // Exercicio 9 

      public double exercicio91 (double maca)
        {
            return maca * 1.30;
        }
     
        public double exercicio92(double maca)
        {
            return maca * 1;
        }





















       
    }// fim class 
}

// cada variavel tem que ter um get e um set 
// instanciar dar valor inicial!!!!