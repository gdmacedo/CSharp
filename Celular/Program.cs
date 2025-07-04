using DesafioPOO.Models;

// Realizando os testes com as classes Nokia e Iphone
Console.Clear();

Console.WriteLine("Smartphone NOKIA");
Smartphone nokia = new Nokia(numero: "113698526541", modelo: "NOKIA C159", imei: "7896541230", memoria: 512);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "113698526541", modelo: "Iphone 16", imei: "3216549870", memoria: 1024);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

using DesafioPOO.Models;

