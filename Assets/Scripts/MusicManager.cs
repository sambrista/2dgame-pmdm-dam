using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager Instance;
    private AudioSource audioSource;
    public AudioClip backgroundMusic;
    private void Awake() {
        if (Instance == null) {
            Instance = this;
            audioSource = GetComponent<AudioSource>();
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (backgroundMusic != null) {
            Instance.audioSource.clip = backgroundMusic;
            PlayBackgroundMusic();
        }
    }

    public static void PlayBackgroundMusic() {
        Instance.audioSource.Play();
    }
    public static void PauseBackgroundMusic() {
        Instance.audioSource.Pause();
    }
}
