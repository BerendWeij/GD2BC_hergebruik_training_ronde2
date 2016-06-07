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
		TimeAlive += 0.25f * Time.deltaTime;
	}
	private void Move()
	{
		this.transform.position = Vector2.MoveTowards(this.transform.position, TargetPos, 12f * Time.deltaTime);

		if(TimeAlive >= 0.8f)
		{
			Destroy(this.gameObject);
		}
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Ik hit: " + col.gameObject.name);
    }
}