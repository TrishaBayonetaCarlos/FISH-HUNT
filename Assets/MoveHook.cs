using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHook : MonoBehaviour
{
    [SerializeField] private float _speed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
