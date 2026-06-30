using UnityEngine;

[CreateAssetMenu(menuName = "BeysParts/Over Blade")]
public class Over : Beys
{
    public OverBlade overBlade;

    public override string NameP()
    {
        switch(overBlade)
        {
            case OverBlade.Break:
                return "Break";
            case OverBlade.Flow:
                return "Flow";
            case OverBlade.Guard:
                return "Guard";
            case OverBlade.Outer:
                return "Outer";
            case OverBlade.Peak:
                return "Peak";
            default: return "";
        }
    }
}

public enum OverBlade
    {
        Break,
        Flow,
        Guard,
        Outer,
        Peak
    }