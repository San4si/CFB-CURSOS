using System;
class vetorbidi{
    static void Main(){
        int [,] vet= new int[3,5]; //tres linhas e cinco colunas
        int [,] ved= new int[2,2]{{10,30},{40,50}};

        /*
        10,20,30,40,50
        60,70,80,90,15
        25,35,45,55,65
        */

        vet[0,0]=10;
        vet[0,1]=20;
        vet[0,2]=30;
        vet[0,3]=40;
        vet[0,4]=50;

        vet[1,0]=60;
        vet[1,1]=70;
        vet[1,2]=80;
        vet[1,3]=90;
        vet[1,4]=15;

        vet[2,0]=25;
        vet[2,1]=35;
        vet[2,2]=45;
        vet[2,3]=55;
        vet[2,4]=65;

        Console.WriteLine("O numero que esta na posição linha 2 e coluna 2 é o: "+vet[2,2]);
    }
}