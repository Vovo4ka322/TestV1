using Items;
using UnityEngine;

public class ObjectTaker : MonoBehaviour
{
    [SerializeField] private Transform _placeForSeat;
    [SerializeField] private Selector _selector;
    [SerializeField] private PickupBody _pickupBody;

    private Item _item;

    private void OnEnable()
    {
        _selector.ItemSelected += OnTaken;
        _pickupBody.ItemTook += OnHandsFreed;
    }

    private void OnDisable()
    {
        _selector.ItemSelected -= OnTaken;
        _pickupBody.ItemTook -= OnHandsFreed;
    }

    public void OnTaken(Item item)
    {
        if (_item != null)
            return;

        item.ChangePosition(_placeForSeat, transform);
        Collect(item);
    }

    private void OnHandsFreed() => _item = null;

    private void Collect(Item item) => _item = item;
}