using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform playerSpawnSpot;
    private Player currentPlayer;
    
    private void HandleAvatarSelected(AvatarTemplate template)
    {
        CreatePlayerFromTemplate(template);
    }

    private void CreatePlayerFromTemplate(AvatarTemplate template)
    {
        GameObject player = Instantiate(template.visuals, playerSpawnSpot.transform.position,
            playerSpawnSpot.transform.rotation);
      currentPlayer=  player.AddComponent<Player>();
    }

    private void Awake()
    {
        AvatarAssets.OnAvatarSelected += HandleAvatarSelected;
    }
}
