using UnityEngine;

public class LizardController : MonoBehaviour
{
    public int points = 10; // Points to add when picking up a chest

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chest"))
        {
            Pickup(other.gameObject);
        }
    }

    private void Pickup(GameObject chestObject)
    {
        // Make the chest object disappear
        chestObject.SetActive(false);


        // // Add points to the player
        // PlayerController playerController = FindObjectOfType<PlayerController>(); // Assuming PlayerController manages player's points
        // if (playerController != null)
        // {
        //     playerController.AddPoints(points);
        // }
        // else
        // {
        //     Debug.LogWarning("PlayerController not found!");
        // }
    }
}


