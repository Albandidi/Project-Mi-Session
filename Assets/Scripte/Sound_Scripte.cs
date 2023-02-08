using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_Scripte : MonoBehaviour
{
    [SerializeField] Slider volSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Sound"))
        {
            PlayerPrefs.SetFloat("Sound", 1);
            Loading();        }
    }
    public void Changevol()
    {
        AudioListener.volume = volSlider.value;
        Save();
    }
    private void Loading()
    {
        volSlider.value = PlayerPrefs.GetFloat("Sound");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("Sound", volSlider.value);
    }
}
