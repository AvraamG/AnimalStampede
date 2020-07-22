using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISpawnSpot : MonoBehaviour
{
    private GameObject _currentAvatar;

    private void HandleAvatarUpdated(AvatarTemplate template)
    {
        //TODO Optimize this
        Destroy(_currentAvatar);
        _currentAvatar = Instantiate(template.visuals,this.transform.position,this.transform.rotation);
    }
    
    private void HandleAvatarSelected(AvatarTemplate template)
    {
       
        //TODO Optimize this
        Destroy(_currentAvatar);
    }
    // Start is called before the first frame update
    void Awake()
    {
        AvatarAssets.OnAvatarUpdated += HandleAvatarUpdated;
        AvatarAssets.OnAvatarSelected += HandleAvatarSelected;
    }

 
}
