using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class RotateCamera : MonoBehaviour
{

    public Transform target;
    Vector3 offset;
    float limit = 80; // ограничение вращения по Y
    public float sensitivity = 3; // чувствительность мышки
    float zoom = 0.25f; // чувствительность при увеличении, колесиком мышки
    float zoomMax = 8; // макс. увеличение
    float zoomMin = 1; // мин. увеличение
    float X, Y;
    Vector3 localEuler = new Vector2(0, 0);

    // Start is called before the first frame update
    void Start()
    {
        limit = Mathf.Abs(limit);
        if (limit > 90) limit = 90;
        offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax) / 2);
        transform.position = target.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0) offset.z += zoom;
        else if (Input.GetAxis("Mouse ScrollWheel") < 0) offset.z -= zoom;
        offset.z = Mathf.Clamp(offset.z, -Mathf.Abs(zoomMax), -Mathf.Abs(zoomMin));

        X = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        Y += Input.GetAxis("Mouse Y") * sensitivity;
        Y = Mathf.Clamp(Y, -limit, limit);
        localEuler.x = -Y;
        localEuler.y = X;
        transform.localEulerAngles = localEuler;
        transform.position = transform.localRotation * offset + target.position;
    }
}
