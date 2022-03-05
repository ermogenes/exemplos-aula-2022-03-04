// Limpa a tela
Console.Clear();

// Exibe Ermogenes na cor certa
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Ermogenes");

// Espera uma tecla
Console.ResetColor();
Console.Write("Pressione uma tecla para continuar...");
Console.ReadKey();
Console.WriteLine();

// Exibe Neri
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Neri");

// Volta a cor padrão
Console.ResetColor();