using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float _timeToWaitBeforeExit;

    public void OnPlayerFinished()
    {
        Invoke(nameof(EndGame), _timeToWaitBeforeExit);
    }

    private void EndGame()
    {
        Debug.Log("All chests collected! Game finished!");
        SceneManager.LoadScene("Main Menu");
    }
   
}
