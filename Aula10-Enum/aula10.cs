using System;
class Aula10{
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};
    static void Main(){

        DiasSemana teste1 = DiasSemana.Quarta; // outras forma de impressão abaixo

        int teste2= (int)DiasSemana.Quarta; // int entre aspas para conversão

        DiasSemana teste3=(DiasSemana)2; //fazer uma operação de typecast (DiasSemana)

        Console.WriteLine(teste1);
        Console.WriteLine(teste2);
        Console.WriteLine(teste3);
      
    }
}