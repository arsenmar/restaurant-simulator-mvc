using RestaurantSimulatorMVC.Enums;
using UnityEngine;

namespace RestaurantSimulatorMVC.Factories.Interfaces
{
    public interface IFurnitureFactory
    {
        void Load();
        void Create(FurnitureType type, Vector3 position, Transform parent);
    }
}