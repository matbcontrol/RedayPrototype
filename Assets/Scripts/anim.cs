using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    Animator animator;
    public AudioSource moveSound;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if(GetComponent<Move>().speed>0.4f){
            animator.SetBool("walk", true);
            if (moveSound.isPlaying) return;
            moveSound.Play();
        }
        else{animator.SetBool("walk", false);
        moveSound.Stop();}


    }
}
