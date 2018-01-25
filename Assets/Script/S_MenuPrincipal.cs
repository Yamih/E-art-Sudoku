using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_MenuPrincipal : MonoBehaviour {

	public string LevelToLoad;
	public AudioSource OnClick;

	void Start () {
		
	}

	void Update () {
		
	}

	public void JouerBoutton ()
	{
		this.GetComponent<AudioSource> ();
		SceneManager.LoadScene(LevelToLoad);
	}

	public void QuitterBouton ()
	{
		Application.Quit();
	}
}
