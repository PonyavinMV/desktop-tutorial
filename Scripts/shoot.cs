using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject player;
    public float damage;
    public float fireRate;
    public int ammo;
    public GameObject bullet;
    public Camera _cam;
    public float range  = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
           
            Shoot();

        }
        //    
    }
    void Shoot()
    {
       
        if (Physics.Raycast(ray,out hit))
        {

            hit.rigidbody.AddForceAtPosition(ray.direction * range, hit.point, ForceMode.Acceleration);
            Instantiate(bullet, hit.point, transform.rotation);
        }
        Debug.Log("Пиу пиу" + hit.collider);
        

    }
}
