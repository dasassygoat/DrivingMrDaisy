
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]private float steerSpeed = 0.1f;
    [SerializeField]private float moveSpeed = 0.01f;

    // Update is called once per frame
    private void Update()
    {
        var steerAmount = Input.GetAxis("Horizontal");
        var moveAmount = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, steerSpeed * -steerAmount * Time.deltaTime); //rotate the car

        transform.Translate(0, moveSpeed * moveAmount * Time.deltaTime, 0); //move the car forward
    }
}
