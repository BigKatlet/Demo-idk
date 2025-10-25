using UnityEngine;

public class Weapon : MonoBehaviour
{
    #region Visible private fields
    [SerializeField] private WeaponVariation weaponVariation;

    [SerializeField] private Transform projectileSpawnPoint;
    #endregion

    #region Public methods
    /// <summary>
    /// Shoots projectile of power set in ScriptableObject, destroys projectile in 5 seconds.
    /// </summary>
    public void Shoot()
    {
        Rigidbody2D projectile = Instantiate(weaponVariation.ProjectileGameObject, projectileSpawnPoint.position, Quaternion.identity).GetComponent<Rigidbody2D>();
        projectile.velocity = projectileSpawnPoint.up * weaponVariation.ShotSpeed;
        Destroy(projectile.gameObject, 5);
    }
    #endregion
}
