using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_bullet : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter(Collision collision){
        
        if (collision.collider.CompareTag("pouf"))
        {
            player.transform.position = collision.GetContact(0).point;
        }
        
        if (!collision.collider.CompareTag("Bounce"))
        {
            Destroy(gameObject);
        }
    }
}
