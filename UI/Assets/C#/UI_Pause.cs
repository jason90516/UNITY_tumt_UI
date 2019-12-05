using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Pause : MonoBehaviour {
    public Image imagePause;
    public Sprite spritePause, spritePlay;
    [Header("暫停")]
    public bool pause;

    private void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("暫停~");
            pause = !pause;





            imagePause.sprite = pause ? spritePlay : spritePause;
            Time.timeScale = pause ? 0 : 1;
        }
        
    }

	// Use this for initialization
	void Start () {
		
	}

    // 更新:一秒持行約60次
    void Update () {
        Pause();
	}
}
