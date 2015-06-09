using UnityEngine;
using System.Collections;

public class CheckifWinagain : MonoBehaviour {
    public static int totalscore = 0;
    public int goal = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        totalscore = PlayerController.collectedCoins;
        if (totalscore>goal)
        {
            Debug.Log("WIN!");  
        }
        
        //Debug.Log("total score is: " + totalscore);
	
	}
}
