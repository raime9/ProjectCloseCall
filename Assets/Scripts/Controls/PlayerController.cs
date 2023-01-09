using CloseCall.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Health PlayerObject;
    private void Update()
    {
        LookAtMouseRotation();
    }

    private void LookAtMouseRotation()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePosition - PlayerObject.transform.position;
        float rotationZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        PlayerObject.transform.rotation = Quaternion.Euler(0, 0, rotationZ);
        PlayerObject.transform.localPosition = Vector3.Lerp(PlayerObject.transform.position, new Vector3(mousePosition.x, mousePosition.y, 0), 10f * Time.deltaTime);
    }
    public IHealth GetPlayer()
    {
        if (PlayerObject == null) return null;
        return PlayerObject;
    }
}
