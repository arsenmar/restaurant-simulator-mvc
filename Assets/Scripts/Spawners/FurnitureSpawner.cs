using RestaurantSimulatorMVC.Factories.Interfaces;
using RestaurantSimulatorMVC.Markers;
using RestaurantSimulatorMVC.Spawners.Interfaces;
using UnityEngine;
using Zenject;

namespace RestaurantSimulatorMVC.Spawners
{
    public class FurnitureSpawner : MonoBehaviour, IInitializeSpawner
    {
        [SerializeField]
        private FurnitureMarker[] _markers;
        private IFurnitureFactory _furnitureFactory;

        [Inject]
        public void Construct(IFurnitureFactory furnitureFactory)
        {
            _furnitureFactory = furnitureFactory;
            _furnitureFactory.Load();
        }

        public void SpawnAll()
        {
            foreach (var marker in _markers)
                _furnitureFactory.Create(marker.FurnitureType, marker.transform.position, marker.transform.parent);
        }
    }
}
