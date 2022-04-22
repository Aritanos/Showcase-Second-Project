using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class MouseInputReceiver : MonoBehaviour, IInputReceiver
{
    public event Action<Vector3> PointerDown;
    public event Action<Vector3> PointerHold;
    public event Action PointerUp;

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



