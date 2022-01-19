using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/********************/
/* M. Luethje, 2022 */
/********************/

/// <summary>
/// Responsible for all the UI handling.
/// Handles all the user input and updates
/// the UI accordingly.
/// </summary>
public class UIController : MonoBehaviour
{
    /************************************
     * Public attributes
     ************************************/

    public GameController gameCon;
    public TMPro.TextMeshProUGUI numberText;

    /************************************
     * Private attributes
     ************************************/

    private int tps; //Ticks per second. Tells how often calculations are done every second.

    /************************************
     * Public methods
     ************************************/

    /// <summary>
    /// Gets called when a manual click happens.
    /// </summary>
    /// <returns>Errorcode.</returns>
    public void ManualClick()
    {
        gameCon.ManualClick();
        DisplayNumber();
    }

    /************************************
     * Private methods
     ************************************/

    /// <summary>
    /// Gets calld once at program start;
    /// </summary>
    private void Start()
    {
        DisplayNumber();
    }

    /// <summary>
    /// Displays the current number.
    /// </summary>
    /// <returns>Errorcode.</returns>
    private int DisplayNumber()
    {
        numberText.text = gameCon.GetCurrentNumber().ToString();
        return 0;
    }
}
