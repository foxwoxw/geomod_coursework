using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputConeParam : MonoBehaviour
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

    public static Vector3 ConePosition = new Vector3(0, 0, 0);
    public static Vector3 ConeRotation = new Vector3(0, 0, 0);
    public static Vector3 ConeScale = new Vector3(1, 1, 1);


    void Start()
    {
        Position_x.text = "X: " + ConePosition.x.ToString();
        Position_y.text = "Y: " + ConePosition.y.ToString();
        Position_z.text = "Z: " + ConePosition.z.ToString();
        Rotation_x.text = "X: " + ConeRotation.x.ToString();
        Rotation_y.text = "Y: " + ConeRotation.y.ToString();
        Rotation_z.text = "Z: " + ConeRotation.z.ToString();
        Scale_x.text = "X: " + ConeScale.x.ToString();
        Scale_y.text = "Y: " + ConeScale.y.ToString();
        Scale_z.text = "Z: " + ConeScale.z.ToString();
    }


    public void InputConePosition_x(string str)
    {
        if (float.TryParse(str, out ConePosition.x))
        {
            ConePosition.x = float.Parse(str);
            Position_x.text = "X: " + str;
        }
    }

    public void InputConePosition_y(string str)
    {
        if (float.TryParse(str, out ConePosition.y))
        {
            ConePosition.y = float.Parse(str);
            Position_y.text = "Y: " + str;
        }
    }

    public void InputConePosition_z(string str)
    {
        if (float.TryParse(str, out ConePosition.z))
        {
            ConePosition.z = float.Parse(str);
            Position_z.text = "Z: " + str;
        }
    }

    public void InputConeRotation_x(string str)
    {
        if (float.TryParse(str, out ConeRotation.x))
        {
            ConeRotation.x = float.Parse(str);
            Rotation_x.text = "X: " + str;
        }
    }

    public void InputConeRotation_y(string str)
    {
        if (float.TryParse(str, out ConeRotation.y))
        {
            ConeRotation.y = float.Parse(str);
            Rotation_y.text = "Y: " + str;
        }
    }

    public void InputConeRotation_z(string str)
    {
        if (float.TryParse(str, out ConeRotation.z))
        {
            ConeRotation.z = float.Parse(str);
            Rotation_z.text = "Z: " + str;
        }
    }


    public void InputConeScale_x(string str)
    {
        if (float.TryParse(str, out ConeScale.x))
        {
            ConeScale.x = float.Parse(str);
            Scale_x.text = "X: " + str;
        }
    }

    public void InputConeScale_y(string str)
    {
        if (float.TryParse(str, out ConeScale.y))
        {
            ConeScale.y = float.Parse(str);
            Scale_y.text = "Y: " + str;
        }
    }

    public void InputConeScale_z(string str)
    {
        if (float.TryParse(str, out ConeScale.z))
        {
            ConeScale.z = float.Parse(str);
            Scale_z.text = "Z: " + str;
        }
    }
}
