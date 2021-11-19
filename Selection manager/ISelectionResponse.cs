using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interface of SelectionReponse
internal interface ISelectionResponse
{
    void OnDeselect(Transform selectedObject);
    void OnSelect(Transform selectedObject);
}
