using System.Collections.Generic;
using UnityEngine;

public class PickupBody : MonoBehaviour
{
    [SerializeField] private List<Transform> _placesForSeat;

    private List<Item> _items = new();

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Item item))
        {
            item.LoseParent();

            _items.Add(item);

            int index = _items.IndexOf(item);

            item.transform.position = _placesForSeat[index].position;
        }
    }
}