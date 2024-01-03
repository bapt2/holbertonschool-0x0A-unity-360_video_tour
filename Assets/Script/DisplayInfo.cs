using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInfo : MonoBehaviour
{
    public GameObject background;

    public bool hover;
    public bool exit;

    public Animator animator;

    public void Enter()
    {
        hover = true;
        animator.SetBool("hover", hover);
    }

    public void Exit()
    {
        hover = false;
        exit = true;
        animator.SetBool("hover", hover);
        animator.SetBool("exit", exit);
        if (background.activeInHierarchy)
        {
            background.SetActive(false);
        }    }

    public void DisplayText()
    {
        if (background.activeInHierarchy)
        {
            background.SetActive(false);
        }
        else
        {
            background.SetActive(true);
        }
    }
}
