using UnityEngine;

/// <summary>
/// Deals damage on collision with objects. Destroys itself anyway.
/// </summary>
public class ProjectileScript : MonoBehaviour
{

    #region Visible private fields
    [SerializeField] private ProjectileVariation projectileVariation;
    #endregion

    #region Private fields
    private float projectileDamage;
    #endregion

    #region Unity events
    private void Start() => projectileDamage = projectileVariation.ProjectileDamage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDamagable damagable))
            damagable.TakeDamage(projectileDamage);
        Destroy(gameObject);
    }
    #endregion
}
