using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Reched", menuName = "Scriptable Objects/Reched")]
public class Reched : ScriptableObject
{
    public Sprite image;

    public int height;

    public int number;

    public string color;

    public List<string> Bybeys = new List<string>();
}
