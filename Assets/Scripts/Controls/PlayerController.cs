using CloseCall.Interfaces;
using UnityEngine;

namespace CloseCall.Controls
{
    public class PlayerController : MonoBehaviour, IPowerUp
    {
        [SerializeField] Health PlayerHealth;
        [SerializeField] PowerUp powerUpSystem;
        private void Awake()
        {

            powerUpSystem = GetComponentInChildren<PowerUp>();
            PlayerHealth = GetComponentInChildren<Health>();
        }
        private void Update()
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Rotation(mousePosition);
            Movement(mousePosition);
        }
        private void Movement(Vector3 mousePosition)
        {
            //moves player across field
            transform.position = Vector3.Lerp(transform.position, new Vector3(mousePosition.x, mousePosition.y, 0), 10f * Time.deltaTime);
        }

        private void Rotation(Vector3 mousePosition)
        {

            Vector3 rotation = mousePosition - transform.position;
            float rotationZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            //rotations player object
            transform.rotation = Quaternion.Euler(0, 0, rotationZ);

        }
        public Health GetHealthSystem()
        {
            return PlayerHealth;
        }
        public PowerUp GetPowerSystem()
        {
            return powerUpSystem;
        }
        public void AddToBar(int i)
        {
            powerUpSystem.AddToBar(i);
        }
    }
}

