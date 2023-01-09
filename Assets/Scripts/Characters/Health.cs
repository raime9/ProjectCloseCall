using CloseCall.Interfaces;
using UnityEngine;

public class Health : MonoBehaviour, IHealth
{
    [SerializeField] int health = 3;
    public void AddHealth(int damage)
    {
        health += damage;
    }

    public int GetHealth()
    {
        return health;
    }

    public void RemoveHealth(int damage)
    {
        health -= damage;
    }
    public override string ToString()
    {
        return $"HP : {health}";
    }
}
