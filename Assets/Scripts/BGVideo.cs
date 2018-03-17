using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]
public class BGVideo : MonoBehaviour {

	public MovieTexture movie;
	private AudioSource audios;

	// Use this for initialization
	void Start () {
		GetComponent<RawImage>().texture = movie as MovieTexture;
		audios = GetComponent<AudioSource>();
		audios.clip = movie.audioClip;
		movie.Play();
		audios.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
