using System;
using UnityEngine;

[System.Serializable]
public class SaveScriptableObject : ScriptableObject
{
    public bool isTutorial;
    public int money;
    public int subscribers;
    public int avgWatchers;

    public void AddMoney(int count)
    {
        money += count;
    }
    
    public void Buy(int count)
    {
        money -= count;
    }
    
}
