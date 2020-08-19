using System;
using UnityEngine;

[Serializable]
public class Hank : MonoBehaviour, IChicken
{
    public string Class { get; set; }
    public string Skill { get; set; }
    public int Movement { get; set; }
}
