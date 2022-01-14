using UnityEngine;

namespace RestaurantSimulatorMVC.Markers
{
    public class WaiterMarker : MonoBehaviour
    {
        [SerializeField]
        private int _speed;
        [SerializeField]
        private string _name;

        public int Speed => _speed;
        public string Name => _name;
    }
}
