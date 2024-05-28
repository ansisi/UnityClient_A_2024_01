using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioMixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer m_AudioMixer;
    [SerializeField] private Slider m_MusicMasterSlider;
    [SerializeField] private Slider m_MusicBGMSlider;
    [SerializeField] private Slider m_MusicSFXSlider;

    private void Awake()
    {
        m_MusicMasterSlider.onValueChanged.AddListener(SetMasterVolum);
        m_MusicMasterSlider.onValueChanged.AddListener(SetMusicVolum);
        m_MusicMasterSlider.onValueChanged.AddListener(SetSFXVolum);
    }
    public void SetMasterVolum(float volum)
    {
        m_AudioMixer.SetFloat("Master", Mathf.Log10(volum) * 20);
    }
    public void SetMusicVolum(float volum)
    {
        m_AudioMixer.SetFloat("BGM", Mathf.Log10(volum) * 20);
    }
    public void SetSFXVolum(float volum)
    {
        m_AudioMixer.SetFloat("SFX", Mathf.Log10(volum) * 20);
    }
}
