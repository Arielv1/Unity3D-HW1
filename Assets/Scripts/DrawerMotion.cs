using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerMotion : MonoBehaviour
{
    Animator animator;
    bool isDrawerClosed;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isDrawerClosed = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        animator.SetBool("open", isDrawerClosed);
        isDrawerClosed = !isDrawerClosed;
        

    }
}
