using UnityEngine;
using UnityEngine.Audio;
using System;
using Unity.VisualScripting;
using UnityEngine.Rendering;

public class SoudManeger : MonoBehaviour
{
	public static SoudManeger instance;

	[SerializeField] private AudioSource soundFXObject;

	private void Awake()
    {
        if (instance == null)
		{
			instance = this;
		}
	}

	public void PlaySoundFXClip(AudioClip audioClip, Transform spawnTransform, float volume)
	{
		AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity).GetComponent<AudioSource>();
		audioSource.clip = audioClip;
		audioSource.volume = volume;
		audioSource.Play();

		audioSource.Play();

		float clipLength = audioSource.clip.length;

		Destroy(audioSource.gameObject, clipLength);
	}

}
