using UnityEngine;

public class Item : MonoBehaviour
{
    public void ChangePosition(Transform newPosition, Transform newParent)
    {
        transform.position = newPosition.position;
        transform.SetParent(newParent);
    }

    public void LoseParent() => transform.SetParent(null);
}