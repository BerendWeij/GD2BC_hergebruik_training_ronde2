using UnityEngine;
using System.Collections;

public class TowerShoot : MonoBehaviour 
{

	private TowerTarget towerTarget;
	[SerializeField] private GameObject Bullet;
	private float Shoot;
	private float FireRate = 1f;

	void Awake()
	{
		towerTarget = GetComponent<TowerTarget>();
	}
	void Update()
	{
	  if (towerTarget.GetTarget () != null) 
	  {
		if (Shoot <= Time.time)
			{
				Fire ();
		    }
	   }
	}
	private void Fire()
	{
		GameObject bullet = Instantiate (Bullet, this.transform.position, Quaternion.identity) as GameObject;
		bullet.GetComponent<Bullet>().SetLocation(towerTarget.GetTarget().transform.position);
		bullet.transform.SetParent (this.transform);
		Shoot = Time.time + FireRate;
	}
}