using RestaurantSimulatorMVC.Factories.Interfaces;
using RestaurantSimulatorMVC.Markers;
using RestaurantSimulatorMVC.Spawners.Interfaces;
using UnityEngine;
using Zenject;

namespace RestaurantSimulatorMVC.Spawners
{
    public class WaiterSpawner : MonoBehaviour, IInitializeSpawner
    {
        [SerializeField]
        private WaiterMarker[] _markers;
        private IWaiterFactory _waiterFactory;

        [Inject]
        public void Construct(IWaiterFactory waiterFactory)
        {
            _waiterFactory = waiterFactory;
            _waiterFactory.Load();
        }

        public void SpawnAll()
        {
            foreach (var marker in _markers)
                _waiterFactory.Create(marker.transform.position, marker.transform.parent);
        }
    }
}
