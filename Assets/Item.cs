using CloseCall.Controls;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] int point = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController pc = collision.transform.GetComponent<PlayerController>();
        if (pc != null)
        {
            pc.AddToBar(point);
            Destroy(this.gameObject);
        }
    }
}
