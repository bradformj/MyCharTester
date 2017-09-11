using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

    public Dictionary<string, Stat> characterStats;

    public Stat toughness = new Stat("toughness", 100);
    public Stat presence = new Stat("presence", 1000);

    // Use this for initialization
	void Awake () {

        characterStats = new Dictionary<string, Stat>();

        characterStats.Add(toughness.statName, toughness);
        characterStats.Add(presence.statName, presence);
 
    }

}
