using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AvatarTemplate : ScriptableObject
{
   public string name;
   public float speed;
   public float stamina;
   public GameObject visuals;
   
   //TODO 
   //ADD Tiers so things can be calculated.
}
