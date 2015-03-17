using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIUpdateBackGround : MonoBehaviour {

    public GameObject backGround;
    public GameObject foreGround;

    //Test
    public float timeStamp = 0.0f;

    void Update()
    {
        if ((timeStamp += Time.deltaTime) >= 0.5f)
        {
            this.ChangeGround(Random.Range(1, 3));
            timeStamp = 0.0f;
        }
    }

    void ChangeGround(int index)
    {
        backGround.GetComponent<Image>().sprite = ResourcesController.Instance.GetSprite(
                                                   ResourcesPath.Instance.mBackGroundPath + index);
        foreGround.GetComponent<Image>().sprite = ResourcesController.Instance.GetSprite(
                                                ResourcesPath.Instance.mForeGroundPath + index);
    }
}
