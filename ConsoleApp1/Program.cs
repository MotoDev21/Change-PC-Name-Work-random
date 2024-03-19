using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    static extern bool SetComputerName(string computerName);

    static void Main(string[] args)
    {
        // Генерация рандомных цифр
        Random rand = new Random();
        int randomNumber = rand.Next(1000, 9999); // Генерируем 4-х значное число

        // Формируем новое имя компьютера
        string newComputerName = "WORK" + randomNumber;

        // Меняем имя компьютера
        if (SetComputerName(newComputerName))
        {
            Console.WriteLine("Имя компьютера успешно изменено на: " + newComputerName);
        }
        else
        {
            Console.WriteLine("Ошибка при изменении имени компьютера.");
        }

        Console.ReadLine();
    }
}
