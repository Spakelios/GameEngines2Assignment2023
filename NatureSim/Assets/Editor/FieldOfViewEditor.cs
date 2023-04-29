using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FieldOfViewEditor : Editor
{
    private void OnSceneGUI()
    {
        FieldOfView fov = (FieldOfView) target;
        Handles.color = Color.white;
        Handles.DrawWireArc(fov.transform.position, Vector3.up, Vector3.forward, 360, fov.radius);

        Vector3 viewAngle1 = DirectionFromAngle(fov.transform.eulerAngles.y, -fov.angle / 2);
        Vector3 viewAngle2 = DirectionFromAngle(fov.transform.eulerAngles.y, fov.angle / 2);
        
        Handles.color = Color.yellow;
        Handles.DrawLine(fov.transform.position, fov.transform.position + viewAngle1 * fov.radius);
        Handles.DrawLine(fov.transform.position, fov.transform.position + viewAngle2 * fov.radius);

        if (fov.canSee)
        {
            Handles.color = Color.blue;
            Handles.DrawLine(fov.transform.position, fov.closestPos);
        }
    }
    

    private Vector3 DirectionFromAngle(float eulerY, float angleInDeg)
    {
        angleInDeg += eulerY;

        return new Vector3(Mathf.Sin(angleInDeg * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDeg * Mathf.Deg2Rad));

    }
}
