using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveScreen : MonoBehaviour
{
    public float speed = 8f;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (anim.GetBool("isCTFinished"))
        {
            transform.position += Vector3.right * (speed / 100);
        }
    }
}
