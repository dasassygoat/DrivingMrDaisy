
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]private float steerSpeed = 200f;
    [SerializeField]private float moveSpeed = 20f;
    private float bumpSpeed = 10f;
    private float boostSpeed = 50f;

    // Update is called once per frame
    private void Update()
    {
        var steerAmount = Input.GetAxis("Horizontal");
        var moveAmount = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, steerSpeed * -steerAmount * Time.deltaTime); //rotate the car

        transform.Translate(0, moveSpeed * moveAmount * Time.deltaTime, 0); //move the car forward
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bump")
        {
            moveSpeed = bumpSpeed;
            Debug.Log("Bumped");
            Debug.Log("Speed: " + moveSpeed);
        }
        else if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            Debug.Log("Boost");
            Debug.Log("Speed: " + moveSpeed);
        }
    }


}
