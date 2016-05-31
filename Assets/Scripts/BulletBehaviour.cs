using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {
	private float deathTimer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		deathTimer += Time.deltaTime;
		transform.Translate (Vector3.forward * Time.deltaTime * 10);

		if (deathTimer > 1) 
		{
			Destroy (this.gameObject);
		}
	}
}
