using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using TMPro;
using UnityEngine;

public class DrawCollision : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject Cone;
    Vector3 RimPoint;
    Vector3 CenterPoint;
    Vector3 TipPoint;
    float AngleChange = 0.008f;
    float CurAngle = 0;
    float Generatrix;
    RaycastHit HitInfoTopSide;
    RaycastHit HitInfoBottomSide;
    RaycastHit HitInfoBottom;
    float LineLength = 0;
    Vector3[] CurPointsTopSide = new Vector3[2];
    Vector3[] CurPointsBottomSide = new Vector3[2];
    Vector3[] CurPointsBottom = new Vector3[2];
    int PointSequenceTopSide = 0;
    int PointSequenceBottomSide = 0;
    int PointSequenceBottom = 0;
    bool Ready = false;
    bool Delay=true;


    // Start is called before the first frame update
    void Start()
    {
        TipPoint = Cone.transform.TransformPoint(0, 1, 0);
        CenterPoint = Cone.transform.TransformPoint(0, -1, 0);
        Text.text = "ѕроизводитс€ нахождение линий пересечени€";
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Delay)
        {
            Delay = false;
            return;
        }
        if (!Ready)
        {
            if (CurAngle < Mathf.PI*2)
            {
                RimPoint = Cone.transform.TransformPoint(Mathf.Cos(CurAngle), -1, Mathf.Sin(CurAngle));
                Generatrix = (RimPoint - TipPoint).magnitude;              

                if (Physics.Raycast(RimPoint, CenterPoint - RimPoint, out HitInfoBottom, (RimPoint - CenterPoint).magnitude, 1, QueryTriggerInteraction.Ignore))
                {
                    CurPointsBottom[PointSequenceBottom % 2] = HitInfoBottom.point;
                    PointSequenceBottom++;
                    if (PointSequenceBottom >= 2)
                    {
                        LineLength += (CurPointsBottom[0] - CurPointsBottom[1]).magnitude;
                    }

                    GameObject S = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    S.transform.localScale = Vector3.one * 0.02f;
                    S.transform.position = HitInfoBottom.point;
                    S.GetComponent<Collider>().enabled = false;
                    S.GetComponent<Renderer>().material.color = Color.blue;
                    
                }
                else
                {
                    PointSequenceBottom = 0;
                }

                if (Physics.Raycast(RimPoint, TipPoint - RimPoint, out HitInfoBottomSide, Generatrix, 1, QueryTriggerInteraction.Ignore))
                {
                    CurPointsBottomSide[PointSequenceBottomSide % 2] = HitInfoBottomSide.point;
                    PointSequenceBottomSide++;
                    if (PointSequenceBottomSide >= 2)
                    {
                        LineLength += (CurPointsBottomSide[0] - CurPointsBottomSide[1]).magnitude;
                    }

                    GameObject S = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    S.transform.localScale = Vector3.one * 0.02f;
                    S.transform.position = HitInfoBottomSide.point;
                    S.GetComponent<Collider>().enabled = false;
                    S.GetComponent<Renderer>().material.color = Color.blue;
                }
                else
                {
                    PointSequenceBottomSide = 0;
                }

                if (Physics.Raycast(TipPoint, RimPoint - TipPoint, out HitInfoTopSide, Generatrix, 1, QueryTriggerInteraction.Ignore))
                {
                    CurPointsTopSide[PointSequenceTopSide % 2] = HitInfoTopSide.point;
                    PointSequenceTopSide++;
                    if (PointSequenceTopSide >= 2)
                    {
                        LineLength += (CurPointsTopSide[0] - CurPointsTopSide[1]).magnitude;
                    }

                    GameObject S = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    S.transform.localScale = Vector3.one * 0.02f;
                    S.transform.position = HitInfoTopSide.point;
                    S.GetComponent<Collider>().enabled = false;
                    S.GetComponent<Renderer>().material.color = Color.blue;
                }
                else
                {
                    PointSequenceTopSide = 0;
                }


                CurAngle += AngleChange;
            }
            else
            {
                Ready = true;
                Text.text = "ƒлина линий пересечени€ равна " + LineLength + " метров";
            }
        }
    }
}

