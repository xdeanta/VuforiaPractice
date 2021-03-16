using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TouchInteraction : MonoBehaviour
{
    public Camera ARCameraReference;
    public GameObject TextMesh;
    public Interaction intr;
    // Start is called before the first frame update
    void Start()
    {
        //TextMesh = GetComponent<TextMeshPro>();
        intr = GetComponent<Interaction>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
    {
        Ray ray = ARCameraReference.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Hit : " + hit.collider.gameObject.name);

            intr.isActive = true;
        }
    }
    }
}
