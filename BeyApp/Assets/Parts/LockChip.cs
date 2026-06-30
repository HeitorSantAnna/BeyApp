using UnityEngine;

[CreateAssetMenu(menuName = "BeysParts/Lock Chip")]
public class LockChips : Beys
{
    public LockChip lockChip;

    public override string NameP()
    {
    return $"{lockChip}";
    }
}

public enum LockChip
    {
        Bahamut,
        Brachio,
        Bucks,
        Cerberus,
        Dran,
        Drake,
        Emperor,
        Fox,
        Hells,
        Hornet,
        Knight,
        Kraken,
        Leon,
        Pegasus,
        Perseus,
        Phoenix,
        Ragna,
        Rhino,
        Sol,
        Unicorn,
        Valkyrie,
        Whale,
        Wizard,
        Wolf
    }