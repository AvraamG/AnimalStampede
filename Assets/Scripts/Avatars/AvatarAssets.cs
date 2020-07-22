using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class AvatarAssets : MonoBehaviour
{
    public static Action<AvatarTemplate> OnAvatarUpdated;
    public static Action<AvatarTemplate> OnAvatarSelected;
    [SerializeField]
    List<AvatarTemplate> avatarTemplates;

    private int _currentAvatarIndex=0;

    private void Start()
    {
        UpdateAvatar();
    }

    private void IncreaseIndex()
    {

        if (_currentAvatarIndex==avatarTemplates.Count-1 )
        {
            _currentAvatarIndex = 0;
        }
        else
        {
            _currentAvatarIndex++;
        }

    }

    private void ReduceIndex()
    {
        if (_currentAvatarIndex==0)
        {
            _currentAvatarIndex = avatarTemplates.Count-1 ;
        }
        else
        {
            _currentAvatarIndex--;
        }
    }
    
    //TODO 
    //Decouple this.

    public void NextAvatar()
    {
        IncreaseIndex();

        UpdateAvatar();
    }
    public void PreviousAvatar()
    {
        ReduceIndex();
        
        UpdateAvatar();
    }

    public void SelectAvatar()
    {
        if (OnAvatarSelected!=null)
        {
            OnAvatarSelected(avatarTemplates[_currentAvatarIndex]);
        }
    }
    


   private void UpdateAvatar()
   {
       if (OnAvatarUpdated!=null)
       {
           OnAvatarUpdated(avatarTemplates[_currentAvatarIndex]);
       }
   }
    
    
}
