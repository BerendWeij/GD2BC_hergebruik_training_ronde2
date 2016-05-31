using UnityEngine;
using System.Collections;

public class TowerTarget : MonoBehaviour {
	
	public GameObject target;
	[SerializeField] private float targettingRadius;
	private int layerMask;
	private float closestTarget;

	void Start()
	{
		layerMask = LayerMask.GetMask ("Enemy");
	}
	// Update is called once per frame
	void Update () 
	{
		Collider2D[] col = Physics2D.OverlapCircleAll(this.transform.position, targettingRadius, layerMask);
		if (col.Length > 0 && col != null) 
		{
			Collider2D Nearby = null;
			float Distance = -1f;
			for (int i = 0; i < col.Length; i++) 
			{
				if (col[i].tag == "Enemy") 
				{
					float distance = Vector2.Distance (col [i].transform.position, this.transform.position);
					if (Distance == -1f) 
					{
						Distance = distance;
						Nearby = col [i];
					} else 
					{
						if (distance < Distance)
						{
							Nearby = col [i];
							Distance = distance;
						}
					}
					if (Nearby != null)
					{
						target = Nearby.transform.gameObject;
					} else
					{
						target = null;
					}
				}
			}
		} else {
			   target = null;
		  }
		}
	void OnDrawGizmos()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere (this.transform.position, targettingRadius);
	}
	public GameObject GetTarget()
	{
		if (target){
			return target;
		} else 
		{
			return null;
		}
	}
}