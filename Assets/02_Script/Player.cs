using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float vAxis;
    float hAxis;
    float rotX;
    float rotY;
    Vector3 moveVec;

    Animator ani;

    // Start is called before the first frame update
    private void Awake()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        transform.position += moveVec * Time.deltaTime * speed;
        transform.LookAt(transform.position + moveVec);
        ani.SetBool("isMove", moveVec != Vector3.zero);

    }





}
