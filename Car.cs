// Car uppgift

class Car
{
    // Property for the age of the car
    public double Age { get; set; }

    // Property for insurance
    public bool Insurance { get; set; }

    // Method to check the age and insurance of the car
    public string CheckAge()
    {
        // Car is older than 5 years and does not have insurance
        if (Age > 5 && Insurance == false)
        {
            return "Ej godkänt";
        }

        // Car is younger than 5 years and has insurance
        else if (Age < 5 && Insurance == true)
        {
            return "Godkänt";
        }

        // All other cases
        else
        {
            return "Måste kompletteras";
        }
    }
}