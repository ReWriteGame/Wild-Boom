using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Rigidbody2D))]
public class Filter : MonoBehaviour
{
    [SerializeField]private float forceImpulse = 1;
    [SerializeField]private float force = 1;
    [SerializeField]private Vector2 dirictionMove;

    public UnityEvent addImpulseEvent;
    public UnityEvent addForceEvent;

    public UnityEvent takeObjectAEvent;
    public UnityEvent takeObjectBEvent;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void AddImpulse()
    {
        rb.AddForce(dirictionMove.normalized * forceImpulse, ForceMode2D.Impulse);
        addImpulseEvent?.Invoke();
    }

    public void AddForce()
    {
        rb.AddForce(dirictionMove.normalized * force, ForceMode2D.Force);
        addForceEvent?.Invoke();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<ObjectA>())
            takeObjectAEvent?.Invoke();

        if (collision.gameObject.GetComponent<ObjectB>())
            takeObjectBEvent?.Invoke();
    }
}
