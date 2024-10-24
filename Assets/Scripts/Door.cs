using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform _targetPosition;

    public void Open() => transform.position = _targetPosition.position;
}