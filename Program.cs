using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone*

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1234567890", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "0987654321", memoria: 256);
Iphone.Ligar();
Iphone.InstalarAplicativo("Instagram");
