using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MessageOnGrab : MonoBehaviour {
  public string message = "¡Has agarrado el cubo cercano!";

  public void OnSelectEntered(SelectEnterEventArgs args) {
    Debug.Log(message);
  }
}
