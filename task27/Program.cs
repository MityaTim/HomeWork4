string? readStr0 = Console.ReadLine();
if (!int.TryParse(readStr0, out _)) throw new Exception(readStr0 + " is not number");
Console.WriteLine(readStr0.ToCharArray().Select(x => x - '0').Sum());
