using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	private float TimeAlive;
	private Vector2 TargetPos;
	
	// Use this for initialization
	void Start () {
		
	}
	public void SetLocation(Vector2 position)
	{
		TargetPos = position;
	}
	// Update is called once per frame
	void Update ()
	{	
		Move ();
		TimeAlive += 1f * Time.deltaTime;
	}
	private void Move()
	{
		this.transform.position = Vector2.MoveTowards(this.transform.position, TargetPos, 12f * Time.deltaTime);

		if(TimeAlive >= 0.8f)
		{
			Destroy(this.gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			col.GetComponent<EnemyHp>().HpManager();
			Destroy(this.gameObject);
		}
	}
	
}