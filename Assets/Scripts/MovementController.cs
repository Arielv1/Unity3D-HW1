using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private CharacterController cc;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rotationSpeed = 0.001f;
    private float rotX, rotY;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        rotX -= Input.GetAxis("Mouse Y") * rotationSpeed;
        rotY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * rotationSpeed;
        transform.localEulerAngles = new Vector3(rotX, rotY, 0);
    }

    void MovePlayer()
    {
        float dx = Input.GetAxis("Horizontal");
        float dz = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(dx, 0, dz).normalized * speed * Time.deltaTime;

        // Transforms direction from local space to world space.
        direction = transform.TransformDirection(direction);

        cc.Move(direction);
    }

}

