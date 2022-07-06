using System.Diagnostics; // Relojes, Cronos
using System.Threading; // usar Diversos hilos
using System.Threading.Tasks; // Tareas que se van a poder usar varias tareas
// La programacion asincrona se refiere a la programacion en hilos, trabajos en paralelo
Stopwatch sw = Stopwatch.StartNew();
// Task 1

var task1 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();// Se usar para medir con precicion la cantidad de tiempo transcurrido    
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task 1: {crono.Elapsed}");
});

var task2 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();// Se usar para medir con precicion la cantidad de tiempo transcurrido    
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task 2: {crono.Elapsed}");
});

var task3 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();// Se usar para medir con precicion la cantidad de tiempo transcurrido    
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task 3: {crono.Elapsed}");
});
var str = await RandomAsync(); // En un caso real async  task puede tardar (Milisegundos o Segundos)

var task4 = new Task(async () =>
{
    var str = await RandomAsync();
    Console.WriteLine("Task4 " + str);
});
task1.Start();
// TODO:
task2.Start();
// TODO:
task3.Start();
// TODO:
task4.Start();
await task1;
await task2;
await task3;
await task4;
Console.WriteLine(str);

sw.Stop();
Console.WriteLine($"Todo el main {sw.Elapsed}");
static async Task<string> RandomAsync()
{
    Stopwatch sw = Stopwatch.StartNew();
    var num = new Random().Next(1000);
    Thread.Sleep(1000);
    sw.Stop();
    var str = $"{num.ToString()} Calculado en {sw.Elapsed}";
    //Console.WriteLine(str);
    return str;
}