using RestaurantSimulatorMVC.Models;

namespace RestaurantSimulatorMVC.Controllers
{
    public class WaiterController
    {
        private WaiterModel _waiterModel;

        public WaiterController(WaiterModel waiterModel)
        {
            _waiterModel = waiterModel;
        }
    }
}
