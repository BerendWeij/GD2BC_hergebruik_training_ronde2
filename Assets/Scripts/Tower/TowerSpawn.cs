using UnityEngine;
using System.Collections;

public class TowerSpawn : MonoBehaviour {

	[SerializeField] private GameObject ManaAmount;
	[SerializeField] private GameObject Tower;
	private GameObject tower;
	
	private bool PlaceTower()
	{
		return tower == null;
	}
	
	void OnMouseUp()
	{
		if(PlaceTower())
		{
			if (ManaAmount.GetComponent<ManaController>().Mana >= 200)
			{            
				tower = (GameObject)
				Instantiate(Tower, transform.position, Quaternion.identity);
				ManaAmount.GetComponent<ManaController>().Mana -= 200;
			}	
		}
	}
}
