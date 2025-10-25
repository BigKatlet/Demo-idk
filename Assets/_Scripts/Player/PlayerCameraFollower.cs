using UnityEngine;

public class PlayerCameraFollower : MonoBehaviour
{
    #region Visible private fields
    [SerializeField] private float cameraFollowingSpeed;
    #endregion

    #region Private fields
    private Vector3 smoothDampVelocity = Vector3.zero;

    private Transform playerTransform;
    #endregion

    #region Unity events
    private void Start() => playerTransform = PlayerInstance.Instance.transform;
    private void FixedUpdate() => transform.position = Vector3.SmoothDamp(new Vector3(playerTransform.position.x, playerTransform.position.y, -10), transform.position, ref smoothDampVelocity, cameraFollowingSpeed);
    #endregion
}
