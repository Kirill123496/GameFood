using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Destroy") || collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
