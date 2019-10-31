using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControl_AudioControl : MonoBehaviour {

    public AudioMixer AM;
    public Text LoaddingText;
    public Slider loadung;


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

    public void Play()
    {
        SceneManager.LoadScene("Assault_Rifle_01_Demo");

    }
}
