using RestaurantSimulatorMVC.Enums;
using UnityEngine;

namespace RestaurantSimulatorMVC.Models
{
    public class TableModel
    {
        public TableState State { get; private set; }
        public OrderModel OrderModel { get; private set; }

        public void Sit()
        {
            if (State != TableState.WaitVisitor)
            {
                Debug.LogWarning("Table already busy");
                return;
            }

            State = TableState.Busy;
        }

        public void SetOrder(OrderModel orderModel)
        {
            if (State != TableState.Busy)
            {
                Debug.LogWarning("Can't create order for table");
                return;
            }

            OrderModel = orderModel;
        }

        public void EmptyTable()
        {
            State = TableState.WaitVisitor;
        }
    }
}
