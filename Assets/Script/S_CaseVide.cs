using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class S_CaseVide : MonoBehaviour {

    public int response;
    public int frameNumber;

	// Use this for initialization
	void Start ()
    {
      
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void SendValue(InputField input)
    {
        if(input.text != "")
        {
            if(Convert.ToInt32(input.text) == response)
            {
                S_GameManager.Instance.GoodResponse(frameNumber);
            }
            else
            {
                S_GameManager.Instance.BadResponse(frameNumber);
            }
        }
        //Debug.Log(Convert.ToInt32(input.text));
    }
}
