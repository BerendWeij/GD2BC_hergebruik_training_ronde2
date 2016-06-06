using UnityEngine;
using System.Collections;

public class DestroyObjectOverTime : MonoBehaviour
{
    [SerializeField]private float _destroyTime;
	// Use this for initialization
	void Start()
	{
        StartCoroutine(DestroyObject());
	}
	
	IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(_destroyTime);
        Destroy(this.gameObject);
    }
}