using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseLook : MonoBehaviour
{
    private float mouseX;
    private float mouseY;
    [Header("Чувствительность мыши")]
    [SerializeField] private float sensitive = 200f;
    [SerializeField] private Transform Player;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitive * Time.deltaTime ;
        mouseY = Input.GetAxis("Mouse Y") * sensitive * Time.deltaTime;
        Player.Rotate(mouseX * new Vector3(0, 1, 0));
        transform.Rotate(-mouseY * new Vector3(1, 0, 0));
    }
}
