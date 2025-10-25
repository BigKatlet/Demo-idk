using UnityEngine;

public class PlayerInstance : MonoBehaviour
{
    #region Public properties
    public static PlayerInstance Instance { get; private set; }
    #endregion

    #region Unity events
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(this);
            return;
        }

        Instance = this;
    }
    #endregion
}
