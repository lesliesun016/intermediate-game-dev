using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Object"))
        {
            Color color = collision.gameObject.GetComponent<SpriteRenderer>().color;
            color.a = 0.5f; // change alpha
            collision.gameObject.GetComponent<SpriteRenderer>().color = color;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Object"))
        {
            Color color = collision.gameObject.GetComponent<SpriteRenderer>().color;
            color.a = 1f; // change alpha
            collision.gameObject.GetComponent<SpriteRenderer>().color = color;
        }
    }
}

