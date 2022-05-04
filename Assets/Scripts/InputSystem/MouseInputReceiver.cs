using UnityEngine;
using System;
using UnityEngine.EventSystems;

namespace TestProject.InputSystem
{
    public class MouseInputReceiver : InputReceiver
    {
        public override event Action<Vector3> PointerDown;
        public override event Action<Vector3> PointerHold;
        public override event Action PointerUp;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
                PointerDown?.Invoke(Input.mousePosition);
            if (Input.GetMouseButton(0))
                PointerHold?.Invoke(Input.mousePosition);
            if (Input.GetMouseButtonUp(0))
                PointerUp?.Invoke();
        }
    }
}



