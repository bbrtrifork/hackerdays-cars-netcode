using System;
using Controls;
using UnityEngine;

namespace Car
{
    public class CarPrefabManager : MonoBehaviour
    {
        [SerializeField] private Transform carAnchor;
        [SerializeField] private CarInputHandler carInputHandler;
        [SerializeField] private CarPrefabProvider carPrefabProvider;

        private void Awake()
        {
            SetupCarPrefab(CarPrefabTerm.Van);
        }

        public void SetupCarPrefab(CarPrefabTerm carPrefabTerm)
        {
            GameObject prefab = carPrefabProvider.GetCarPrefab(carPrefabTerm);
            GameObject newCarChassis = Instantiate(prefab, carAnchor);
            carInputHandler.CarWheelAnimations = newCarChassis.GetComponent<CarWheelAnimations>();
        }
    }
}
