using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private CharacterController _cc;
	private PlayerHealth _ph;

	private float _health = 20;

	//Movement Modifiers
	[SerializeField]float moveSpeed = 5;
	// Use this for initialization
	void Start () {
		_cc = GetComponent<CharacterController> ();
		_ph = GetComponent<PlayerHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ProcessInput(Vector3 moveDir){
		_cc.Move (moveDir * moveSpeed * Time.deltaTime);
	}

	public void TakeDamage(int damageAmount){
		_ph.health = _ph.health - damageAmount;
		Debug.Log (_ph.health);
		if (_ph.health <= 0) {
			Destroy (this.gameObject);
		}
	}
}
