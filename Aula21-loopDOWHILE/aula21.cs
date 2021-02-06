using System;
class aula21 {
    static void Main (){
        string senha="123";
        string senhauser;
        int tentativa=0;

        do{
            Console.Clear();
            Console.WriteLine("Digite a senha");
            senhauser=Console.ReadLine();
            tentativa++;
        }while (senha != senhauser);
        Console.Clear();
        Console.WriteLine("Senha correta, tentativa: {0}", tentativa);
    }
}