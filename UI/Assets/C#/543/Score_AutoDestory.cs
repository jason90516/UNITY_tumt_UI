using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_AutoDestory : MonoBehaviour {

    public GameObject OBJ;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(OBJ == null)
        {
            Destroy(gameObject);
        }

	}
}
