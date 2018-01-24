using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_CaseVide : MonoBehaviour {

    public int colonne;
    public int ligne;

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
        Debug.Log(input.text);
    }
}
