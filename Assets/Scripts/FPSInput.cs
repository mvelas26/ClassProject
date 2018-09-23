using UnityEngine;
using System.Collections;

// basic WASD-style movement control
// commented out line demonstrates that transform.Translate instead of charController.Move doesn't have collision detection

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour {

    /*
	public float speed = 6.0f;
	public float gravity = -9.8f;

	private CharacterController _charController;
	*/
    private RigidBody ballRigid;
    public float speed-1;
	void Start() {
        //_charController = GetComponent<CharacterController>();
        ballRigid = GetComponent<Rigidbody>();

	}
	
	void Update() {
<<<<<<< HEAD
		transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
		float deltaX = Input.GetAxis("Horizontal") * speed;
=======
        //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        /*
        float deltaX = Input.GetAxis("Horizontal") * speed;
>>>>>>> 5925e2ff2144ac3c703059a2012f9c5e33268f6f
		float deltaZ = Input.GetAxis("Vertical") * speed;
		Vector3 movement = new Vector3(deltaX, 0, deltaZ);
		movement = Vector3.ClampMagnitude(movement, speed);

		movement.y = gravity;

		movement *= Time.deltaTime;
		movement = transform.TransformDirection(movement);
		_charController.Move(movement);

*/
        Ball_Rigid.AddForce(new Vector3(-10 * Speed, 0, 0));

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Ball_Rigid.MovePosition(new Vector3(transform.position.x, transform.position.y, transform.position.z - 1.0f));
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Ball_Rigid.MovePosition(new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.0f));
        }
  



}
}
