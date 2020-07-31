using System.Collections.Generic;
using UnityEngine;

namespace Animals
{
    public abstract class Animal : MonoBehaviour
    {
        public enum TypesOfFood
        {
            Pizza,
            Cookie,
            Meat
        }

        private float movementSpeed;
        private List<TypesOfFood> diet;

        public float MovementSpeed
        {
            get { return movementSpeed; }

        }

        public List<TypesOfFood> Diet
        {
            get { return diet; }
        }

        

        protected void InitializeAnimal(float newMovementSpeed,List<TypesOfFood>newDiet )
        {
            this.movementSpeed = newMovementSpeed;
            this.diet = newDiet;
        }
    }
}
