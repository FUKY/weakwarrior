using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUISkillButtonUpdate : MonoBehaviour {

	// Use this for initialization
    public Image cooldown;
    public GameObject skillOn;
    public float timeCollDown = 0.1f;
    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!skillOn.animation.isPlaying)
            skillOn.animation.Play();
        cooldown.fillAmount -= timeCollDown;
        if (cooldown.fillAmount <= 0)
        {
            skillOn.SetActive(true);
            //cooldown.fillAmount = 1;
        }

	}
}
