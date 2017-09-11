using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{

    public string statName;
    public int statBaseValue;
    public int statCurrentValue;


    public Stat(string name, int baseValue)
    {
        statName = name;
        statBaseValue = baseValue;
        statCurrentValue = statBaseValue;
    }

}
