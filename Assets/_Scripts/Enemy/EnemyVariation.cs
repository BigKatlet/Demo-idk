using UnityEngine;

[CreateAssetMenu(fileName = "Enemy variaton", menuName = "Enemy variation", order = 71)]
public class EnemyVariation : ScriptableObject
{
    [SerializeField] public float MovementSpeed;
    [SerializeField] public float MaxHealth;
}
