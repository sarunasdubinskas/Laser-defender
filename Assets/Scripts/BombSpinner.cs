using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpinner : MonoBehaviour
{
    [SerializeField] float spinnigSpeed = 5f;

    void Update()
    {
        RotateBomb();
    }

    void RotateBomb()
    {
        transform.Rotate(0, 0, spinnigSpeed * Time.deltaTime);
    }
}
