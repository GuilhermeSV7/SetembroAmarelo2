using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundMixer : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

	private float VMatual, VSatual, VmUatual;
	
	[SerializeField] public Slider SliderMaster, SliderSom, SliderMusic;
    public void Start()
    {
		GetVolume();
	}


    public void SetMasterVolume(float level)
	{
		audioMixer.SetFloat("MasterVolume", Mathf.Log10(level) * 20f);
		PlayerPrefs.SetFloat("MasterVolume", level);
		//PlayerPrefs.Save(); 
	}

	public void SetSoundFXVolume(float level)
	{
		audioMixer.SetFloat("SoundMaster", Mathf.Log10(level) * 20f);
		PlayerPrefs.SetFloat("SoundMaster", level);
	}

	public void SetMusicVolume(float level)
	{
		audioMixer.SetFloat("MusicMaster", Mathf.Log10(level) * 20f);
		PlayerPrefs.SetFloat("MusicMaster", level);
	}

	void GetVolume() 
	{
		VMatual = PlayerPrefs.GetFloat("MasterVolume");
		VSatual = PlayerPrefs.GetFloat("SoundMaster");
		VmUatual = PlayerPrefs.GetFloat("MusicMaster");

        SliderMaster.value = VMatual;
        SliderSom.value = VSatual;
        SliderMusic.value = VmUatual;
    }
}
