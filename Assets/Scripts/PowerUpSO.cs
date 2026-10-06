using UnityEngine;

[CreateAssetMenu(fileName = "PowerUpSO", menuName = "PowerUpSO")]
public class PowerUpSO : ScriptableObject
{
    [SerializeField] string powerUpType;
    [SerializeField] float valueChange;
    [SerializeField] float time;
}
