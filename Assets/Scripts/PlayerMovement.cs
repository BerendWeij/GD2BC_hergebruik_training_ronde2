using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {

	[SerializeField] private float _speed = 2;
	public float hp = 100;
	private Rigidbody _rb;

	private float _healthBarLength;
	// Use this for initialization
	void Start () {
		_healthBarLength = Screen.width / 2;
		_rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		Movement ();

	}
	void OnTriggerEnter(Collider coll)
	{
		if (coll.tag == "Bullet") 
		{
			hp--;
		}
	}
	void Movement()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		_rb.AddForce (movement * _speed);
	}

	void OnGUI()
	{
		GUI.BeginGroup (new Rect (0, 0, _healthBarLength, 32));
		GUI.Box (new Rect (0, 0, _healthBarLength, 32),"");
		GUI.BeginGroup (new Rect (0, 0, hp / 100 * _healthBarLength, 32));
		GUI.Box (new Rect (0, 0, _healthBarLength, 32), "Supp madafuckers");
		GUI.EndGroup ();
		GUI.EndGroup ();

	}
}
