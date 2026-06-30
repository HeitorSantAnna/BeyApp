using UnityEngine;

[CreateAssetMenu(fileName = "Beys", menuName = "Scriptable Objects/Beys")]
public abstract class Beys : ScriptableObject
{
    public string nameParts;

    public Sprite sprite;

    public int ID;

    public bool IsUx, IsExpend, IsBx;

    public abstract string NameP();
}