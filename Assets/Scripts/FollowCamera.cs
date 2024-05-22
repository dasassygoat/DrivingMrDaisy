using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject driver;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(driver.transform.position.x, driver.transform.position.y + 3, transform.position.z);
    }
}
