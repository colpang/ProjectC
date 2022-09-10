using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    Transform cameraArm;

    public Transform Player;
    public Vector3 offset;

    float rotX;
    float rotY;

    public float followSpeed;
    public float clampAngle;
    public float sensitivity;
    public float smoothness;


    private void Awake()
    {
        cameraArm.transform.rotation = Quaternion.identity;
    }

    private void Update()
    {

        if (Input.GetMouseButton(1))
        {
            CameraRotation();
        }
    }

    void CameraRotation()
    {
        rotX += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        rotY += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        Vector3 camAngle = cameraArm.rotation.eulerAngles;


        cameraArm.rotation = Quaternion.Euler(-rotX, rotY, 0);
    }

    void cameraFollow()
    {
        cameraArm.transform.position = Player.position;
    }
    void LateUpdate()
    {
        cameraFollow();
    }

}
