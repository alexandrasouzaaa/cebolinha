string fraseOriginal;

Console.Write("Por favor, digite algo que tenha a letra R: ");
fraseOriginal = Console.ReadLine()!;

Console.WriteLine(fraseOriginal.Replace("r", "l").Replace("R", "L"));
