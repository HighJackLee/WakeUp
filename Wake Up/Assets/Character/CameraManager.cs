using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public GameObject target;
    public float moveSpeed;
    private Vector3 targetPosition;

    void Start()
    {
        
    }

    void Update()
    {
        if(target.gameObject != null)
        {
            targetPosition.Set(target.transform.position.x + 5, target.transform.position.y + 2, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}
