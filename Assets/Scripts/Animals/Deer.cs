using System;
using System.Collections.Generic;

namespace Animals
{
    public class Deer : Animal
    {
        private void Awake()
        {
            float movementSpeed = 40;
            List<TypesOfFood>newDiet= new List<TypesOfFood>();
            newDiet.Add(TypesOfFood.Cookie);
            newDiet.Add(TypesOfFood.Pizza);
            InitializeAnimal(movementSpeed,newDiet);
        }
    }
}
