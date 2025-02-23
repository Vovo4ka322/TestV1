using Items;
using System;
using UnityEngine;

public class Selector : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private int _selectedObject = 0;
    private float _rayDistance = 1.5f;

    public event Action<Item> ItemSelected;

    private void Update()
    {
        Choose();
    }

    private void Choose()
    {
        if (Input.GetMouseButtonDown(_selectedObject))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out RaycastHit raycastHit, _rayDistance))
            {
                if (raycastHit.collider.TryGetComponent(out Item component))
                {
                    ItemSelected?.Invoke(component);
                }
            }
        }
    }
}