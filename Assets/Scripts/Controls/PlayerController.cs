using CloseCall.Interfaces;
using UnityEngine;

namespace CloseCall.Controls
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] Health PlayerObject;
        private void Update()
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Rotation(mousePosition);
            Movement(mousePosition);
        }
        private void Movement(Vector3 mousePosition)
        {
            //moves player across field
            PlayerObject.transform.position = Vector3.Lerp(PlayerObject.transform.position, new Vector3(mousePosition.x, mousePosition.y, 0), 10f * Time.deltaTime);
        }

        private void Rotation(Vector3 mousePosition)
        {

            Vector3 rotation = mousePosition - PlayerObject.transform.position;
            float rotationZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            //rotations player object
            PlayerObject.transform.rotation = Quaternion.Euler(0, 0, rotationZ);

        }
        public IHealth GetPlayer()
        {
            if (PlayerObject == null) return null;
            return PlayerObject;
        }
    }
}

