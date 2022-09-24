using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    public GameObject playerPrefab;

    public Transform playerSpawnTransform;


    private void Start()
    {
        if(playerPrefab != null && playerSpawnTransform != null)
        {
            Instantiate(playerPrefab, playerSpawnTransform);
        }
    }
}
