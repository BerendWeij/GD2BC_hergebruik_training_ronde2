using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {
	private float attackSpeed = .75f;
	private float timeStamp;
	[SerializeField]LineRenderer _attackLine;
	[SerializeField]private PlayerController _target;
	[SerializeField]private GameObject _aimer;
	[SerializeField]private GameObject _muzzle;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (_target != null) {
			_aimer.transform.LookAt (_target.transform);
			if (Time.time >= timeStamp) {
				timeStamp = Time.time + attackSpeed;
				//attack here
				_target.TakeDamage(1);
				_attackLine.SetPosition(0,_muzzle.transform.position);
				_attackLine.SetPosition(1,_target.transform.position);
			}
		} else {
		}
	}

	void OnTriggerEnter(Collider obj){
		if (obj.tag == "Player") {
			_target = obj.gameObject.GetComponent<PlayerController> ();
		}
	}
	void OnTriggerExit(Collider obj){
		if (obj.tag == "Player") {
			_target = null;
		}
	}
}
