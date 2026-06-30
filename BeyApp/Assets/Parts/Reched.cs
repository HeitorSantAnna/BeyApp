using UnityEngine;

[CreateAssetMenu(menuName = "BeysParts/Reched")]
public class Reched : Beys
{
    public SystemReched Sreched;

    public Number number;

    public bool IsSimple;

    public HeightD heightD;

    public HeightS heightS;

    public override string NameP()
    {
        if(IsSimple)
        {
            return nameParts = $"{number}-{heightS}";
        }
        else
        {
            return $"{number}-{heightD}";
        }
    }
}

public enum SystemReched
{
    Simple,
    Double
}

public enum Number
{
    Zero = 0,
    Um = 1,
    Dois = 2,
    Três = 3,
    Quatro = 4,
    Cinco = 5,
    Seis = 6,
    Sete = 7,
    Oito = 8,
    Nove = 9
}

public enum HeightD
{
    Cinquenta = 50,
    Sessenta = 60,
    Setenta = 70,
    Oitenta = 80
}

public enum HeightS
{
    QuarentaCinco = 45,
    CinquentaCinco = 55,
    SessantaCinco = 65,
    SetentaCinto = 75,
    OitentaCinco = 85
}