using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector2 zoneX = new Vector2(-9.0f, 9.0f);
    public Vector2 zoneZ = new Vector2(-5.0f, 5.0f);

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;

        Vector3 center = new Vector3(
            (zoneX.x + zoneX.y) / 2,
            0,
            (zoneZ.x + zoneZ.y) / 2);

        Vector3 size = new Vector3(
            zoneX.y - zoneX.x,
            0,
            zoneZ.y - zoneZ.x);
        //Gizmos.DrawCube(center, size);
        Gizmos.DrawWireCube(center, size);
    }
}


