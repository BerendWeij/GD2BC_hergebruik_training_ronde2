using UnityEngine;
using System.Collections;

public class WeaponBase : MonoBehaviour {
	[SerializeField]protected GameObject _bullet;
	[SerializeField]protected Transform _nozzle;
	[SerializeField]protected float _reloadTime;
}
