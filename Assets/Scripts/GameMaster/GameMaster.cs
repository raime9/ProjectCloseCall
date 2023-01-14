using UnityEngine;

namespace CloseCall.Core
{
    public class GameMaster : MonoBehaviour
    {
        public static GameMaster Instance { get; private set; }
        [SerializeField] Health playerController;
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
            }
        }
        public Health GetHealth()
        {
            return playerController;
        }
        public Score GetScore()
        {
            return Score;
        }
    }
}
