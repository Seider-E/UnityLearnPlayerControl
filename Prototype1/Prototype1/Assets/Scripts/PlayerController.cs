using UnityEngine;

public class PlayerController : MonoBehaviour

{
    //Private variables for this GameObject
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardImput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where the computer gets the imputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardImput = Input.GetAxis("Vertical");

        //Move the vehichle forward  
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardImput);
        //This lets the vehicle turn
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
       
       
             
    }
}
