using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class tweeinig : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    var image = this.GetComponent<Image>();
    var tw = image
        .DOColor(Color.black, 0.5f);


    if (tw.IsComplete())
    {
      // TODO jalanin anim draw
      // domove
      Debug.Log("complete");
    }
    else
    {
      tw.OnComplete(() =>
      {
        // todo jalanin anim draw
        // domove
        Debug.Log("wait complete");
      });
    }

    AnimateBack(0f);
  }

  // Update is called once per frame
  void Update()
  {

  }

  void AnimateBack(float delay = 1f)
  {
    var tw = gameObject.transform
    .DOMove(Vector3.zero, 1f)
    .SetDelay(delay);
    gameObject.SetActive(true);
  }
}
