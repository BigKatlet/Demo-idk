using System.Collections;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    #region Visible private fields
    [SerializeField] private float damage;
    #endregion

    #region Private fields
    private bool isAbleToAttack = true;
    #endregion

    #region Unity methods
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerHealth playerHealth) && isAbleToAttack)
        {
            playerHealth.TakeDamage(damage);
            StartCoroutine(AttackCooldown());
        }
    }
    #endregion

    #region Private methods
    private IEnumerator AttackCooldown()
    {
        isAbleToAttack = false;
        yield return new WaitForSeconds(1);
        isAbleToAttack = true;
    }
    #endregion
}
