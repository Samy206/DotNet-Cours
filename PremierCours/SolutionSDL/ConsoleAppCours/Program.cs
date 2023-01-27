// See https://aka.ms/new-console-template for more information
using ConsoleAppCours;

Console.WriteLine("Hello, World!");

var developpeurs = new List<Dev>();

developpeurs.Add(new DevJava("Oui"));
developpeurs.Add(new DevC("Chad"));
developpeurs.Add(new DevC() {Prenom = "Fred"}); // new DevC() { Attribut = .... } est un initialiseur, pas un constructeur.
                                                // Il est donc préférable d'utilier ça dans le cas de classes qui ont plusieurs attributs

// Les lignes précédentes correspondent à la syntaxe :
developpeurs = new List<Dev>() { new DevJava("Oui"), new DevC("Chad"), new DevC() { Prenom = "Fred"} };

foreach(var dev in developpeurs)
{
    dev.Develop();
    Console.WriteLine(dev.Prenom + " est en train de coder");
}

