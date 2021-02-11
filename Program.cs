using System;

namespace hello_world2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string exampleString = "Hello World!";
            int exampleInt = 50; //4 bytes ограниченние
            float exampleFloat = 50.5f; //4 bytes
            double exampleDouble = 50.5;
            short exampleShort = 50; //2 bytes
            long exampleLong = 50; // 8 bytes

            bool exampleBool = true; // true/false
            char exampleCharacter = 'n';// только 1 символ
            char[] exampleCharacters = { 'f', 'e', 'q' };

            string[] hellos = { "Hallo", "Hello", "Salve", "Ciao" };


            Console.WriteLine(hellos[0]);
            Console.WriteLine(hellos[3]);


            Console.WriteLine(exampleString);


            foreach (string hello in hellos)



            for (int i = 0;i<exampleInt; i++)
            {
                Console.WriteLine(hello);
                i++;
                Console.WriteLine("Вы продолжили " + i + " times.");

                /*if (Console.ReadKey().Key == ConsoleKey.N)
                {
                Console.WriteLine("\nВы продолжили.");
                Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nПора остановиться.");
                    Console.ReadKey();
                }
                */
            }

            switch (exampleCharacter)
            {
                case 'n':
                    Console.WriteLine("It is N");
                    break;

                case 't':
                    Console.WriteLine("It is T");
                    break;

                case 'q':
                    Console.WriteLine("It is Q");
                    break;

                default:
                    Console.WriteLine("It is not any of known symbols.");
                    break;

            }



        } 
    }
}
