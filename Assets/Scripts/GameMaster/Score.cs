using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    float level = 1f;
    float score = 0;
    public static Score Instance { get; private set; }
    public Score()
    {
        if(Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }
    public void AddScore(int i)
    {
        score += i;
    }
    public void AddLevel()
    {
        level++;
    }
    public void ResetScore()
    {
        score = 0;
    }
    private void Update()
    {
        score += Time.deltaTime * level;
    }
    public override string ToString()
    {
        return $"Score : {(int)score}";
    }
}
