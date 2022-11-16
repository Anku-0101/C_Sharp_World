using System;

namespace ExtensionMethods
{
    static class AnimalExtension
    {
        private static string species;

        public static string GetSpecies(this Animal animal)
        {
            return AnimalExtension.species;
        }

        public static void SetSpecies(this Animal animal, string Species)
        {
            AnimalExtension.species = Species;
        }

        

    }
}



