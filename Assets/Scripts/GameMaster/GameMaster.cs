using CloseCall.Controls;
using UnityEngine;

namespace CloseCall.Core
{
    public class GameMaster : MonoBehaviour
    {
        public static GameMaster Instance { get; private set; }
        [SerializeField] PlayerController playerController;
        [SerializeField] Score Score;
        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
                playerController = GetComponentInChildren<PlayerController>();
            }
        }
        public Health GetHealth()
        {
            return playerController.GetHealthSystem();
        }
        public PowerUp GetPowerUpSystem()
        {
            return playerController.GetPowerSystem();
        }
        public Score GetScore()
        {
            return Score;
        }
    }
}
