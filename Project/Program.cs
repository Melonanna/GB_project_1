string[] strings = { "Hello","2", "world", ":-)" }; 
var result = strings.Where(s => s.Length <= 3).ToArray(); 
Console.Write(string.Join(", ", result)); 
Console.ReadLine();