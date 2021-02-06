using System;
class aula25 {
    static void Main(){
        int num = 10;
        dobrar(ref num);
        Console.WriteLine(num);

    }
    static void dobrar(ref int valor) /*\Argumento out da a possibilidade do metodo retornar mais de um valor*/
    {
        valor*=2;
    }
}