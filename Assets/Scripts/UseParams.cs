using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class UseParams : MonoBehaviour
{
    public GameObject Cone;
    public GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {
        Cone.transform.position = InputConeParam.ConePosition;
        Cone.transform.localEulerAngles = InputConeParam.ConeRotation;
        Cone.transform.localScale = InputConeParam.ConeScale;

        Sphere.transform.position = InputSphereParam.SpherePosition;
        Sphere.transform.localEulerAngles = InputSphereParam.SphereRotation;
        Sphere.transform.localScale = InputSphereParam.SphereScale;

        transform.position = (Cone.transform.position + Sphere.transform.position) * 0.5f;
    }
}
