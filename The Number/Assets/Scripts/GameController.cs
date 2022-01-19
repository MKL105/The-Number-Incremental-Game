using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/********************/
/* M. Luethje, 2022 */
/********************/

/// <summary>
/// Primary functions of the game.
/// Responsible for all the background math.
/// </summary>
public class GameController : MonoBehaviour
{
    /************************************
     * Public attributes
     ************************************/


    /************************************
     * Private attributes
     ************************************/

    private float numberCount;
    private float clickPower;

    /************************************
     * Public methods
     ************************************/

    /// <summary>
    /// Gets called if a manual click happens.
    /// </summary>
    /// <returns>Errorcode.</returns>
    public int ManualClick ()
    {
        IncreaseNumber(clickPower);
        return 0;
    }

    /// <summary>
    /// Returns the current number.
    /// </summary>
    /// <returns>The current number.</returns>
    public float GetCurrentNumber()
    {
        float num = (float) Math.Round(numberCount, 3);
        return num;
    }

    /************************************
     * Private methods
     ************************************/

    /// <summary>
    /// Gets called once at the beginning of the program.
    /// </summary>
    private void Start ()
    {
        numberCount = 0;
        clickPower = 1;
    }

    /// <summary>
    /// Increases the number by the specified amount.
    /// </summary>
    /// <param name="number">Amount the number should be increased by.</param>
    /// <returns>Errorcode.</returns>
    private int IncreaseNumber (float number)
    {
        numberCount += number;
        return 0;
    }




}
