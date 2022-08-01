namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("--------------------");
            Console.WriteLine("Seleciona uma opção: ");

            short res = short.Parse(Console.ReadLine() ?? throw new NullReferenceException());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Subtract(); break;
                case 3: Divide(); break;
                case 4: Multiply(); break;
                default: Menu(); break;
            }


        }
        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine() ?? throw new NullReferenceException());
            Console.WriteLine($"Primeiro valor = {v1} {Environment.NewLine}");

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine() ?? throw new NullReferenceException());
            Console.WriteLine($"Segundo valor = {v2} {Environment.NewLine}");

            float r = v1 + v2;
            Console.WriteLine($"A soma desses valores = {r} {Environment.NewLine}");
            Console.ReadKey();
            Menu();
        }

        static void Subtract()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine() ?? throw new NullReferenceException());
            Console.WriteLine($"Primeiro valor = {v1} {Environment.NewLine}");

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine() ?? throw new NullReferenceException());
            Console.WriteLine($"Segundo valor = {v2} {Environment.NewLine}");

            float r = v1 - v2;
            Console.WriteLine($"A subtração desses valores = {r} {Environment.NewLine}");
            Console.ReadKey();
            Menu();
        }

        static void Divide()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine() ?? throw new NullReferenceException());
            Console.WriteLine($"Primeiro valor = {v1} {Environment.NewLine}");

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine() ?? throw new NullReferenceException());
            Console.WriteLine($"Segundo valor = {v2} {Environment.NewLine}");

            float r = v1 / v2;
            Console.WriteLine($"A divisão desses valores = {r} {Environment.NewLine}");
            Console.ReadKey();
            Menu();
        }

        static void Multiply()
        {

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine() ?? throw new NullReferenceException());
            Console.WriteLine($"Primeiro valor = {v1} {Environment.NewLine}");

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine() ?? throw new NullReferenceException());
            Console.WriteLine($"Segundo valor = {v2} {Environment.NewLine}");

            float r = v1 * v2;
            Console.WriteLine($"A multiplicação desses valores = {r} {Environment.NewLine}");
            Console.ReadKey();
            Menu();
        }

    }
}

