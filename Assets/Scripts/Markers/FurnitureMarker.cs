using RestaurantSimulatorMVC.Enums;
using UnityEngine;

namespace RestaurantSimulatorMVC.Markers
{
    public class FurnitureMarker : MonoBehaviour
    {
        [SerializeField]
        private FurnitureType _furnitureType;

        public FurnitureType FurnitureType => _furnitureType;
    }
}
