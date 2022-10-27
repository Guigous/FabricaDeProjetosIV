using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookShot : MonoBehaviour
{
    public LayerMask layerMask;
    public Camera cam;
    



    private void Awake()
    {
        cam = FindObjectOfType<Camera>();
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Hook();
        }
        
    }



    private void Hook()
    {
        Rigidbody rbhit;

        if(Physics.Raycast(cam.transform.position,cam.transform.forward, out RaycastHit raycastHit))
        {
            rbhit = raycastHit.transform.GetComponent<Rigidbody>();

            rbhit.velocity = Vector3.MoveTowards(rbhit.position, cam.transform.position, 50f);
        }
    }
}
