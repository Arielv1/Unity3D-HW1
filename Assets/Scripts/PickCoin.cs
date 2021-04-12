using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickCoin : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject coin;
    public static int goldAmount = 0;
    public int goldIncrementAmount = 15;
    public Text goldText;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player" && coin.activeSelf)
        {
            goldAmount += goldIncrementAmount;
            Debug.Log("goldAmount: " + goldAmount);
            goldText.GetComponent<Text>().text = "Gold: " + goldAmount;
            audioSource.Play();
            coin.SetActive(false);
        }
    }

}
