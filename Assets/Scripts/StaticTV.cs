using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTV : MonoBehaviour
{
    [SerializeField] private GameObject[] screens;
    [SerializeField] private float switchTimer = 1f;
    private float timer = 0f;
    [SerializeField] private float increment = 0.01f;
    private int index = 0;
    // Update is called once per frame

    void Start()
    {
        for (int i=1; i<screens.Length; i++)
        {
            screens[i].SetActive(false);
        }
    }

    void Update()
    {
        //timer = timer >= switchTimer ? 0f : timer + increment;
        if (timer >= switchTimer)
        {
            timer = 0f;
            index = (index + 1) % screens.Length;
            for (int i = 0; i < screens.Length; i++)
            {
                if (i == index)
                {
                    screens[i].SetActive(true);
                }
                else
                {
                    screens[i].SetActive(false);
                }
            }
       
        }
        else
        {
            timer += increment;
        }
       
        
    }
}
