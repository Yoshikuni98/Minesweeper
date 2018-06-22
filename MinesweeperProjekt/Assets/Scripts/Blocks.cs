using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks {

    bool isBomb;
    int number;
    bool isPressed;
    bool isFlaged;

    public Blocks(bool _isBomb, int _number, bool _isPressed, bool _isFlaged)
    {
        isBomb = _isBomb;
        number = _number;
        isPressed = _isPressed;
        isFlaged = _isFlaged;
    }



}
