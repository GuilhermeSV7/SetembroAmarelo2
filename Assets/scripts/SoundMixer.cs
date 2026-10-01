using UnityEngine;
using UnityEngine.Audio;

public class SoundMixer : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void SetMasterVolume(float level)
	{
		audioMixer.SetFloat("MasterVolume", level);
	}

	public void SetSoundFXVolume(float level)
	{
		audioMixer.SetFloat("SoundMaster", level);
	}


	public void SetMusicVolume(float level)
	{
		audioMixer.SetFloat("MusicMaster", level);
	}
}
