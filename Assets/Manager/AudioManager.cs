using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager :BaseManager {
    public delegate void AudioEventHandler();
    public event AudioEventHandler PlayAudio;
    public AudioManager(GameManager gameManager) : base(gameManager) { }

    public void Play()
    {
        Debug.Log("测试成功");

        PlayAudio();
    }
}
