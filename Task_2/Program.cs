/*
 * Выведите на экран надпись Hello World!!!, 
 * используя метод Console.Write. 
   Используйте Console.Write для каждого слова 
   (у вас будет три вызова метода: сначала для слова Hello, 
   потом для слова World, а затем — для трёх восклицательных знаков).
   Чтобы слова не «слипались», используйте пробелы внутри кавычек.
   Добавьте задержку Console.ReadLine, 
   чтобы приложение не закрывалось по завершении выполнения.
 */

using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Console.Write("World ");
            Console.Write("!!!");

            Console.ReadLine();
        }
    }
}