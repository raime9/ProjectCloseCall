using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class PowerBarUI : MonoBehaviour
{
    [SerializeField] GameObject bar;
    [SerializeField] GameObject[] bars;
    const int MAX_SPAWN = 10;
    int currentBar = 0;
    private void Start()
    {
        bars = new GameObject[10];
        for(int i = 0; i < 10; i++)
        {
            GameObject pointBar = Instantiate(bar, this.transform);
            pointBar.transform.localPosition = Vector3.right * i * 60;
            bars[i] = pointBar;
            pointBar.SetActive(false);
        }
    }
    void SetActiveBar(int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            if (currentBar >= MAX_SPAWN) return;
            bars[currentBar].SetActive(true);
            currentBar++;
        }
    }
    void ResetActiveBars()
    {
        for(int i = 0; i < bars.Length; i++)
        {
            bars[i].SetActive(false);
        }
        currentBar = 0;
    }
}
