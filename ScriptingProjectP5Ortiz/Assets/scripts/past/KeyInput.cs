using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine.UI;
using UnityEngine; 

public class KeyInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;
    // Start is called before the first frame update
    void Start()
    {
        graphic.sprite = standard;
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Backspace);
        bool up = Input.GetKeyDown(KeyCode.LeftShift);

        if (down)
        {
            graphic.sprite = downgfx;
        }
        else if (held)
        {
            graphic.sprite = heldgfx;
        }
        else if (up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = standard;
        }

        boolDisplay1.text =" " + down;
        boolDisplay2.text =" " + held;
        boolDisplay3.text =" " + held;
    }
}
