using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _movement;
    private PlayerWeapons _playerWeapons;

	void Awake()
	{
        _movement = GetComponent<PlayerMovement>();
        _playerWeapons = GetComponent<PlayerWeapons>();
	}

	void Update()
	{
        //Move Left
		if(Input.GetKey(KeyCode.A))
        {
            _movement.MoveLeft();
        }

        //Move Right
        if (Input.GetKey(KeyCode.D))
        {
            _movement.MoveRight();
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            _playerWeapons.SwitchWeapon();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            _playerWeapons.CurrentWeapon.Reload();
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            _playerWeapons.CurrentWeapon.Shoot();
        }
	}
}