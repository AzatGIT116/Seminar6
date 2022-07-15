void SomeFunc(int a)
{
    Console.WriteLine($"На входе {a}");
    if (a < 0)
        return;

    Console.WriteLine(a);
    SomeFunc(a - 1);
    Console.WriteLine($"На выходе {a}");
}

SomeFunc(5);