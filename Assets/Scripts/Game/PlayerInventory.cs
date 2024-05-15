using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   private int totalChests = 7;
   public int NumberOfChests {get; private set; }

   public UnityEvent<PlayerInventory> OnChestCollected; 

    [SerializeField]
    private GameManager _gameManager;

   private void Awake()
   {
        if (OnChestCollected == null)
            OnChestCollected = new UnityEvent<PlayerInventory>();
   }

   public void ChestCollected()
   {
    NumberOfChests++;
    OnChestCollected.Invoke(this);
    if (NumberOfChests >= totalChests) 
    {
      _gameManager.OnPlayerFinished();
    }
   }

   public void CapsuleCollected()
   {
    NumberOfChests = NumberOfChests + 10;
    OnChestCollected.Invoke(this);
   }
}
