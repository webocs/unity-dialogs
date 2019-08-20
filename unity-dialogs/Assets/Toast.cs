using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Toast : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    public bool isVisible;
    public GameObject canvas;

    private void Start()
    {
        isVisible = false;
        Transform child = transform.GetChild(0);
        if (child)
        {            
            canvas = child.gameObject;
        }
        else
            throw new System.Exception("Missing child canvas in toast component");
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if(canvas.activeInHierarchy != isVisible)
            canvas.SetActive(isVisible);
    }
    public void ShowBottomUp()
    {
        animator.SetTrigger("openBottomUp");
    }

    public void CloseBottomUp()
    {
        animator.SetTrigger("closeBottomUp");
    }


}
