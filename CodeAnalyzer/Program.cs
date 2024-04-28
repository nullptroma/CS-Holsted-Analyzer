using CodeAnalyzer;

string path = @"/home/nullptr/Desktop/software quality/Lab2/CodeAnalyzer/Analyzer.cs";
//string path = @"/home/nullptr/Desktop/software quality/Lab2/Lab2/Program.cs";
var exist = File.Exists(path);
while(!exist)
{
    Console.WriteLine("Введите путь к файлу .cs: ");
    path = Console.ReadLine() ?? "";
    exist = File.Exists(path);
    if (!exist)
        Console.WriteLine($"Файла ${path} не существует.");
}

var allCode = File.ReadAllText(path);
var analyzer = new Analyzer(allCode);
Console.WriteLine(analyzer);
Console.WriteLine($"\nОбщий вес программы: {analyzer.CalcVolume()}");