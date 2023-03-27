using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -6f;
    public static float rightSide = 6f;
    public float internalRight;
    public float internalleft;

   
    void Update()
    {
        internalleft = leftSide;
        internalRight = rightSide;
    }
}
