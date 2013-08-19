using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {
	
	public bool audioIsPlaying;

	// Use this for initialization
	void Start () {
	
	}
	
void OnClick ()
	{
		if(audio.isPlaying)
		{
			audioIsPlaying = true;
		}
		if(!audioIsPlaying)
		{
			
		Application.LoadLevel("game");
		}
	}
}