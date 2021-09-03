using RestaurantSimulatorMVC.Enums;
using RestaurantSimulatorMVC.Views;
using UnityEngine;
using Zenject;

namespace RestaurantSimulatorMVC.Factories
{
    public class FurnitureFactory : IFurnitureFactory
    {
        private const string _resourcesPath = "Furniture/";
        private readonly DiContainer _diContainer;

        private TableView _tablePrefab;

        public FurnitureFactory(DiContainer diContainer) => _diContainer = diContainer;

        public void Load()
        {
            _tablePrefab = Resources.Load<TableView>(_resourcesPath + FurnitureType.Table.ToString());
        }

        public void Create(FurnitureType type, Vector3 position, Transform parent)
        {
            switch (type)
            {
                case FurnitureType.Table:
                    _diContainer.InstantiatePrefabForComponent<TableView>(_tablePrefab, position, Quaternion.identity, parent);
                    break;
                case FurnitureType.KitchenStove:
                    break;
                default:
                    break;
            }
        }
    }
}
