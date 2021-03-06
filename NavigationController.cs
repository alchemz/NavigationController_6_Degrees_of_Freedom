using UnityEngine;

// Basic flight controller designed to demonstrate Gimble Locking in 3D space.
// This works by calculating rotation based on Euler angles instead of other methods.
public class NavigationController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private Vector3 _rotation;
    	
	void Start()
	{
	    rotation = this.transform.rotation.eulerAngles;	
	}

	void Update ()
	{
	    rotation += new Vector3(
            Input.GetAxis("Pitch") * rotationSpeed * Time.deltaTime,
            Input.GetAxis("Yaw") * rotationSpeed * Time.deltaTime,
            Input.GetAxis("Roll") * rotationSpeed * Time.deltaTime);
	    this.transform.rotation = Quaternion.Euler(rotation);

	    this.transform.position += this.transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
	    this.transform.position += this.transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }
    
}
