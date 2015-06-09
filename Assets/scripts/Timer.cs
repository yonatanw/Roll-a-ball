using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
    public int gameTime = 10;
    public GameObject other;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.fixedTime>gameTime)
        {
            Debug.Log("time is up");
            Destroy(other);
            
        }	
	
	}
}
