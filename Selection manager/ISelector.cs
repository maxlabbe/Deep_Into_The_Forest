using UnityEngine;

public interface ISelector
{
    bool Check(Ray ray);
    Transform GetSelection();
}