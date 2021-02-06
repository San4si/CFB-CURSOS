using System;
class ComandoGoto{

    static void Main(){
        int tempo=0;
        char escolha;

        inicio:

        Console.Clear(); // limpa todo o comando do console

        Console.WriteLine("\nBelo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o Transporte: [A] Avião | [B]Carro | [C]Ônibus ");
        escolha=char.Parse(Console.ReadLine());

        switch(escolha){
            case 'A':
            case 'a':
                tempo=50;
                break;
            case 'B':
            case 'b':
                tempo=480;
                break;
            case 'C':
            case 'c':
                tempo=660;
                break;
            default:
                tempo=-1;
                break;
        }
        if(tempo<0){
            Console.WriteLine("Transporte indisponivel");
        }
        else {
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
        }
        Console.Write("\nCalcular outro transporte? [s/n]: ");
        escolha=char.Parse(Console.ReadLine());
        if (escolha=='s' || escolha=='S'){
            goto inicio;
        }else {
            Console.Clear();
            Console.WriteLine("Fim do Programa! ");
        }
    }
}