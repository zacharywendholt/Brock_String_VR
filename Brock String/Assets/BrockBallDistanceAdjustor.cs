using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrockBallDistanceAdjustor : MonoBehaviour
{
    [SerializeField] private GameObject brockString;
    private float viewingDistanceOffset;
    void Start()
    {
        viewingDistanceOffset = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        updatePos();
    }


    private void updatePos() {
        Vector3 newPosition = brockString.transform.position;
        
        newPosition += new Vector3(0, 0, viewingDistanceOffset);
        //transform.position = newPosition;

    }


    public void setDistanceOffset(float newViewingDistanceOffset) {
        viewingDistanceOffset = newViewingDistanceOffset;
    }
}
