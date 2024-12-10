using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] TextMeshProUGUI volumeValue;

    [SerializeField] Slider sensitivitySlider;
    [SerializeField] TextMeshProUGUI sensitivityValue;

    [SerializeField] Toggle subtitlesToggle;
    [SerializeField] TextMeshProUGUI subtitlesState;

    [SerializeField] Toggle invertYAxisToggle;
    [SerializeField] TextMeshProUGUI invertXAxisState;

    void Update()
    {
        volumeValue.text = $"{volumeSlider.value}";
        sensitivityValue.text = $"{sensitivitySlider.value}";

        if (subtitlesToggle.isOn)
        {
            subtitlesState.text = "On";
        }
        else
        {
            subtitlesState.text = "Off";
        }

        if (invertYAxisToggle.isOn)
        {
            invertXAxisState.text = "On";
        }
        else
        {
            invertXAxisState.text = "Off";
        }
    }

    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }

    public void Confirm()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
