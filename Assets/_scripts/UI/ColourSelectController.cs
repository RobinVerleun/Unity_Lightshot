using UnityEngine;
using UnityEngine.UI;

public class ColourSelectController : MonoBehaviour {

    private GameObject currentChild;

    private void Start()
    {
        currentChild = gameObject.transform.GetChild(0).gameObject;
        ToggleHighlight(currentChild);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            updateSelection(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            updateSelection(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            updateSelection(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            updateSelection(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            updateSelection(4);
        }
    }

    private void updateSelection(int index)
    {
        ToggleHighlight(currentChild);
        currentChild = gameObject.transform.GetChild(index).gameObject;
        GameState.bulletColor = GameState.colors[index];
        ToggleHighlight(currentChild);
    }

    private void ToggleHighlight(GameObject child)
    {
        Image image = child.GetComponent<Image>();
        image.fillCenter = !image.fillCenter;
    }
}
