using RestaurantSimulatorMVC.Controllers;
using RestaurantSimulatorMVC.Models;
using UnityEngine;
using Zenject;

namespace RestaurantSimulatorMVC.Views
{
    public class TableView : MonoBehaviour
    {
        [SerializeField]
        private Transform _seatMarker;
        private TableController _tableController;
        
        [Inject]
        public void Construct(TableController tableController)
        {
            _tableController = tableController;
        }

        public void Sit() => _tableController.Sit();

        public void SetOrder(OrderModel order) => _tableController.SetOrder(order);

        public void EmptyTable() => _tableController.EmptyTable();
    }
}
