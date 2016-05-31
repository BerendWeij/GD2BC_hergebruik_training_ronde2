using UnityEngine;
using System.Collections;

public class ShootingWithWeapons : MonoBehaviour {


	void Update()
	{
		if (Input.GetKeyDown ("space")) {
			int random = Random.Range (1, 3);

			if (random == 1) {
				MiniGun ();
			}
			if (random == 2) {
				Flamer ();
			} else {
				Bazooka ();
			}
		}
	}
	void MiniGun()
	{
		Debug.Log ("MINININININININIININNININI Gun");

	}
	void Flamer()
	{
		Debug.Log ("WGGUUUUUUUUUUUUUUGUGUGUUGUUGUUHHHHHHHHHs");

	}
	void Bazooka()
	{
		Debug.Log ("Boem");	
	}
}
