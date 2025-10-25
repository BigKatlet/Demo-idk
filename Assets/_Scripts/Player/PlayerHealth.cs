using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamagable
{
    #region Visible private fields
    [SerializeField] private float health;
    #endregion

    #region Public methods
    public void TakeDamage(float damageAmount)
    {
        Debug.LogWarning("ass");
        health -= damageAmount;
        if (health <= 0)
        {
            Debug.Log("U suck bro");
            Destroy(gameObject);
        }
    }
    #endregion
}
