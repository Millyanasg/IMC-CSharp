using System;

class Program {
    static void Main() {
        Console.Write("Informe a sua altura em metros: ");
        float altura = float.Parse(Console.ReadLine());

        Console.Write("Informe o seu peso em quilos: ");
        float peso = float.Parse(Console.ReadLine());

        float imc = peso / (altura * altura);

        Console.WriteLine("Seu IMC é: {0:F2}", imc);
    }
}