using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGamePopup : MonoBehaviour
{
    Animator animator;
    bool isActive;

    void Awake()
    {
        animator = GetComponent<Animator>();
        isActive = animator.GetBool("Active");
    }

    public void ChangeBool()
    {
        isActive = !isActive;
        animator.SetBool("Active", isActive);
    }
}
