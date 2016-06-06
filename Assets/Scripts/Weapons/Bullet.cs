using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    private float   _damage;
    public  float   Damage
    {
        set
        {
            _damage = value;
        }
    }
    private float   _range;
    public  float   Range
    {
        set
        {
            _range = value;
        }
    }
    

	void Update ()
    {
        transform.Translate(Vector2.up * (_range * 0.1f) * Time.deltaTime);
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collided");
        col.gameObject.SendMessage("TakeDamage", _damage, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
