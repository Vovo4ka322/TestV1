using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    [SerializeField] private Door _door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player _))
            _door.Open();
    }
}