using RestaurantSimulatorMVC.Models;

namespace RestaurantSimulatorMVC.Controllers
{
    public class TableController
    {
        private TableModel _tableModel;

        public TableController(TableModel tableModel)
        {
            _tableModel = tableModel;
        }

        public void Sit() => _tableModel.Sit();

        public void SetOrder(OrderModel order) => _tableModel.SetOrder(order);

        public void EmptyTable() => _tableModel.EmptyTable();
    }
}
