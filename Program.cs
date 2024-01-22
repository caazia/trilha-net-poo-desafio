using System.Globalization;
using System.Runtime;
using DesafioPOO.Models;

//Nokia
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new(numero: "998123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);

Smartphone.Ligar();
Console.WriteLine("\t");

nokia.InstalarAplicativo("Whatsapp");
Console.ReadKey();

//Iphone
Console.WriteLine("\nSmartphone Iphone:");
Iphone iphone = new(numero: "995654321", modelo: "Modelo 2", imei: "333333333", memoria: 124);

Smartphone.ReceberLigacao();
Console.WriteLine("\t");

iphone.InstalarAplicativo("Telegram");
Console.WriteLine("\t");

iphone.DesinstalarAplicativo("Instagram");
Console.ReadKey();

// DONE: Realizar os testes com as classes Nokia e Iphone