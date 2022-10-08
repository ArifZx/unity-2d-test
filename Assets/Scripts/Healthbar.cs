using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

  public Image healthImg;

  public float maxHealth = 100f;

  [SerializeField]
  private float health = 100f;

  public float healthPercentage
  {
    get { return this.health / this.maxHealth; }
    set
    {
      float percent = Mathf.Clamp01(value);
      this.health = percent * this.maxHealth;
    }
  }

  void Start()
  {
    this.healthPercentage = 0.50f;
    // posion
    this.healthPercentage -= 0.01f;
    DrawHealth();
  }

  public void SetHealth(float value)
  {
    this.health = Mathf.Clamp(value, 0, this.maxHealth);
  }

  private void DrawHealth()
  {
    if (this.healthImg == null) return;

    this.healthImg.fillAmount = this.healthPercentage;
  }
}
