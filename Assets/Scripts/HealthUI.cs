using CloseCall.Core;
using TMPro;
using UnityEngine;

namespace CloseCall.UI
{
    public class HealthUI : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI health;
        private void Update()
        {
            health.text = GameMaster.Instance.GetHealth().ToString();
        }
    }
}
