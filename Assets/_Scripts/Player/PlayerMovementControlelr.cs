using System.Collections;
using UnityEngine;

#region Requirements
[RequireComponent(typeof(Rigidbody2D))]
#endregion
public class PlayerMovementControlelr : MonoBehaviour
{

    #region Visible private fields
    [SerializeField] private float playerMovementMaxSpeed;

    [SerializeField] private float playerJumpSpeed;
    [SerializeField] private float playerJumpDuration;
    [SerializeField] private float playerJumpDelay;
    #endregion

    #region Private fields
    private Rigidbody2D playerRigibdody2D;

    private float playerMovementSpeed;

    private bool canJump = true;
    #endregion

    #region Unity Events
    private void Start()
    {
        playerRigibdody2D = GetComponent<Rigidbody2D>();
        playerMovementSpeed = playerMovementMaxSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 movement = new(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        playerRigibdody2D.velocity = ((movement.magnitude > 1f) ? movement.normalized : movement) * playerMovementSpeed * Time.fixedDeltaTime;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            StartCoroutine(Jump());
    }
    #endregion

    #region Private methods
    private IEnumerator Jump()
    {
        if (!canJump) yield break;

        playerMovementSpeed = playerJumpSpeed;
        yield return new WaitForSeconds(playerJumpDuration);
        playerMovementSpeed = playerMovementMaxSpeed;

        canJump = false;
        yield return new WaitForSeconds(playerJumpDelay);
        canJump = true;
    }
    #endregion
}
