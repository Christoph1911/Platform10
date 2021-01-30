using UnityEngine;
using UnityEngine.Audio;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static bool GameIsOver = false;

    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else{
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(gameObject);
        
        foreach (Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start (){
        Play("Theme");
    }

    public void Play (String name){
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
