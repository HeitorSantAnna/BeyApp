using UnityEngine;

[CreateAssetMenu(menuName = "BeysParts/Bit")]
public class Bit : Beys
{
    public SystemBit Sbit;

    public TypeBit typeBit;

    public bool IsSimple;

    public override string NameP()
    {
        if(!IsSimple)
        {
            return $"{Sbit}{nameParts}";
        }
        else
        {
            return $"{Sbit}";
        }
    }
}

public enum SystemBit
{
    Normal,
    Under,
    Flat,
    Gear,
    Free,
    High,
    BitplusReched
}

public enum TypeBit
{
    Ataque,
    Defesa,
    Resistência,
    Equilibrio
}