using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

    public float motionSpeed;

    public float rotationSpeed; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(0, 0, rotationSpeed);
        this.transform.Translate(Vector3.forward * motionSpeed);

	}

    void OnCollisionEnter (Collision collision)
    {
        Debug.Log("Collision entre dos colliders"); 
             
             GameObject.Destroy(this.gameObject);

        GameObject.Destroy(collision.collider.gameObject);
    }
}
