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
    public GameObject cam;


    // Start is called before the first frame update
    private void Awake()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraRotation(cam);
    }

    private void Move()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        transform.position += moveVec * Time.deltaTime * speed;
        ani.SetBool("isMove", moveVec != Vector3.zero);

        transform.LookAt(transform.position + moveVec);

    }
    void CameraRotation(GameObject cam)
    {
        float camspeed = 30f;
        rotX = Input.GetAxis("Mouse X")*camspeed;
        rotY = Input.GetAxis("Mouse Y")*camspeed;
        transform.Rotate(0, rotX * Time.deltaTime, 0);
        cam.transform.Rotate(-rotY * Time.deltaTime, 0, 0);
    }




}
