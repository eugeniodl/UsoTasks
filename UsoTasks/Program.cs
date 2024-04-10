Task t1 = new Task(Proceso1);
t1.Start();

t1.Wait();

Task t2 = Task.Run(() => Proceso2());

Console.ReadLine();

void Proceso2()
{
    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Proceso2 {i}");
    }
}

void Proceso1()
{
    for (int i = 0; i < 5; i++)
    {
        Thread.Sleep(500);
        Console.WriteLine($"Proceso1 {i}");
    }
}