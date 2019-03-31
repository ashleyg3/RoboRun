using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public double springConstant;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    double springForce(double y1, double y2)
    {
        double distance = y2 - y1;
        double result = -springConstant*(System.Math.Abs(distance)-1.76);
        return result;
    }
}
