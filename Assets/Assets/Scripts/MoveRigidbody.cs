using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidbody : MonoBehaviour
{
    public Rigidbody2D armBody;
    Rigidbody2D mainBody;

    public float power;
    public float speed;

    public AudioSource audioSource;
    public AudioClip jumpClip;

    private void Start()
    {
        mainBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            armBody.AddForce(transform.up * power, ForceMode2D.Impulse);
            audioSource.clip = jumpClip;
            audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            mainBody.velocity = new Vector3(0, speed, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            mainBody.velocity = new Vector3(-speed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            mainBody.velocity = new Vector3(0, -speed, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            mainBody.velocity = new Vector3(speed, 0, 0);
        }
    }
}
