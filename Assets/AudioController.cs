using System.Collections;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip clip1; // Reference to first audio clip
    public AudioClip clip2; // Reference to second audio clip
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlaySequentially();
    }

    private void PlaySequentially()
    {
        // Play the first audio clip
        audioSource.clip = clip1;
        audioSource.Play();

        // Wait until the first clip finishes playing
        StartCoroutine(WaitForClipToFinish(clip1.length));
    }

    private IEnumerator WaitForClipToFinish(float duration)
    {
        yield return new WaitForSeconds(duration);

        // Play the second audio clip
        audioSource.clip = clip2;
        audioSource.Play();
    }
}
