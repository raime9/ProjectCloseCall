using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI ScoreText;
    private void Update()
    {
        ScoreText.text = GameMaster.Instance.GetScore().ToString();
    }
}
