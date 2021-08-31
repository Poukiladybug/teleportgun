using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_jump : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 verticalForce;
    public Vector3 additionalForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Si objet imobile
            // Ajouter force vers le haut
                // Augmenter la force pour le prochain jump
        if (rb.velocity == Vector3.zero){
            rb.AddForce(verticalForce); 
            verticalForce += additionalForce;
        }
        
    }
}
