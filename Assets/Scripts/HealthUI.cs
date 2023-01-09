using TMPro;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI health;
    private void Update()
    {
        health.text = GameMaster.Instance.GetHealth().ToString();
    }
}
