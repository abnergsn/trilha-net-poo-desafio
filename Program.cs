using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smarthphone Iphone");
Smartphone iphone = new Iphone(numero: "1111", Modelo : "xs38", IMEI: "1212", Memoria: 128 );
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");


Console.WriteLine("Smarthphone Nokia");
Smartphone nokia = new Nokia(numero: "2222", Modelo : "N72", IMEI: "1313", Memoria:258 );
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("dropbox");

