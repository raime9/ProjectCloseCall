using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour, IPowerUp
{
    [SerializeField] int power = 0;
    public Action<int> OnScoreUpdate;
    public void AddToBar(int i)
    {
        power += i;
        OnScoreUpdate?.Invoke(power);
    }
}
