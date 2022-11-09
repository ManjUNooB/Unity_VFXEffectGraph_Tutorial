using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMovement : MonoBehaviour
{
    [SerializeField] float X_Movement;
    [SerializeField] float Y_Movement;

    Vector3 Pos;

    // Start is called before the first frame update
    void Start()
    {
        Pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
		{
            Pos.y += Y_Movement;
		}
        if(Input.GetKey(KeyCode.S))
		{
            Pos.y -= Y_Movement;
		}
        if (Input.GetKey(KeyCode.A))
		{
            Pos.x -= X_Movement;
		}
        if (Input.GetKey(KeyCode.D))
		{
            Pos.x += X_Movement;
		}

        transform.position = Pos;
    }
}
