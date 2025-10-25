using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    #region Private fields
    private Camera playerCamera;
    #endregion

    #region Unity events
    private void Start() => playerCamera = Camera.main;

    private void Update()
    {
        Vector3 mousePos = playerCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePos - transform.position).normalized;
        transform.up = direction;
    }
    #endregion
}
