using UnityEngine;
using UnityEngine.UI;

public class 阿翔 : MonoBehaviour
{
    public int HP = 100;
    public Slider hpslider;

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);


        if(other.tag=="陷阱")
        {
            int d = other.GetComponentsInParent<TRAP>().damage;
            HP -= d;
            HP -= 10;
            hpslider.value = HP;
        }

    }


}
