using RestaurantSimulatorMVC.Controllers;
using RestaurantSimulatorMVC.Factories;
using RestaurantSimulatorMVC.Models;
using RestaurantSimulatorMVC.Spawners;
using UnityEngine;
using Zenject;

namespace RestaurantSimulatorMVC.Installers
{
    public class RestaurantInstaller : MonoInstaller
    {
        [SerializeField]
        private FurnitureSpawner _furnitureSpawner = null;
        [SerializeField]
        private Application _application = null;

        public override void InstallBindings()
        {
            Container.Bind<Application>().FromInstance(_application).AsSingle();

            Container.Bind<IFurnitureFactory>().To<FurnitureFactory>().AsTransient();
            Container.Bind<IFurnitureSpawner>().FromInstance(_furnitureSpawner).AsSingle();

            Container.Bind<TableModel>().AsTransient();
            Container.Bind<TableController>().AsTransient();
        }
    }
}
