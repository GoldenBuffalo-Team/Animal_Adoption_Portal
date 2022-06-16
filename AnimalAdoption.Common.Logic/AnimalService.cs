using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Buffalo", Age = 25, Description = "hard - working" },
            new Animal { Id = 2, Name = "Dragon", Age = 1000, Description = "fly" },
            new Animal { Id = 3, Name = "Tiger", Age = 15, Description = "roaring" },
        };
    }
}
