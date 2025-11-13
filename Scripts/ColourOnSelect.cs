using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColourOnSelect : MonoBehaviour {
  private Renderer rend;
  private Color originalColor;

  void Awake() {
    rend = GetComponent<Renderer>();
    originalColor = rend.material.color;
  }

  public void OnSelectEntered(SelectEnterEventArgs args) {
    rend.material.color = Color.green;
  }

  public void OnSelectExited(SelectExitEventArgs args) {
    rend.material.color = originalColor;
  }
}
