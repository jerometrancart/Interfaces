// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choisir la langue");
Console.WriteLine("1. Français");
Console.WriteLine("2. Anglais");
Console.WriteLine("3. Espagnol");

int langue = int.Parse(Console.ReadLine()!);

IBonjour bonjour = langue switch 
{
    2 => new BonjourEn(),
    3 => new BonjourEs(),
    _ => new BonjourFr()
};

AfficherBonjour(bonjour);

void AfficherBonjour(IBonjour bonjour)
{
    System.Console.WriteLine(bonjour.GetBonjour());
}

public interface IBonjour
{
    string GetBonjour();
}

public class BonjourFr : IBonjour
{
    public string GetBonjour() => "Bonjour";
   
}
public class BonjourEn : IBonjour
{
    public string GetBonjour() => "Hello";
   
}

public class BonjourEs : IBonjour
{
    public string GetBonjour() => "Buenos diàs";
    
}
