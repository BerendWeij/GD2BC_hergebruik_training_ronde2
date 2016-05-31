using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    [SerializeField]
    private Slider healthSlider;
    private float _fillAmount;
    private int PlayerHP = 100;
    void Start()
    {
        healthSlider.value = PlayerHP;
    }

    void OnCollisionEnter(Collision coll)
      {
        if (coll.gameObject.tag == "Bullet")
        {
            Destroy(coll.gameObject);
            PlayerHP = PlayerHP - 10;
            healthSlider.value = PlayerHP;
            
        }
      }
    }
