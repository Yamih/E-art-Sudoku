using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_GameManager : MonoBehaviour {

    public static S_GameManager Instance { get; private set; }

    public bool[] responseArray;
	private int goodResponse = 0;
	public GameObject victoryPanel; 
	public GameObject defeatPanel;

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
			victoryPanel.SetActive (true);
			Debug.Log ("Voilà t'as gagné");
		}

		if (goodResponse < responseArray.Length) 
		{
			defeatPanel.SetActive (true);
			StartCoroutine (GoodByeMyLove ());
			Debug.Log ("Voilà t'as Panel");
		}
	}

	public void EraseAll ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene() .name);
	}

	IEnumerator GoodByeMyLove ()
	{
		yield return new WaitForSeconds (2);
		defeatPanel.SetActive (false);
	}
}
