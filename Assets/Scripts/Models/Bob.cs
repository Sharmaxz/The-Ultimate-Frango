using System;
using UnityEngine;

[Serializable]
public class Bob : MonoBehaviour, IChicken
{
    public string Class { get; set; }
    public string Skill { get; set; }
    public int Movement { get; set; }
}
