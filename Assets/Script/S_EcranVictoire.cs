using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_EcranVictoire : MonoBehaviour {

	public string levelToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void QuitButton ()
	{
		SceneManager.LoadScene(levelToLoad);
	}
}
