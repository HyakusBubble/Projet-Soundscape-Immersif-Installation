using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_oneshot : MonoBehaviour {

    AudioSource m_MyAudioSource;

    // Use this for initialization
    void Start () {
        m_MyAudioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
       m_MyAudioSource.Play();
        Debug.Log("Played");
    }
}
