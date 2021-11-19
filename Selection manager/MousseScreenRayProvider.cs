using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MousseScreenRayProvider : MonoBehaviour, IRayProvider
{
    public Ray CreateRay()
    {
        return Camera.main.ViewportPointToRay(Vector3.one / 2f);
    }
}