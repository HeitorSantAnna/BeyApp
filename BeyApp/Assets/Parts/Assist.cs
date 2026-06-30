using UnityEngine;

[CreateAssetMenu(menuName = "BeysParts/Assist Blade")]
public class Assist : Beys
{
    public AssistBlade assistBlade;

    public override string NameP()
    {
        return $"{assistBlade}";
    }
}

public enum AssistBlade
    {
        Assault,
        Bumper,
        Charge,
        Dual,
        Erase,
        Free,
        Gravity,
        Heavy,
        Jaggy,
        Knuckle,
        Massive,
        Odd,
        Round,
        Slash,
        Turn,
        Vertical,
        Wheel,
        Zillion
    }