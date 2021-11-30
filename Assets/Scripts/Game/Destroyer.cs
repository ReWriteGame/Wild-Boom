using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class Destroyer : MonoBehaviour
{
    public UnityEvent itemDestroyedEvent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Item>())
            itemDestroyedEvent?.Invoke();
    }
}


