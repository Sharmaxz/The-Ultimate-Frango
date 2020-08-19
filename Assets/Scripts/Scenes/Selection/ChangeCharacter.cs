using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    public int selected = 0;
    public List<GameObject> chickens;
    
    [Header("Texts")]
    public TextMeshProUGUI charText;
    public TextMeshProUGUI classText;
    public TextMeshProUGUI skillText;
    public TextMeshProUGUI speedText;


    public void Awake()
    {
        chickens = LoadChicken.GetChicken();
    }

    public void Start()
    {
        var chicken = chickens[0].GetComponent<IChicken>();
        UpdateText(chicken);
    }

    private void UpdateText(IChicken chicken)
    {
        charText.text = chicken.GetType().Name;
        classText.text = $"Class\n {chicken.Class}";
        skillText.text = $"Skill\n {chicken.Skill}";
        speedText.text = $"Speed\n {chicken.Movement}";
    }

    public void OnNext()
    {
        var index = selected + 1 < chickens.Count ? selected + 1 : 0;
        var chicken = chickens[index].GetComponent<IChicken>();

        selected = index;
        UpdateText(chicken);
    }
    
    public void OnBack()
    {
        var index = selected - 1 > -1  ? selected - 1 : chickens.Count - 1;
        var chicken = chickens[index].GetComponent<IChicken>();
        
        selected = index;
        UpdateText(chicken);
    }
}
