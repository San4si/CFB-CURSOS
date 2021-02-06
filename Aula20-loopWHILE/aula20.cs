using System;
class aula20{
    static void Main(){
        int []num=new int[10];
        /**No loop While tenho que iniciar a variavel contadora antes do while
 e a expressao o incremento do contador dentro do while, senão cria loop
infinito*/
        int i=0;

        while (i<10)
        {
            Console.WriteLine("Cursos CFB");
            i++;
        }
        Console.WriteLine("Fim do progroma");

        while(i<num.Length){
            num[i]=0;
            Console.WriteLine(num[i]);
            i++;
        }
        Console.WriteLine("Fim do Loop");
    }

}