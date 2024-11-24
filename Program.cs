using DesafioCelular.Models;

Nokia nokia1 = new Nokia(40028922,"Modelo Nokia","gsoe8d0a97fdgx", 12);
nokia1.InstalarAplicativo("Youtube");
nokia1.ListarInformacoes();
nokia1.Ligar();

Iphone iphone1 = new Iphone(99999999,"Modelo Iphone", "hfkhfuighudghf", 15);
iphone1.InstalarAplicativo("Intagram");
iphone1.ListarInformacoes();
iphone1.ReceberLigacao();