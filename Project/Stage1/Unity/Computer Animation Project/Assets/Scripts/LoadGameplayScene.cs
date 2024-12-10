using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameplayScene : MonoBehaviour
{
    [SerializeField] int gameplayIndex;
    [SerializeField] float animationTime;

    void Awake()
    {
        StartCoroutine(AnimationTimer());
    }

    IEnumerator AnimationTimer()
    {
        yield return new WaitForSeconds(animationTime);
        SceneManager.LoadScene(gameplayIndex);
    }
}
