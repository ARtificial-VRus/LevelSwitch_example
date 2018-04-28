using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    //Scope:
    //      We want to check for player input every frame 
    //      and then apply this keybord input as movement

    //      The fixedUpdate function will be executed 
    //      before any physics calc. is done, so we can 
    //      use this to code the physics behaviour which is
    //      the movement (forces on an object)

    #region Declaration
    // We use public to adjust the speed from the unity interface
    public float speed = 10f;
    // we need a refernce to the rigibody of this gameobject
    private Rigidbody rb;
	#endregion


	//to assign the rigitbody refernce to the compontent we use the 
	//start function
	private void Start()
	{
        rb = GetComponent<Rigidbody>();
	}
	//movement
	void FixedUpdate()
	{
        //Movement in general works with 3D Vectors. Every dimension is 
        //assigned to one axis. Changing one vector dimension changes the
        //position. Unity specifies the position through Transform-Property
        //Since this scipt is applied to the gameobject we can directly use
        //transform in the code without any reference.

        //the idea is to manipulate the transform via our keybord input, 
        //creating a "new" 3D Vector and assign this vector as a new
        //transform position.

        //declare a variable that holds the values for translation in the 
        //vertical direction

        //we want to listen to input from the keyboard
        //so we use input.getAxis since it returns the value of the axis
        //identified by the axis name.

        float moveVertical = Input.GetAxis("Vertical") * speed;
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;

        //traditional movement
        /**
        moveVertical = moveVertical * Time.deltaTime;
        moveHorizontal = moveHorizontal * Time.deltaTime;

        transform.Translate(moveHorizontal,0 ,moveVertical);
        */

        //Movement via forces and physics engine
        //the idea is to move the ball via adding forces.

        //create a new vector 3 variable to get the float values into a 
        //vector3
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); 
        rb.AddForce(movement);
	}
}
