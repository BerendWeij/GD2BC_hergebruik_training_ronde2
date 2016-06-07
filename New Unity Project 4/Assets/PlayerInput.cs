using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {
	private PlayerController _pc;

	// Use this for initialization
	void Start () {
		_pc = GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 inputVector = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		_pc.ProcessInput (inputVector);
	}
}
