using RestaurantSimulatorMVC.Spawners;
using UnityEngine;
using Zenject;

namespace RestaurantSimulatorMVC
{
    public class Application : MonoBehaviour
    {
        [Inject]
        public void Construct(IFurnitureSpawner furnitureSpawner) 
        {
            furnitureSpawner.SpawnAll();
        }
    }
}
