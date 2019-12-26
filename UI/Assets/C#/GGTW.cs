using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GGTW : MonoBehaviour
{
    public int HP = 100;
    public Slider hpslider;

    public Text textInfinityStones;
    public int InfinityStonescount;
    public int InfinityStonesTotal;

    public Text Time_Text;
    float gametime;

    public GameObject final;
    public Text textBest;
    public Text textcurrent;


    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);


        if(other.tag=="陷阱")
        {
            int d = other.GetComponent<TRAP>().damage;
            HP -= d;
            HP -= 10;
            hpslider.value = HP;
            if(HP <= 0) Dead();
        }

        if (other.tag == "寶石")
        {
            InfinityStonescount++;
            textInfinityStones.text = "InfinityStones : " + InfinityStonescount + " / " + InfinityStonesTotal;
            Destroy(other.gameObject);
        }

        if(other.name == "Goal" && InfinityStonescount == InfinityStonesTotal)
        {
            Debug.Log("廢物");
            GameOver();
        }
    
    }

    private void Start()
    {
        if(PlayerPrefs.GetFloat("最佳紀錄") == 0)
        {
            PlayerPrefs.SetFloat("最佳紀錄", 99999);
        }
        InfinityStonesTotal = GameObject.FindGameObjectsWithTag("寶石").Length;
        textInfinityStones.text = "InfinityStones : 0 / " + InfinityStonesTotal;
    }

    private void Update()
    {
        gametime += Time.deltaTime;
        Time_Text.text = "Time : " + gametime.ToString("0.00");
    }

    private void GameOver()
    {
        final.SetActive(true);
        textcurrent.text = "TIME : " + gametime.ToString("0.00");

        if(gametime < PlayerPrefs.GetFloat("最佳紀錄"))
        {
            PlayerPrefs.SetFloat("最佳紀錄", gametime);
        }
        textBest.text = "BEST : " + PlayerPrefs.GetFloat("最佳紀錄").ToString("0.00");

        Time.timeScale = 0.0f;
        Cursor.lockState = CursorLockMode.None;
    }

    void Dead()
    {
        final.SetActive(true);
        textcurrent.text = "TIME : " + gametime.ToString("0.00");

        textBest.text = "BEST : " + PlayerPrefs.GetFloat("最佳紀錄").ToString("0.00");

        Time.timeScale = 0.0f;
        Cursor.lockState = CursorLockMode.None;
        GetComponent<FPSControllerLPFP.FpsControllerLPFP>().enabled = false;
        enabled = false;
    }

    public void RE()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("SAYAJIN");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
