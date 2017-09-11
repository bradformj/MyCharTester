using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public CharacterStats stats;

	// Use this for initialization
	void Start () {

        stats = GetComponent<CharacterStats>();

        foreach(KeyValuePair<string, Stat> statPair in stats.characterStats)
        {
            Debug.Log(statPair.Key + " stat's value is " + statPair.Value.statCurrentValue);
        }
    }

}
