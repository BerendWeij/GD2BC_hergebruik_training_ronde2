using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Weaponswitch : MonoBehaviour {
    [SerializeField]private List<string> _Weaponlist;

	// Use this for initialization
	void Start () {
        _Weaponlist.Add("Shotgun");
        _Weaponlist.Add("Rifle");
        _Weaponlist.Add("Pistol");
	
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log(_Weaponlist.GetRandom());
        }
        
	
	}
}
