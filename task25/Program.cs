string? readStr0 = Console.ReadLine();
string? readStr1 = Console.ReadLine();
if (!int.TryParse(readStr0, out int n0)) throw new Exception(readStr0 + " is not number");
if (!int.TryParse(readStr1, out int n1)) throw new Exception(readStr1 + " is not number");

Console.WriteLine(Math.Pow(n0, n1));