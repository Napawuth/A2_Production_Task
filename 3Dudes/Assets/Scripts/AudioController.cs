using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip oneShotSound; // Stores a sound file shown in the Inspector
    public AudioClip loopingSound; // Stores another file

    private AudioSource audioSource; 

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // finds the audio source attached to the GameObject
                                                   // stores it in audioSource for later use
    }

    void Update()
    {
        // Press SPACE → play one-shot sound
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(oneShotSound);
        }

        // Left mouse click → play one-shot sound
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(oneShotSound);
        }

        // Press L → start looping sound
        if (Input.GetKeyDown(KeyCode.L))
        {
            audioSource.clip = loopingSound;
            audioSource.loop = true;
            audioSource.Play();
        }

        // Press S → stop looping sound
        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Stop();
        }
    }
}