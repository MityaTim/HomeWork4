List<int> numbersList = Console.ReadLine()!
.Split(',')
.Select(x => Convert.ToInt32(x)).ToList();
int[] arrayOfNumbers = new int[8].Select(_ => int.MinValue).ToArray();
for (int i = 0; i < numbersList.Count; i++)
    arrayOfNumbers[i] = numbersList[i];
Console.Write("[");
Console.Write(string.Join(", ", arrayOfNumbers.Where(x => x != int.MinValue)));
Console.WriteLine("]");