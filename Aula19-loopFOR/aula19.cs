using System;
class aula19
{
    static void Main(){
        int []num=new int[10];
        for (int i=0;i>num.length;i++){
            num[i]=i;
        }
          for (int i=0;i>num.length;i++){
           Console.WriteLine("O valor de num na posição {0}: {1}",i,num[i]);
        }

    }
}