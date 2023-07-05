using System.Collections;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip clip1; // Reference to your first audio clip
    public AudioClip clip2; // Reference to your second audio clip
    public AudioClip clip3; // Reference to your third audio clip
    public float delayBeforePlayingFirst = 1f; // Delay in seconds before playing the first clip
    public float delayBeforePlayingThird = 3f; // Delay in seconds before playing the third clip

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlaySequentially();
    }

    private void PlaySequentially()
    {
        StartCoroutine(PlayDelayedClip(clip1, delayBeforePlayingFirst));
    }

    private IEnumerator PlayDelayedClip(AudioClip clip, float delay)
    {
        yield return new WaitForSeconds(delay);

        audioSource.clip = clip;
        audioSource.Play();

        yield return new WaitForSeconds(clip.length);

        if (clip == clip1)
        {
            // Play the second audio clip
            audioSource.clip = clip2;
            audioSource.Play();

            yield return new WaitForSeconds(clip2.length);

            // Play the third audio clip
            StartCoroutine(PlayDelayedClip(clip3, delayBeforePlayingThird));
        }
        else if (clip == clip3)
        {
            // Play the third audio clip
            audioSource.clip = clip3;
            audioSource.Play();
        }
    }
}
