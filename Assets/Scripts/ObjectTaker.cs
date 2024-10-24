using UnityEngine;

public class ObjectTaker : MonoBehaviour
{
    [SerializeField] private Transform _placeForSeat;
    [SerializeField] private Selector _selector;

    private void OnEnable()
    {
        _selector.ItemSelected += Take;
    }

    private void OnDisable()
    {
        _selector.ItemSelected -= Take;
    }

    public void Take(Item item)
    {
        item.ChangePosition(_placeForSeat, transform);
    }
}