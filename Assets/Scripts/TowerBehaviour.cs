using UnityEngine;
using System.Collections;

public class TowerBehaviour : MonoBehaviour {

	[SerializeField] private GameObject _target;
	[SerializeField] private GameObject _Bullet;

	void Update () {
		CheckDistance ();	
	}

	void CheckDistance()
	{
		float distanceTo = (_target.transform.position - transform.position).magnitude; 
		transform.LookAt (_target.transform);


		if (distanceTo < 10f) 
		{
			Shooting ();
		}
	}

	void Shooting()
	{
		Instantiate (_Bullet, transform.position,transform.rotation);

	}
}
