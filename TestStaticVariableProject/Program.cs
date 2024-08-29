using TestStaticVariableProject;

Console.WriteLine(Counter.a);
Counter c = new Counter();
Counter c2 = new Counter();
Counter c3 = new Counter();
Counter c4 = new Counter();
Console.WriteLine(Counter.a);


Console.WriteLine("===============");

Counter2 c6 = new Counter2();
Console.WriteLine(c6.a);