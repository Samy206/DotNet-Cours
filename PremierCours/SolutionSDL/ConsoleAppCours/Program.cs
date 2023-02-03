// See https://aka.ms/new-console-template for more information
using ConsoleAppCours;
using ConsoleAppCours.Core;
using System.Security.Cryptography;

var developpeurs = new List<Dev>();

developpeurs.Add(new DevJava("Cui"));
developpeurs.Add(new DevC("Chad"));
developpeurs.Add(new DevC() {Prenom = "Fred"}); // new DevC() { Attribut = .... } est un initialiseur, pas un constructeur.
                                                // Il est donc préférable d'utilier ça dans le cas de classes qui ont plusieurs attributs
/*
// Les lignes précédentes correspondent à la syntaxe :
developpeurs = new List<Dev>() { new DevJava("Oui"), new DevC("Chad"), new DevC() { Prenom = "Fred"} };

foreach(var dev in developpeurs)
{
    dev.Develop();
    //Console.WriteLine(dev.Prenom + " est en train de coder");
}


// Interpollation / Extension de type

var stringValue = "toto";
Console.WriteLine(stringValue.GetData());
Console.ReadLine();


var devFilterRes = developpeurs.Where(@dev => @dev.Prenom.StartsWith("C"));
if(devFilterRes != null)
{
    Console.WriteLine(devFilterRes.ElementAt(0).Prenom);
}

var c = new ClassLibrary

Console.WriteLine(developpeurs);
Console.WriteLine("oui");

var devFilterRes2 = (from Dev d in developpeurs where d.Prenom.StartsWith("C") select d).ToList();
if (devFilterRes2 != null)
{
    Console.WriteLine(devFilterRes2.ElementAt(0).Prenom);
}

