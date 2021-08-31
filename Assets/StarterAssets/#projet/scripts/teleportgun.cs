using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class teleportgun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletOriginTransform;
    public float bulletSpeed = 10f;
    public GameObject playerRef;
// On peut aussi essayer de le faire avec une var GameObject à la place

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnShoot (InputValue value){
        if (value.isPressed){
            Shoot();
        }
    }
    void Shoot(){
        GameObject newBullet = Instantiate(bulletPrefab, bulletOriginTransform.position, bulletOriginTransform.rotation);
        Rigidbody bulletRigidbody = newBullet.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = bulletOriginTransform.forward * bulletSpeed;
        Teleport_bullet tpBullet = newBullet.GetComponent<Teleport_bullet>();
        tpBullet.player = playerRef;
    }
}
