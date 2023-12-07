using UnityEngine;
using UnityEngine.UI;

public class BuySlowMotion : MonoBehaviour

{
    private void Start()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("SlowMotionScore").ToString();
    }
    
}
