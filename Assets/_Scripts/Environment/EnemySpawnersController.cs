using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnersController : MonoBehaviour
{
    #region Public fields
    public static EnemySpawnersController Instance;
    public HashSet<EnemySpawner> EnemySpawners = new();
    #endregion

    #region public properties
    public int enemiesSpawnedTotal {  get; private set; }
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

    #region Public methods
    public void StopAllSpawning()
    {
        foreach (var spawner in EnemySpawners)
        {
            spawner.StopSpawning();
        }
    }
    #endregion
}
