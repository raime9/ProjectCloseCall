using CloseCall.Core;
using TMPro;
using UnityEngine;

namespace CloseCall.UI
{
    public class ScoreUI : MonoBehaviour
    {

        [SerializeField] TextMeshProUGUI ScoreText;
        private void Update()
        {
            ScoreText.text = GameMaster.Instance.GetScore().ToString();
        }
    }
}
