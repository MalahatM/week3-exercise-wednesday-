// Temperatur uppgift

// Class Temperatur
class Temperatur
{
    public double Temperature { get; set; }

    // Method to check the temperature
    public string CheckTemperature()
    {
        // Check if the temperature is below 0
        if (Temperature < 0)
        {
            return "Det är minusgrader";
        }

        // Check if the temperature is between 0 and 30
        else if (Temperature >= 0 && Temperature <= 30)
        {
            return "Normal temperatur";
        }

        // Temperature is above 30
        else
        {
            return "Varning för hög värme";
        }
    }
}