using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlOnXZPlane : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Unit per Second")]
    private float _movementSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-_movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(_movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0, 0, _movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0, 0, -_movementSpeed * Time.deltaTime);
        }
    }
}
