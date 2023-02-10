// See https://aka.ms/new-console-template for more information

Console.WriteLine("Os 20 primeiros números FIBONACCI são:");
  int a = 0, b = 1, c = 0;  
    Console.WriteLine("{0} {1}", a,b);  
    for (int i = 2; i <= 20; i++)  
    {  
        c= a + b;  
        Console.WriteLine("{0}", c);  
        a= b;  
        b= c;  
    }