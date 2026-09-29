// Car uppgift
class Car
{// Properties for the Car class
    public double Age { get; set; }
	// Property for Insurance 
    public bool Insurance { get; set; }
// Method to check the age and insurance of the car
    public string CheckAge()
    {// Check if the car is older than 5 years and does not have insurance
        if (Age > 5 && Insurance == false)
        {
            return "Ej godkänd";
        }// Check if the car is older than 5 years and has insurance
		else if (Age > 5 && Insurance == true)
		{
			return "Godkänd";
		}// Check if the car is younger than 5 years and does not have insurance
		else if (Age < 5 && Insurance == false)
		{
			return "Ej godkänd";
		}// Check if the car is younger than 5 years and has insurance
        else if (Age < 5 && Insurance == true)
        {
            return "Godkänd";
        }// If none of the above conditions are met, return a default message
        else
        {
            return "Måste kompletteras";
        }
    }
}