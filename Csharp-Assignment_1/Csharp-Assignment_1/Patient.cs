using System;
namespace Csharp_Assignment_1
{
	public class Patient
	{
        private string firstname;
        private string lastname;
        private double weight;
        private double height;
        private int systolic;
        private int diastolic;

        public Patient(string firstname, string lastname, double weight, double height, int systolic, int diastolic)
        {
            FirstName = firstname;
            LastName = lastname;
            Weight = weight;
            Height = height;
            Systolic = systolic;
            Diastolic = diastolic;
        }//constructor

        //setter/getter
        public string FirstName { get => firstname; set => firstname = value; }
        public string LastName { get => lastname; set => lastname = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Height { get => height; set => height = value; }
        public int Systolic { get => systolic; set => systolic = value; }
        public int Diastolic { get => diastolic; set => diastolic = value; }

        //Blood Pressure method
        string BloodPressure(int Systolic, int Diastolic)
        {
            string comment;
            if (Systolic<120 && Diastolic < 80)
            {
                comment = "NORMAL";

            }else if (Systolic < 130 && Diastolic < 80)
            {
                comment = "ELEVATED";

            }else if (Systolic < 140 || Diastolic < 90)
            {
                comment = "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE1";

            }else if (Systolic < 180 || Diastolic < 120)
            {
                comment = "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE2";

            }
            else if ((Systolic > 180 && Diastolic > 120) || (Systolic > 180 || Diastolic > 120))
            {
                comment = "HIGHPERTENSIVE CRYCIS (Consult your doctor immediately";
            }
            else {
                comment = "Please input your systolic and diastolic properly.)";
            }

            return comment;
            //System.Console.WriteLine($"Your blood pressure is Systolic: {Systolic} / Diastolic:  {Diastolic}. Result: {comment}");
        }

        //BMI method
        double BMI(double Height, double Weight)
        {
            double CmToMeter = Height / 100;
            //kg/m x m
            double resultBMI = Weight / CmToMeter * CmToMeter;
            return resultBMI;
        }

        string PatientInformation(string firstname, string lastname, double weight, double height)
        {
            System.Console.WriteLine($"Name: {firstname} {lastname}");
            System.Console.WriteLine($"Weight: {weight}");
            System.Console.WriteLine($"Height: {height}");
            System.Console.WriteLine($"Blood pressure: {height}");


        }
        }
    } // class
} // namespace
