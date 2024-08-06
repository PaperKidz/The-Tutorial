
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public sound[] sounds;
    public static AudioManager instance; 
    // Start is called before the first frame update
    void Awake()
    {   
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        foreach(sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
        
    }

    // Update is called once per frame
   public void Play(string name)
   {
      sound s =  Array.Find(sounds, sound=> sound.name == name);
      s.source.Play();
   }
}
