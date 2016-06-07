using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(WaitASec(4.0F));
        
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator WaitASec(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(this.gameObject);
    }
}
