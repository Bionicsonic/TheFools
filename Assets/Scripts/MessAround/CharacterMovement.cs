using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

public float turnSpeed= 10.0f;
public float moveSpeed= 10.0f;
public float jumpSpeed= 5.0f;
public float mouseTurnMultiplier= 2f;
public CollisionInfo collisions;

private float x;
private float z;

Vector3 velocity;

Rigidbody rigidbody;

void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}

void Update (){

	
	x = 0;
	
	z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		transform.Translate(0, 0, z);

	Input.GetAxis("Horizontal");{
		x = Input.GetAxis("Horizontal");
			}
		transform.Rotate(0, x, 0);
		}

	void FixedUpdate() {
	transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX;
	transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
	transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ;
		rigidbody.position += velocity * Time.deltaTime;
       
        if (Input.GetButtonDown("Jump")){
            rigidbody.velocity = new Vector3(0, jumpSpeed, 0);
        }
	}

	public struct CollisionInfo {
		public bool above, below;
		public bool left, right;

		public void Reset(){
			above = below = false;
			left = right = false;
		}
	}
}