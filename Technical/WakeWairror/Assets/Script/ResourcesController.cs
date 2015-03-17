using UnityEngine;
using System.Collections;

public class ResourcesController : Singleton<ResourcesController> {

    public Sprite GetSprite(string path)
    {
        return Resources.Load<Sprite>(path);
    }
}
