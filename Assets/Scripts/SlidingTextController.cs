using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingTextController : MonoBehaviour
{
    public float slideFactor = 0.05f;
    public float slideCeiling = 21f;
    public float startAnimThreshold = 16f;

    public GameObject cat;
    public GameObject icons;
    private Animator anim;

    private void Start()
    {
        transform.position = new Vector3(3f, -10f, 0);
        anim = cat.GetComponent<Animator>();    
    }

    private bool isStopActive = false;
    private void FixedUpdate()
    {
        if (!isStopActive && transform.position.y > startAnimThreshold && transform.position.y < (startAnimThreshold + 0.25f))
        {
            anim.SetBool("isCTFinished", true);
        }

        if (!isStopActive && transform.position.y < slideCeiling)
        {
            transform.position += Vector3.up * slideFactor;
        }
        else
        {
            StartCoroutine(EnableIcons());
        }
    }
    public IEnumerator EnableIcons()
    {
        yield return new WaitForSeconds(4f);
        icons.SetActive(true);
        StartCoroutine(CloseWindow());
    }

    public IEnumerator CloseWindow()
    {
        yield return new WaitForSeconds(2f);
        Application.Quit();
        Debug.Log("Quit");
    }

    private void OnDisable()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
