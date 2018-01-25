using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_GameManager : MonoBehaviour {

    public static S_GameManager Instance { get; private set; }

    public bool[] responseArray;
	private int goodResponse = 0;

    // Use this for initialization
    void Start ()
    {
        Instance = this;
		CheckVictory ();
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

	public void CheckVictory ()
	{
		goodResponse = 0;
		foreach (bool goodAnswer in responseArray) 
		{
			if (goodAnswer) 
			{
				goodResponse ++;
				Debug.Log ("BIEN JOUE");
			}
		}
		if (goodResponse >= responseArray.Length) 
		{
			Debug.Log ("Voilà t'as gagné");
		}
	}
}
