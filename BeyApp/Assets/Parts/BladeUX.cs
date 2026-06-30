using UnityEngine;

[CreateAssetMenu(menuName = "BeysParts/BladeUX")]
public class BladeUX : Beys
{
    public Blade uxBlade;

    public override string NameP()
    {
        switch(uxBlade)
        {
            case Blade.BulletGriffon:
                return "Bullet Griffon";
            case Blade.ClockMirage:
                return "Clock Mirage";
            case Blade.DranBuster:
                return "Dran Buster";
            case Blade.GhostCircle:
                return "Ghost Circle";
            case Blade.GloryValkyrie:
                return "Glory Valkyrie";
            case Blade.GolemRock:
                return "Golem Rock";
            case Blade.HellsHammer:
                return "Hells Hammer";
            case Blade.ImpactDrake:
                return "Impact Drake";
            case Blade.KnightMail:
                return "Knight Mail";
            case Blade.LeonCrest:
                return "Leon Crest";
            case Blade.MeteorDragoon:
                return "Meteor Dragoon";
            case Blade.MummyCurse:
                return "Mummy Curse";
            case Blade.PhoenixFeather:
                return "Pheonix Feather";
            case Blade.PhoenixRudder:
                return "Pheonix Rudder";
            case Blade.PteraSwing:
                return "Ptera Swing";
            case Blade.ScorpioSpear:
                return "Scorpion Spear";
            case Blade.SharkScale:
                return "Shark Scale";
            case Blade.WarriorSaber:
                return "Warrior Saber";
            case Blade.WizardRod:
                return "Wizard Rod";
            default: return "";
        }
    }
}

public enum Blade
    {
        BulletGriffon,
        ClockMirage,
        DranBuster,
        GhostCircle,
        GloryValkyrie,
        GolemRock,
        HellsHammer,
        ImpactDrake,
        KnightMail,
        LeonCrest,
        MeteorDragoon,
        MummyCurse,
        PhoenixFeather,
        PhoenixRudder,
        PteraSwing,
        ScorpioSpear,
        SharkScale,
        WarriorSaber,
        WizardRod
    }