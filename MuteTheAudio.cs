using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteTheAudio : MonoBehaviour
{
  [SerializeField] Slider volumeSlider;

  AudioSource audioSource;
  void Start()
  {
      audioSource = GetComponent<AudioSource>();

      if(!PlayerPrefs.HasKey("musicVolume"))
      {
        PlayerPrefs.SetFloat("musicVolume", 1);
        Load();
      }

      else{
        Load();
      }
  }
  void Update()
  {
      if (Input.GetKeyDown(KeyCode.M))
          audioSource.mute = !audioSource.mute;
  }

public void ChangeVolume()
{
  AudioListener.volume = volumeSlider.value;
  Save();
}

private void Load()
{
  volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
}
  private void Save()
  {
    PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
  }
}
