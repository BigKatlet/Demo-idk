using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    #region Private fields
    private float enemyMovementSpeed;
    private Vector3 movementVelocity = Vector3.zero;

    private Transform playerTransform;

    private Rigidbody2D enemyRigidibody2D;
    #endregion

    #region Unity events
    private void Start()
    {
        playerTransform = PlayerInstance.Instance.transform;
        enemyMovementSpeed = GetComponent<EnemyVariationHolder>().VariationOfEnemy.MovementSpeed;
        enemyRigidibody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() => enemyRigidibody2D.velocity = (playerTransform.position - transform.position).normalized * Time.fixedDeltaTime * enemyMovementSpeed;
    #endregion
}
