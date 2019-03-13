using UnityEngine;

public class movment : MonoBehaviour
{
    public Rigidbody r;
    
    public float ff = 2000f;
    public float sf = 500f;
    public Vector3 s;
   


    public void FixedUpdate()

    { 
        r.AddForce(0, 0, ff * (Time.deltaTime));
        if (Input.GetKey(KeyCode.D))
        {
            r.AddForce(sf * (Time.deltaTime), 0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            r.AddForce(-sf * (Time.deltaTime), 0, 0, ForceMode.VelocityChange);
        }
       // if (r.position.y < -0.5f) {
          //  FindObjectOfType<gamemanger>().endgame();
      //  }
       // s = transform.position;

    }
    
    
}
