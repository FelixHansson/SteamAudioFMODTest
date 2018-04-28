using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    private CharacterController mCharacterController;

    private void Awake()
    {
        mCharacterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

        float rotationY = Input.GetAxis("Mouse X");

        transform.Rotate(transform.up, rotationY);

        mCharacterController.Move(transform.TransformVector(movement));
    }
}