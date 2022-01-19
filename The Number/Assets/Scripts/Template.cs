using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/********************/
/* Author, year     */
/********************/

/// <summary>
/// Class description.
/// </summary>
public class Template : MonoBehaviour
{
    /************************************
     * Public attributes
     ************************************/

    // Attributes are starting with a small letter and use camelcase.
    // Comments are in the same line.
    // Long comments are located over the attribute.
    public string attributeExample;

    public int anotherExample; //Normal comment.

    /************************************
     * Private attributes
     ************************************/

    /************************************
     * Public methods
     ************************************/

    /// <summary>
    /// Method description.
    /// </summary>
    /// <param name="x">Parameter description.</param>
    /// <returns>Return value description.</returns>
    public int ExampleMethod (int x) // Methods should contain a space before the brackets in the method definition.
    {
        //Something happens here...
        return 0;                   // If possible methods should return an errorcode.
    }

    /************************************
     * Private methods
     ************************************/

    /// <summary>
    /// Method description.
    /// </summary>
    /// <param name="x">Parameter description.</param>
    /// <returns>Return value description.</returns>
    private int ExampleMethod2 (int x)
    {
        //Something happens here...
        return 0;
    }
}
