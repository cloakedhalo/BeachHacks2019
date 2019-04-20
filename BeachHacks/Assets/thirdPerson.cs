using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdPerson : MonoBehaviour
{
    public Transform target;
    public float walkDistance;
    public float runDistance;
    public float height;

    private Transform _myTransform;
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
            Debug.LogWarning("No target detected");
        _myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        _myTransform.position = new Vector3(target.position.x, target.position.y + height, target.position.z - walkDistance);
    }
}
