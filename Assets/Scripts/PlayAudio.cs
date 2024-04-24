using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioClip chestSound;
    public float maxVolumeDistance = 10f;

    private AudioSource audioSource;
    private Transform lizzard;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        lizzard = GameObject.FindWithTag("lizzard").transform; // Adjust tag or reference based on your setup
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, lizzard.position);

        if (distance <= maxVolumeDistance)
        {
            float volume = 1f - (distance / maxVolumeDistance); // Volume decreases as lizzard gets closer
            audioSource.volume = volume;
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(chestSound);
            }
        }
        else
        {
            audioSource.volume = 0f;
        }
    }
}
