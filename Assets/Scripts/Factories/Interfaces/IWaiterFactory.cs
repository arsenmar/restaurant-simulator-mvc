using UnityEngine;

namespace RestaurantSimulatorMVC.Factories.Interfaces
{
    public interface IWaiterFactory
    {
        void Load();
        void Create(Vector3 position, Transform parent);
    }
}
