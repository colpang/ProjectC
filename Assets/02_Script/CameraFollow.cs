using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    Vector3 oldPos;

    float rotX;
    float rotY;
    public float speed;

    private void Awake()
    {
        oldPos = Player.transform.position;
    }
    void LateUpdate()
    {
        Vector3 delta = Player.transform.position - oldPos;
        transform.position += delta;
        oldPos = Player.transform.position;
    }

}
