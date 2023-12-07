using UnityEngine.UI;
using UnityEngine;

public class CountCoins : MonoBehaviour {
    private void Start()
    {
       //PlayerPrefs.SetInt("Coins", 2000);
        GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
    }
}
