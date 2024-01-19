using System.Globalization;
using System.Runtime;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);

Smartphone.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.ReadKey();

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "333333333", memoria: 268);

Smartphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.DesinstalarAplicativo("Instagram");


// DONE: Realizar os testes com as classes Nokia e Iphone