using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {


	public AudioClip[] levelMusicChangeArray;
	
	private AudioSource audioSource;
	// Use this for initialization
	
	
	void Awake(){
		DontDestroyOnLoad(gameObject);
		Debug.Log("Don't destroy on load: " + name);
	
	}
	
	void Start () {
		audioSource = GetComponent<AudioSource>();
	
	}
	
	void OnLevelwasLoaded(int level){
		Debug.Log("Playing Clip"+levelMusicChangeArray[level]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
