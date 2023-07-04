using System.Collections;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip clip1; // Reference to your first audio clip
    public AudioClip clip2; // Reference to your second audio clip
    public float delayBeforePlaying = 1f; // Delay in seconds before playing the first clip
    public float playbackSpeed = 0.5f; // The speed at which the audio clips should play (0.5 = half speed)

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlaySequentially();
    }

    private void PlaySequentially()
    {
        StartCoroutine(PlayDelayedClip(clip1, delayBeforePlaying));
    }

    private IEnumerator PlayDelayedClip(AudioClip clip, float delay)
    {
        yield return new WaitForSeconds(delay);

        audioSource.clip = clip;
        audioSource.pitch = playbackSpeed;
        audioSource.Play();

        yield return new WaitForSeconds(clip.length / playbackSpeed);

        // Play the second audio clip
        audioSource.clip = clip2;
        audioSource.pitch = playbackSpeed;
        audioSource.Play();
    }
}
