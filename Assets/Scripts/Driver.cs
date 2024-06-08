
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]private float steerSpeed = 200f;
    [SerializeField]private float moveSpeed = 20f;
    [SerializeField]private float bumpSpeed = 10f;
    [SerializeField]private float boostSpeed = 50f;

    // Update is called once per frame
    private void Update()
    {
        var steerAmount = Input.GetAxis("Horizontal");
        var moveAmount = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, steerSpeed * -steerAmount * Time.deltaTime); //rotate the car

        transform.Translate(0, moveSpeed * moveAmount * Time.deltaTime, 0); //move the car forward
    }

    /// <summary>
    /// Handles the event when a 2D collider enters the trigger area.
    /// </summary>
    /// <param name="other">The collider that entered the trigger area.</param>
    /// <remarks>
    /// If the collider has the tag "Bump", the moveSpeed is set to bumpSpeed and a debug log is printed.
    /// If the collider has the tag "Boost", the moveSpeed is set to boostSpeed and a debug log is printed.
    /// </remarks>
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
