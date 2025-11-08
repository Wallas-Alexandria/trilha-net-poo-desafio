using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("123-456-7890", "iPhone 13", "IMEI1234567890", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");



Nokia nokia = new Nokia("098-765-4321", "Nokia 3310", "IMEI0987654321", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
