using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionMenu : MonoBehaviour
{
   private void Awake()
   {
      AvatarAssets.OnAvatarSelected += HandlePlayerSelected;
   }

   private void HandlePlayerSelected(AvatarTemplate template)
   {
      this.gameObject.SetActive(false);
      //TODO 
      //Call the audio manager to play the avatar SFX
   }
}
