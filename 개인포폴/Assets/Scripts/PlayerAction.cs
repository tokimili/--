using UnityEngine;

public class PlayerAction : AnimProperty
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        myAnim.SetFloat("X", x);
        myAnim.SetFloat("Y", y);
        
        if(Input.GetKey(KeyCode.LeftShift))
        {
            myAnim.SetBool("isRunning", true);
        }
        else
        {
            myAnim.SetBool("isRunning", false);
        }
    }
}
