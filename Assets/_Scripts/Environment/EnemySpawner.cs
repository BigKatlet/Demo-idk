using System.Collections;
using UnityEngine;

/// <summary>
/// Should be assigned to spawner object. Spawns enemy in coordinates of parent object.
/// </summary>
public class EnemySpawner : MonoBehaviour
{
    //TODO: multiple enemies support.

    #region Public properties
    public bool IsAbleToSpawn { get; set; } = true;
    #endregion

    #region Visible private fields
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float enemySpawnDelay;
    #endregion

    #region Private fields
    private Coroutine spawningCoroutine;
    #endregion

    #region Unity events
    private void Start() 
    {
        EnemySpawnersController.Instance.EnemySpawners.Add(this);
        spawningCoroutine = StartCoroutine(StartSpawning());
    }
    #endregion

    #region Private methods
    private IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(enemySpawnDelay);

        if (IsAbleToSpawn) Instantiate(enemyPrefab, transform.position, Quaternion.identity);

        StartCoroutine(StartSpawning());
    }
    #endregion

    #region Public methods
    public void StopSpawning()
    {
        if (spawningCoroutine == null)
            return;

        StopCoroutine(spawningCoroutine);
        spawningCoroutine = null;
    }
    #endregion
}
