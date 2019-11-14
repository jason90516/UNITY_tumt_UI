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


    void Start()
    {

    }

    void Update()
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
        //     SceneManager.LoadScene("Assault_Rifle_01_Demo");
        StartCoroutine(Change());
    }

    IEnumerator Change()
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync("Assault_Rifle_01_Demo");
        ao.allowSceneActivation = false;
        while (ao.isDone == false)
        {
            LoaddingText.text = ((ao.progress / 0.9f) * 100).ToString();
            loadung.value = ao.progress / 0.9f;
            yield return new WaitForSeconds(0.001f);

        if(ao.progress == 0.9f)
        {
            ao.allowSceneActivation = true;
    
        }
        }

    }

}
     
