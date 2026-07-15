using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("123456789", "Nokia", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone("987654321", "iPhone", "222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");