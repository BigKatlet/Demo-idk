using UnityEngine;

[CreateAssetMenu(fileName = "Weapon variation", menuName = "Weapon variation", order = 71)]
public class WeaponVariation : ScriptableObject
{
    [SerializeField] public bool IsAutomatic;
    [SerializeField] public float Damage;
    [SerializeField] public float ShotSpeed;
    [SerializeField] public GameObject ProjectileGameObject;
}
