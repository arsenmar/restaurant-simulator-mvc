using RestaurantSimulatorMVC.Controllers;
using UnityEngine;
using Zenject;

namespace RestaurantSimulatorMVC.Views
{
    public class WaiterView : MonoBehaviour
    {
        private WaiterController _waiterController;

        [Inject]
        public void Construct(WaiterController waiterController)
        {
            _waiterController = waiterController;
        }
    }
}
