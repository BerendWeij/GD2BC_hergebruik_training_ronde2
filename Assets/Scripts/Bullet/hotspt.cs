using UnityEngine;
using System.Collections;

public class hotspt : MonoBehaviour, IDestructable
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log(coll.tag);
        if (coll.tag == BulletTags._target)
        {

            coll.GetComponent<IDamageable>().TakeDamage(10);
            Destruct();
        }
    }

    public void Destruct()
    {
        Destroy(this.gameObject);
    }
}
