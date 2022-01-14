using RestaurantSimulatorMVC.Factories.Interfaces;
using RestaurantSimulatorMVC.Views;
using UnityEngine;
using Zenject;

namespace RestaurantSimulatorMVC.Factories
{
    public class WaiterFactory : IWaiterFactory
    {
        private const string _resourcesPath = "Persons/";
        private readonly DiContainer _diContainer;

        private WaiterView _waiterPrefab;

        public WaiterFactory(DiContainer diContainer) => _diContainer = diContainer;

        public void Create(Vector3 position, Transform parent)
        {
            _diContainer.InstantiatePrefabForComponent<WaiterView>(_waiterPrefab, position, Quaternion.identity, parent);
        }

        public void Load()
        {
            _waiterPrefab = Resources.Load<WaiterView>(_resourcesPath + "Waiter");
        }
    }
}
