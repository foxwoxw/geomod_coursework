using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputSphereParam : MonoBehaviour
{

    public TextMeshProUGUI Position_x;
    public TextMeshProUGUI Position_y;
    public TextMeshProUGUI Position_z;
    public TextMeshProUGUI Rotation_x;
    public TextMeshProUGUI Rotation_y;
    public TextMeshProUGUI Rotation_z;
    public TextMeshProUGUI Scale_x;
    public TextMeshProUGUI Scale_y;
    public TextMeshProUGUI Scale_z;

    public static Vector3 SpherePosition = new Vector3(0, 0, 0);
    public static Vector3 SphereRotation = new Vector3(0, 0, 0);
    public static Vector3 SphereScale = new Vector3(1, 1, 1);


    void Start()
    {
        Position_x.text = "X: " + SpherePosition.x.ToString();
        Position_y.text = "Y: " + SpherePosition.y.ToString();
        Position_z.text = "Z: " + SpherePosition.z.ToString();
        Rotation_x.text = "X: " + SphereRotation.x.ToString();
        Rotation_y.text = "Y: " + SphereRotation.y.ToString();
        Rotation_z.text = "Z: " + SphereRotation.z.ToString();
        Scale_x.text = "X: " + SphereScale.x.ToString();
        Scale_y.text = "Y: " + SphereScale.y.ToString();
        Scale_z.text = "Z: " + SphereScale.z.ToString();
    }


    public void InputSpherePosition_x(string str)
    {
        if (float.TryParse(str, out SpherePosition.x))
        {
            SpherePosition.x = float.Parse(str);
            Position_x.text = "X: " + str;
        }
    }

    public void InputSpherePosition_y(string str)
    {
        if (float.TryParse(str, out SpherePosition.y))
        {
            SpherePosition.y = float.Parse(str);
            Position_y.text = "Y: " + str;
        }
    }

    public void InputSpherePosition_z(string str)
    {
        if (float.TryParse(str, out SpherePosition.z))
        {
            SpherePosition.z = float.Parse(str);
            Position_z.text = "Z: " + str;
        }
    }

    public void InputSphereRotation_x(string str)
    {
        if (float.TryParse(str, out SphereRotation.x))
        {
            SphereRotation.x = float.Parse(str);
            Rotation_x.text = "X: " + str;
        }
    }

    public void InputSphereRotation_y(string str)
    {
        if (float.TryParse(str, out SphereRotation.y))
        {
            SphereRotation.y = float.Parse(str);
            Rotation_y.text = "Y: " + str;
        }
    }

    public void InputSphereRotation_z(string str)
    {
        if (float.TryParse(str, out SphereRotation.z))
        {
            SphereRotation.z = float.Parse(str);
            Rotation_z.text = "Z: " + str;
        }
    }


    public void InputSphereScale_x(string str)
    {
        if (float.TryParse(str, out SphereScale.x))
        {
            SphereScale.x = float.Parse(str);
            Scale_x.text = "X: " + str;
        }
    }

    public void InputSphereScale_y(string str)
    {
        if (float.TryParse(str, out SphereScale.y))
        {
            SphereScale.y = float.Parse(str);
            Scale_y.text = "Y: " + str;
        }
    }

    public void InputSphereScale_z(string str)
    {
        if (float.TryParse(str, out SphereScale.z))
        {
            SphereScale.z = float.Parse(str);
            Scale_z.text = "Z: " + str;
        }
    }
}
