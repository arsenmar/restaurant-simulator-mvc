using RestaurantSimulatorMVC.Enums;
using RestaurantSimulatorMVC.Factories;
using RestaurantSimulatorMVC.Markers;
using RestaurantSimulatorMVC.Views;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace RestaurantSimulatorMVC.Spawners
{
    public class FurnitureSpawner : MonoBehaviour, IFurnitureSpawner
    {
        [SerializeField]
        private List<FurnitureMarker> _markers;
        private IFurnitureFactory _furnitureFactory;

        [Inject]
        public void Construct(IFurnitureFactory furnitureFactory)
        {
            _furnitureFactory = furnitureFactory;
            _furnitureFactory.Load();
        }

        public void SpawnAll()
        {
            _markers.ForEach(m =>
                _furnitureFactory.Create(m.FurnitureType,
                    m.transform.position,
                    m.transform.parent));
        }
    }
}
