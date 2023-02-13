using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_Scripte : MonoBehaviour
{
    [SerializeField] Slider volSlider;

//------------------------------------------------
    void Start()
    {
        if (PlayerPrefs.HasKey("Sound"))
        {
            PlayerPrefs.SetFloat("Sound", 1);
            Loading();
        }
    }
//-------------------VOL SAVE WHEN YOU CHANGE MENU---------------------------
    public void Changevol()
    {
        AudioListener.volume = volSlider.value;
        Save();
    }
    private void Loading()
    {
        volSlider.value = PlayerPrefs.GetFloat("Sound");
    }
//-------------------SAUVEGARDE DU SON--------------------------------------

    private void Save()
    {
        PlayerPrefs.SetFloat("Sound", volSlider.value);
    }
}
