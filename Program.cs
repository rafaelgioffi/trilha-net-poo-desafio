using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");
Smartphone n1 = new Nokia("12345", "N95", "123456789101112", 4);
n1.Ligar();
n1.Informacoes();
n1.InstalarAplicativo("WhatsApp");
n1.ReceberLigacao();

Console.WriteLine();

Console.WriteLine("iPhone:");
Smartphone ip1 = new Iphone("123457", "iPhone 11", "123456789101113", 256);
ip1.Ligar();
ip1.Informacoes();
ip1.ReceberLigacao();
ip1.InstalarAplicativo("Telegram");