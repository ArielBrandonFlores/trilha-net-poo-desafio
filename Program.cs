using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarphone Iphone");
Iphone iphone = new Iphone("99999999999", "Iphone", "078326-023", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatapp");
Console.WriteLine("/n");
Console.WriteLine("Smarphone Nokia");
Nokia nokia = new Nokia("5555555555", "Nokia", "0315352-021", 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Jogo do Tigrinho");