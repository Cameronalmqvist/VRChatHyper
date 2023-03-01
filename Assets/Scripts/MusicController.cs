using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource musicSource;

    void Start()
    {
        // Get the AudioSource component for the music
        musicSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        // Play the music
        musicSource.Play();
    }

    public void StopMusic()
    {
        // Stop the music
        musicSource.Stop();
    }

    public void NextSong()
    {
        // Play the next song
        // You can add your own logic here to select the next song
        musicSource.Stop();
        musicSource.Play();
    }
}
