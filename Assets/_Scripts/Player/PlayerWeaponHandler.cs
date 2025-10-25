using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponHandler : MonoBehaviour
{
    //TODO: multiple weapons managing.

    #region Visible fields
    [SerializeField] private List<Weapon> weapons;
    [SerializeField] private Weapon grenadeWeapon;
    #endregion

    #region Unity events
    private void Update()
    {
        //Here should've been realization of gun switching that doesn't suck
        if (Input.GetMouseButtonDown(0))
            weapons[0].Shoot();

        if(Input.GetKeyDown(KeyCode.G))
            grenadeWeapon.Shoot();
            
    }
    #endregion
}
