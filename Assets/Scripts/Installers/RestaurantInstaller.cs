using RestaurantSimulatorMVC.Controllers;
using RestaurantSimulatorMVC.Factories;
using RestaurantSimulatorMVC.Factories.Interfaces;
using RestaurantSimulatorMVC.Initializers;
using RestaurantSimulatorMVC.Models;
using RestaurantSimulatorMVC.Spawners;
using RestaurantSimulatorMVC.Spawners.Interfaces;
using UnityEngine;
using Zenject;

namespace RestaurantSimulatorMVC.Installers
{
    public class RestaurantInstaller : MonoInstaller
    {
        [SerializeField]
        private FurnitureSpawner _furnitureSpawner = null;
        [SerializeField]
        private WaiterSpawner _waiterSpawner = null;

        public override void InstallBindings()
        {
            Container.Bind<IFurnitureFactory>().To<FurnitureFactory>().AsTransient();
            Container.Bind<IInitializeSpawner>().FromInstance(_furnitureSpawner).AsCached();
            Container.Bind<IWaiterFactory>().To<WaiterFactory>().AsTransient();
            Container.Bind<IInitializeSpawner>().FromInstance(_waiterSpawner).AsCached();

            Container.Bind<TableModel>().AsTransient();
            Container.Bind<TableController>().AsTransient();
            Container.Bind<WaiterModel>().AsTransient();
            Container.Bind<WaiterController>().AsTransient();

            Container.Bind<RestaurantObjectsInitializer>().AsSingle();
        }

        public override void Start()
        {
            Container.Instantiate<RestaurantObjectsInitializer>().Inititalize();
        }
    }
}
