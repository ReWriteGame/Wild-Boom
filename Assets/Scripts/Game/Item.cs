using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Filter>())
            gameObject.GetComponent<Destroyable>().Destroy();

        if (collision.gameObject.GetComponent<Destroyer>())
            gameObject.GetComponent<Destroyable>().Destroy();
    }
}
