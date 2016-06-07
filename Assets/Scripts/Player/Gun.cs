using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    [SerializeField]
    int rng;
    [SerializeField]
    private GameObject Bullet0;
    [SerializeField]
    private GameObject Bullet1;
    [SerializeField]
    private GameObject Bullet2;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SwitchState();
        }
    }
    void SwitchState() {
        rng = Random.Range(0, 4);
        switch (rng)
        {
            case 1:
                print("HandGun");
                HandGun();
                break;
            case 2:
                print("Submachine Gun");
                SubmachineGun();
                break;
            case 3:
                print("Assault Rifle");
                AssaultRifle();
                break;
            case 4:
                print("Shotgun");
                break;
            case 5:
                print("Sniper Rifle");
                break;

            default:
                break;
        }
    }
    void HandGun()
    {
        GameObject bullet = Instantiate(Bullet0, this.transform.forward, Quaternion.identity) as GameObject;
        bullet.transform.SetParent(this.transform);
    }
    void SubmachineGun()
    {
        GameObject bullet = Instantiate(Bullet1, this.transform.forward, Quaternion.identity) as GameObject;
        bullet.transform.SetParent(this.transform);
    }
    void AssaultRifle()
    {
        GameObject bullet = Instantiate(Bullet2, this.transform.forward, Quaternion.identity) as GameObject;
        bullet.transform.SetParent(this.transform);
    }
}
