using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    Animator animator;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject optionsMenu;
    [SerializeField] GameObject prototype;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void ChangeScreen()
    {
        StartCoroutine(AnimationTimer());
    }

    IEnumerator AnimationTimer()
    {
        animator.SetTrigger("CLICKED");
        yield return new WaitForSeconds(0.34f);
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
        prototype.SetActive(true);
        GetComponent<RectTransform>().anchoredPosition = new Vector3(34.20407f, 15, 0);
    }
}
