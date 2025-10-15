using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Iphone: ");
Smartphone meuIphone = new Iphone(numero: "11991684074",modelo: "Modelo 0",imei: "123456789",memoria: 64);
meuIphone.Ligar();
meuIphone.InstalarAplicativo("Whatapp");

Console.WriteLine("Nokia: ");
Smartphone meuNokia = new Nokia(numero: "11991684074", modelo: "Modelo 1", imei: "012345678", memoria: 125);
meuNokia.Ligar();
meuNokia.InstalarAplicativo("Telegram");