using System;
class ArrayVetor{
    static void Main(){

        int[] num= new int[3] {20,30,99}; // Forma de iniciar array

        int[] teste={20,30,99}; // outra forma de inciar e declarar Array

        int[] n= new int[5]; // outra forma de array
        n[0]=10;
        n[1]=5;
        n[2]=100;
        n[3]=50;
        n[4]=50;

        string[] nomes={"Sandro", "Luciana", "Ayla"};

        Console.WriteLine("Nomes dos aprovados: {0} {1} {2}", nomes);
        Console.WriteLine(n[3]);
        Console.WriteLine(num[1]);
        Console.WriteLine(teste[1]);
    }
}