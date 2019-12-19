using UnityEngine;
using UnityEngine.UI;

public class GGTW : MonoBehaviour
{
    public int HP = 100;
    public Slider hpslider;

    public Text textInfinityStones;
    public int InfinityStonescount;
    public int InfinityStonesTotal;

    public Text Time_Text;
    float TTime;

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);


        if(other.tag=="陷阱")
        {
            int d = other.GetComponent<TRAP>().damage;
            HP -= d;
            HP -= 10;
            hpslider.value = HP;
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
        }
    
    }

    private void Start()
    {
        InfinityStonesTotal = GameObject.FindGameObjectsWithTag("寶石").Length;
        textInfinityStones.text = "InfinityStones : 0 / " + InfinityStonesTotal;
    }

    private void Update()
    {
        TTime += Time.deltaTime;
        Time_Text.text = "Time : " + TTime.ToString("0.00");
    }

}
