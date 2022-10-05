using DesafioPOO.Models;

Console.WriteLine("Celular Smartphone Iphone!");
Smartphone iphone = new Iphone(numero: "995558747", modelo: "Iphone 13", imei: "888777666555IPH",
    memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("Celular Smartphone Nokia!");
Smartphone nokia = new Nokia(numero: "995558747", modelo: "Nokia 812", imei: "888777666555NK",
    memoria: 512);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");