using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
    //public int tokenSpeed = 1;
	// Use this for initialization
    public float rotateSpeed;
	void Start () {
       
	
	}
	
	// Update is called once per frame
    void Update()
    {
        transform.Rotate((new Vector3(15, 30, 45) * Time.deltaTime)*rotateSpeed);
	
	}
}
