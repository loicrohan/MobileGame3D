using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                RaycastHit hitInfo;
                if(Physics.Raycast(ray,out hitInfo))
                {
                    if(hitInfo.collider != null)
                    {
                        Color color = new Color(Random.value, Random.value, Random.value);
                        hitInfo.collider.gameObject.GetComponent<MeshRenderer>().material.color = color;
                    }
                }
            }
        }
    }
}
