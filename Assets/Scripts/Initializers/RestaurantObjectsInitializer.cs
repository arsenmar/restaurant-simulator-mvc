using RestaurantSimulatorMVC.Spawners.Interfaces;
using System.Collections.Generic;

namespace RestaurantSimulatorMVC.Initializers
{
    public class RestaurantObjectsInitializer
    {
        private readonly IEnumerable<IInitializeSpawner> _initializeSpawners;

        public RestaurantObjectsInitializer(IEnumerable<IInitializeSpawner> initializeSpawner)
        {
            _initializeSpawners = initializeSpawner;
        }

        public void Inititalize()
        {
            foreach (var spawner in _initializeSpawners)
                spawner.SpawnAll();
        }
    }
}
