using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrockCameraJoint : MonoBehaviour
{
    [SerializeField] private GameObject cameraObject;

    private float verticalOffset;

    private float horizontalOffset;

    // Start is called before the first frame update
    void Start()
    {
        verticalOffset = 0.0f;
        horizontalOffset = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        updatePos();
    }


    private void updatePos() {
        Vector3 newPosition = cameraObject.transform.position;
        newPosition += new Vector3(horizontalOffset, verticalOffset, 0);
        transform.position = newPosition;
    }


    public void setVerticalOffset(float newVerticalOffset) {
        verticalOffset = newVerticalOffset;
    }


    public void setHorizontalOffset(float newHorizontalOffset) {
        horizontalOffset = newHorizontalOffset;
    }
}
