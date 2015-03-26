
using UnityEngine;
using System.Collections.Generic;

public class SoundEffects : MonoBehaviour
{

	public AudioClip[] audioClips;
	public Dictionary<string, AudioSource> channels = new Dictionary<string, AudioSource>();

	void Start()
	{
		foreach (var clip in audioClips)
		{
			channels.Add(clip.name, CreateSource(clip));
		}
	}


	AudioSource CreateSource(AudioClip pClip)
	{
		var channel = new GameObject();
		channel.transform.parent = transform;
		channel.name = pClip.name;
		channel.AddComponent<AudioSource>();
		channel.audio.clip = pClip;
			
		return channel.audio;
	}

	public void PlayOneShot(string pName)
	{
		channels[pName].PlayOneShot(channels[pName].clip);
	}
}
