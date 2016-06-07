using UnityEngine;
using System.Collections;

public class PlayerAI : MonoBehaviour {

    private bool _walkingRight;

    void Start()
    {
        StartCoroutine(RandomDirection());
    }
	// Update is called once per frame
	void Update () {
        if (_walkingRight)
            transform.Translate(Vector2.right * Time.deltaTime);
        else
            transform.Translate(Vector2.left * Time.deltaTime);
	}

    IEnumerator RandomDirection()
    {
        GetRandomDirection();
        yield return new WaitForSeconds(Random.Range(1, 3));
        StartCoroutine(RandomDirection());
    }

    private void GetRandomDirection()
    {
        if (Random.value >= 0.5f)
        {
            _walkingRight = true;
        }
        else
        {
            _walkingRight = false;
        }
    }
}
