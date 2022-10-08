using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimator : MonoBehaviour
{
  public Animator anim;
  public Animation animClips;
  // Start is called before the first frame update
  void Start()
  {
    if (anim == null || animClips == null) return;
    animClips.Play();
  }

  // Update is called once per frame
  void Update()
  {

  }
}
