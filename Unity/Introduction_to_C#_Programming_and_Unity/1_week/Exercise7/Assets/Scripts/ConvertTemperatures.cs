using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    /// <summary>
	/// Convert temperatures
	/// </summary>
    void Start()
    {
        //1.1
        int originalFahrenheitTemperature = 0;
        int celsiusTemperature;
        int fahrenheitTemperature;

        //1.2
        print("Original Fahrenheit temperature is "+ originalFahrenheitTemperature);
        
        celsiusTemperature = (originalFahrenheitTemperature - 32) * 5 / 9;
        print("Celsius temperature is " + celsiusTemperature);

        fahrenheitTemperature = (celsiusTemperature  * 9) / 5 + 32;
        print("Fahrenheit temperature is " + fahrenheitTemperature);

        //1.3
        originalFahrenheitTemperature = 32;
        print("Original Fahrenheit temperature is " + originalFahrenheitTemperature);

        celsiusTemperature = (originalFahrenheitTemperature - 32) * 5 / 9;
        print("Celsius temperature is " + celsiusTemperature);

        fahrenheitTemperature = (celsiusTemperature * 9) / 5 + 32;
        print("Fahrenheit temperature is " + fahrenheitTemperature);

        //1.4
        originalFahrenheitTemperature = 212;
        print("Original Fahrenheit temperature is " + originalFahrenheitTemperature);

        celsiusTemperature = (originalFahrenheitTemperature - 32) * 5 / 9;
        print("Celsius temperature is " + celsiusTemperature);

        fahrenheitTemperature = (celsiusTemperature * 9) / 5 + 32;
        print("Fahrenheit temperature is " + fahrenheitTemperature);

        //2.1
        float originalFahrenheitTemperatureF = 0;
        float celsiusTemperatureF;
        float fahrenheitTemperatureF;

        //2.2
        print("Original Fahrenheit F temperature is " + originalFahrenheitTemperatureF);

        celsiusTemperatureF = (originalFahrenheitTemperatureF - 32) * 5 / 9;
        print("Celsius temperature F is " + celsiusTemperatureF);

        fahrenheitTemperatureF = (celsiusTemperatureF * 9) / 5 + 32;
        print("Fahrenheit temperature F is " + fahrenheitTemperatureF);

        //3.1
        double originalFahrenheitTemperatureD = 0;
        double celsiusTemperatureD;
        double fahrenheitTemperatureD;

        //3.2
        print("Original Fahrenheit D temperature is " + originalFahrenheitTemperatureD);

        celsiusTemperatureD = (originalFahrenheitTemperatureD - 32) * 5 / 9;
        print("Celsius temperature D is " + celsiusTemperatureD);

        fahrenheitTemperatureD = (celsiusTemperatureD * 9) / 5 + 32;
        print("Fahrenheit temperature D is " + fahrenheitTemperatureD);
    }
}
