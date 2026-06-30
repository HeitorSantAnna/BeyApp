using UnityEngine;

[CreateAssetMenu(menuName = "BeysParts/Layer")]
public class Layer : Beys
{
    public SystemBey Sbey;

    public bool NeedReched;

    public MainBlade mainBlade;

    public BladeBX Bblade;

    public override string NameP()
    {
        if(Sbey == SystemBey.BX)
        {
            return RealName(Bblade);
        }
        else
        {
            return $"Bblade";
        }
    }

    private string RealName(BladeBX blade)
    {
        switch(blade)
        {
            case BladeBX.DranS:
                return "Dran Sword";
            case BladeBX.HellsS:
                return "Hells Scythe";
            case BladeBX.Wizard:
                return "Wizard Arrow";
            case BladeBX.KnightS:
                return "Knight Shield";
            case BladeBX.KnightL:
                return "Knight Lance";
            case BladeBX.Shark:
                return "Shark Edge";
            case BladeBX.Leon:
                return "Leon Claw";
            case BladeBX.Viper:
                return "Viper Tail";
            case BladeBX.Rhino:
                return "Rhino Horn";
            case BladeBX.DranD:
                return "Dran Dagger";
            case BladeBX.HellsC:
                return "Hells Chain";
            case BladeBX.PhoenixW:
                return "Phoenix Wing";
            case BladeBX.Wyvern:
                return "Wyvern Gale";
            case BladeBX.Unicorn:
                return "Unicorn Sting";
            case BladeBX.Sphinx:
                return "Sphinx Cowl";
            case BladeBX.Tyranno:
                return "Tyranno Beat";
            case BladeBX.Weiss:
                return "Weiss Tiger";
            case BladeBX.Cobalt:
                return "Cobalt Dragoon";
            case BladeBX.Black:
                return "Black Shell";
            case BladeBX.Whale:
                return "Whale Wave";
            case BladeBX.Crimson:
                return "Crimson Garuda";
            case BladeBX.Shelter:
                return "Shelter Drake";
            case BladeBX.Silver:
                return "Silver Wolf";
            case BladeBX.PhoenixR:
                return "Phoenix Rudder";
            default: return "";
        }
    }
}

#region Sistema de Bey

    public enum SystemBey
    {
        BX,
        CX,
        UX,
        XpendB,
        XpendC,
        EpendU
    }

#endregion

#region Parte do Bey com nome
    public enum MainBlade
    {
        Antlers,
        Arc,
        Blast,
        Blitz,// (Metal Blade do sistema Expand)
        Brave,
        Brush,
        Dark,
        Delta, //(Metal Blade do sistema Expand)
        Eclipse,
        Fang,
        Flame,
        Fort,
        Fortress, //(Metal Blade do sistema Expand)
        Hunt,
        Might,
        Rage, //(Metal Blade do sistema Expand)
        Reaper,
        Volt,
        Whip, //(Metal Blade do sistema Expand)
        Wriggle,
}

    public enum BladeBX
    {
        DranS,
        HellsS,
        Wizard,
        KnightS,
        KnightL,
        Shark,
        Leon,
        Viper,
        Rhino,
        DranD,
        HellsC,
        PhoenixW,
        Wyvern,
        Unicorn,
        Sphinx,
        Tyranno,
        Weiss,
        Cobalt,
        Black,
        Whale,
        Crimson,
        Shelter,
        Silver,
        PhoenixR
    }
#endregion