using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamagable
{
    #region Private fields
    private float currentEnemyhealth;
    private EnemyVariation enemyVariaton;
    #endregion

    #region Unity events
    private void Start() => currentEnemyhealth = GetComponent<EnemyVariationHolder>().VariationOfEnemy.MaxHealth;
    #endregion

    #region Public methods
    /// <summary>
    /// Takes damage, destroys enemy if health <= 0.
    /// </summary>
    /// <param name="damageAmount">Amount of damage to deal.</param>
    public void TakeDamage(float damageAmount)
    {
        currentEnemyhealth -= damageAmount;
        if(currentEnemyhealth <= 0)
            Destroy(gameObject);
    }
    #endregion
}
