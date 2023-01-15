using CloseCall.Core;
using TMPro;
using UnityEngine;

namespace CloseCall.UI
{
    public class HealthUI : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI health;
        private void Start()
        {
            GameMaster.Instance.GetHealth().OnHealthUpdate += UpdateUI;
            UpdateUI();
        }
        private void UpdateUI()
        {
            health.text = GameMaster.Instance.GetHealth().ToString();
        }
    }
}
