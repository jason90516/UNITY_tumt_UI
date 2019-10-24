using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameControl_AudioControl : MonoBehaviour {

    public AudioMixer AM;

	void Start ()
    {
        
	}
	
	void Update ()
    {
		
	}

    public void MasterControl(float volume)
    {
        AM.SetFloat("Master", volume);
    }

    public void BGMControl(float volume)
    {
        AM.SetFloat("BGM", volume);
    }

    public void FSXControl(float volume)
    {
        AM.SetFloat("FSX", volume);
    }
}
