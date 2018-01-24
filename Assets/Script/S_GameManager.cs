using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_GameManager : MonoBehaviour {

    public static S_GameManager Instance { get; private set; }

    public bool[] responseArray;

    // Use this for initialization
    void Start ()
    {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void GoodResponse(int responseIndex)
    {
        if(responseIndex < responseArray.Length)
        {
            responseArray[responseIndex] = true;
        }
        else
        {
            Debug.Log("ERROR ARRAY TOO LOW");
        }
        
    }

    public void BadResponse(int responseIndex)
    {
        if (responseIndex < responseArray.Length)
        {
            responseArray[responseIndex] = false;
        }
        else
        {
            Debug.Log("ERROR ARRAY TOO LOW");
        }
    }
}
