using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Video : MonoBehaviour {

    // Use this for initialization
    public MovieTexture movie;
    AudioSource source;
    List<GameObject> enemys;

	void Start () {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        source = GetComponent<AudioSource>();
        source.clip = movie.audioClip;
        movie.Play();
        source.Play();

        Invoke("completeVideo", 9f);
        
	}
	
	
	void completeVideo () {
        print("acabo video");
	}
}
