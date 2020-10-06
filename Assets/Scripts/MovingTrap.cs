using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTrap : MonoBehaviour
{
    private Vector3 pos1 = new Vector3(-6.76f, 7, -28.764f);
    private Vector3 pos2 = new Vector3(-6.76f, 20, -28.764f);
    public float speed = 1.0f;
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
