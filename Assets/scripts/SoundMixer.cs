using UnityEngine;
using UnityEngine.Audio;

public class SoundMixer : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void SetMasterVolume(float level)
	{
		audioMixer.SetFloat("MasterVolume", Mathf.Log10(level) * 20f);
	}

	public void SetSoundFXVolume(float level)
	{
		audioMixer.SetFloat("SoundMaster", Mathf.Log10(level) * 20f);
	}


	public void SetMusicVolume(float level)
	{
		audioMixer.SetFloat("MusicMaster", Mathf.Log10(level) * 20f);
	}
}
