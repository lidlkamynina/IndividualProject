using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioClip chestSound;
    public float maxVolumeDistance = 10f;

    private AudioSource audioSource;
    private Transform lizard;

 void Start()
{
    // Find the AudioSource component attached to the same GameObject
    audioSource = GetComponent<AudioSource>();

    // Find the lizard object in the scene
    GameObject lizardObject = GameObject.FindWithTag("Player");
    if (lizardObject != null)
    {
        // Assign the transform of the lizard object
        lizard = lizardObject.transform;
    }
    else
    {
        Debug.LogError("Lizard object not found!");
    }
}


    void Update()
    {
        float distance = Vector3.Distance(transform.position, lizard.position);

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
