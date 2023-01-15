using CloseCall.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class PowerBarUI : MonoBehaviour
{
    [SerializeField] GameObject bar;
    [SerializeField] GameObject[] bars;
    const int MAX_SPAWN = 10;
    int currentCounter = 0;
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
        GameMaster.Instance.GetPowerUpSystem().OnScoreUpdate += SetActiveBar;
    }
    void SetActiveBar(int amount)
    {
        for(int i = 0; i < bars.Length; i++)
        {
            if(i < amount)
            {
                bars[i].SetActive(true);
                bars[i].GetComponentInChildren<TextMeshProUGUI>().text = $"{i + 1}";
            }
            else
            {
                bars[i].SetActive(false);
            }
        }
    }
}
