using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalMove = Input.GetAxis("Horizontal");
        var verticalMove = Input.GetAxis("Vertical");

        transform.position += new Vector3(horizontalMove, verticalMove, 0) * speed * Time.deltaTime;
    }
}
