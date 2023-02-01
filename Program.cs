using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "A10", imei: "1234ABCD", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "XR", imei: "4321DBCA", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");