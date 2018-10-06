using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour {

    public float speed; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(0, 0, speed);

        //Right
        if (Input.GetKey(KeyCode.RightArrow))
        { this.transform.Translate(Vector3.right); } 

        //Left
        if (Input.GetKey(KeyCode.LeftArrow))
        { this.transform.Translate(Vector3.left); } 

        //Up
        if (Input.GetKey(KeyCode.UpArrow))
        { this.transform.Translate(Vector3.up); } 

        //Down
        if (Input.GetKey(KeyCode.DownArrow))
        { this.transform.Translate(Vector3.down); }

        //Space 
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            GameObject newMissile = GameObject.Instantiate(Resources.Load("Bullets/Missile") as GameObject);

            GameObject Shootpivot = GameObject.Find("Pivot Airplane/ShootPivot");

            newMissile.transform.SetParent(Shootpivot.transform);

            newMissile.transform.localPosition = Vector3.zero;

            newMissile.transform.SetParent(null);

         
    	}
}
}
