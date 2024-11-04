// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var now = DateTime.Now;
var rocYear = now.Year-1911;
var nowTime = now.ToString("MMddHH:mm:ss.fff");

Console.WriteLine(rocYear+nowTime);
