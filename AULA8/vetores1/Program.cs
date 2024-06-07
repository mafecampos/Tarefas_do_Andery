using System;
class HelloWorld
{
    static void Main()
    {
        int[] nums = new int[10];
        Console.WriteLine("Escolha dez números inteiros: ");
        for (int i = 0; i < nums.Length; i++)
        {
            int escolha;
            escolha = int.Parse(Console.ReadLine());
            nums[i] = escolha;
            if (nums[i] % 2 == 0)
            {
                Console.WriteLine("Seu número é PAR!");
            }
            else
            {
                Console.WriteLine("Seu número é ÍMPAR!");
            }
        }
    }
}