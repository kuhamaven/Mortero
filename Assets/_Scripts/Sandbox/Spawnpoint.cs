using UnityEngine;
using System.Collections;

public class Spawnpoint : MonoBehaviour {
    public Projectile projectile;
    private Rigidbody rb;
    public Transform spawnpoint;

// Use this for initialization
    void Start()
    {
        rb = projectile.GetComponent<Rigidbody>();
    }

// Update is called once per frame
    void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            var clone = Instantiate(rb, spawnpoint.position, spawnpoint.rotation);
            clone.AddForce(transform.up * 10,ForceMode.VelocityChange);
        }
        
        if(Input.GetKeyDown(KeyCode.Q)){
            var clone = Instantiate(rb, spawnpoint.position, spawnpoint.rotation);
            clone.AddForce(transform.up * 40,ForceMode.VelocityChange);
        }
    }
}