using System;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;


public static class LoadChicken
{
    public static List<GameObject> GetChicken()
    {
        var file = Resources.Load("ClassData") as TextAsset;
        var json = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(file.text);
        
        var chickens = new List<GameObject>();

        foreach (var chicken in json)
        {
            var values = chicken.Value;
            switch (chicken.Key)
            {
                case "Hank":
                    var hank = new GameObject("Hank");
                    setValues(hank.AddComponent<Hank>(), values);
                    chickens.Add(hank);
                    break;    
                case "Merlyn":
                    var merlyn = new GameObject("Merlyn");
                    setValues(merlyn.AddComponent<Merlyn>(), values);
                    chickens.Add(merlyn);
                    break;
                case "Bob":
                    var bob = new GameObject("Bob");
                    setValues(bob.AddComponent<Bob>(), values);
                    chickens.Add(bob);
                    break;
            }
        }

        return chickens;
    }

    private static void setValues(IChicken chicken, Dictionary<string, object> values)
    {
        chicken.Class = (string) values["class"];
        chicken.Skill = (string) values["skill"];
        chicken.Movement = Convert.ToInt32(values["movement"]);
    }
}
