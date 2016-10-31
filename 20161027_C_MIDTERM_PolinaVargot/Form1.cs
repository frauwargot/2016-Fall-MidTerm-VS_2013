using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20161027_C_MIDTERM_PolinaVargot
{
    public partial class CarsForm : Form
    {
        //============================================================================================================================
        //4.	In Form1, create a List of cars to hold all the cars, sportcars and trucks
        List<Car> ListOfCars = new List<Car>();      

        public CarsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //In Form1_Load, add at least 10 cars, 10 sportcars, and 10 trucks
            //(try to add them randomly, by that I mean avoid adding 10 cars, followed by 10 sportcars and so on, instead interleave them. 
            //Also a customerID may be the same in 2 or more cars,sportscar, and/or trucks. 
            //That allows a customer to own more than one vehicle.

            Car car1 = new Car("VW", "Vanagon", 150000, 1985, 5000, "1.9", 18, 10001);
            ListOfCars.Add(car1);
            SportCar sportcar1 = new SportCar("Chevrolet", "Camaro", 3000, 2017, 25000, "4.0", 15, 10001, 10);
            ListOfCars.Add(sportcar1);
            Truck truck1 = new Truck("Dodge", "Ram", 50000, 2010, 15000, "5.9", 12, 10002, 13000);
            ListOfCars.Add(truck1);

            Car car2 = new Car("VW", "Vanagon", 100000, 1989, 15000, "2.1", 17, 10002);
            ListOfCars.Add(car2);
            SportCar sportcar2 = new SportCar("Chevrolet", "Corvette", 3000, 2017, 55000, "5.0", 16, 10003, 8);
            ListOfCars.Add(sportcar2);
            Truck truck2 = new Truck("Dodge", "Ram", 90000, 2005, 9000, "3.5", 14, 10003, 11000);
            ListOfCars.Add(truck2);

            Car car3 = new Car("Toyota", "Sienna", 180000, 1999, 4000, "2.1", 19, 10004);
            ListOfCars.Add(car3);
            SportCar sportcar3 = new SportCar("Mazda", "MX-5", 5000, 2015, 24000, "4.0", 18, 10005, 10);
            ListOfCars.Add(sportcar3);
            Truck truck3 = new Truck("Chevy", "Avalanche", 99000, 2005, 15000, "5.9", 10, 10005, 13000);
            ListOfCars.Add(truck3);

            Car car4 = new Car("VW", "Jetta", 110000, 2001, 5000, "1.8", 23, 10006);
            ListOfCars.Add(car4);
            SportCar sportcar4 = new SportCar("Ford", "Mustang", 3000, 2016, 24000, "5.0", 14, 10006, 9);
            ListOfCars.Add(sportcar4);
            Truck truck4 = new Truck("Chevy", "Silverado", 2000, 2017, 27000, "3.2", 15, 10007, 11000);
            ListOfCars.Add(truck4);

            Car car5 = new Car("Toyota", "Corolla", 90000, 2009, 10000, "2.5", 20, 10007);
            ListOfCars.Add(car5);
            SportCar sportcar5 = new SportCar("Toyota", "86", 2000, 2017, 26000, "5.0", 11, 10008, 8);
            ListOfCars.Add(sportcar5);
            Truck truck5 = new Truck("Ford", "F-150", 500, 2016, 27000, "5.9", 12, 10008, 13000);
            ListOfCars.Add(truck5);

            Car car6 = new Car("VW", "Westfalia", 190000, 1985, 15000, "1.9", 18, 10008);
            ListOfCars.Add(car6);
            SportCar sportcar6 = new SportCar("Dodge", "Challenger", 3000, 2015, 25000, "4.0", 15, 10009, 10);
            ListOfCars.Add(sportcar6);
            Truck truck6 = new Truck("Toyota", "Tacoma", 1000, 2017, 25000, "3.0", 16, 10010, 11000);
            ListOfCars.Add(truck6);

            Car car7 = new Car("Toyota", "4runner", 1000, 2017, 45000, "3.0", 19, 10011);
            ListOfCars.Add(car7);
            SportCar sportcar7 = new SportCar("Porsche", "911", 1000, 2017, 89000, "5.9", 12, 10012, 7);
            ListOfCars.Add(sportcar7);
            Truck truck7 = new Truck("Toyota", "Tundra", 5000, 2015, 25000, "5.9", 12, 10012, 15000);
            ListOfCars.Add(truck7);

            Car car8 = new Car("Honda", "Odyssey", 10000, 2014, 30000, "3.0", 18, 100013);
            ListOfCars.Add(car8);
            SportCar sportcar8 = new SportCar("Subaru", "BRZ", 2000, 2016, 25000, "5.0", 13, 10014, 9);
            ListOfCars.Add(sportcar8);
            Truck truck8 = new Truck("Ford", "F-250", 50000, 2010, 15000, "5.9", 12, 10015, 16000);
            ListOfCars.Add(truck8);

            Car car9 = new Car("Honda", "Civic", 10000, 2013, 18000, "1.9", 21, 100015);
            ListOfCars.Add(car9);
            SportCar sportcar9 = new SportCar("Nissan", "GT-R", 1000, 2017, 109000, "6.0", 12, 100016, 6);
            ListOfCars.Add(sportcar9);
            Truck truck9 = new Truck("Dodge", "Ram2500", 5000, 2015, 35000, "5.9", 12, 10016, 16000);
            ListOfCars.Add(truck9);

            Car car10 = new Car("Honda", "Accord", 10000, 2005, 10000, "1.9", 19, 100017);
            ListOfCars.Add(car10);
            SportCar sportcar10 = new SportCar("Audi", "TT", 1000, 2017, 45000, "4.0", 15, 10017, 10);
            ListOfCars.Add(sportcar10);
            Truck truck10 = new Truck("Dodge", "Ram1500", 50000, 2010, 15000, "5.9", 12, 10018, 13000);
            ListOfCars.Add(truck10);
   //=======================================end of ex.4===========================================
        }
   //===============================================================================================
        //5.	Add a method ‘DisplayCars’ that takes a list of cars and display the list in a listview,
        //then add a button to display all the cars in the cars list.
        private void DisplayListOfCars(List<Car> ccc)
        {
            listView1.Items.Clear();
            string[] tempString = new string[10];
            ListViewItem tempListviewItem;
            foreach (Car car in ccc)
            {
                if (car is Truck)
                {
                    Truck t = (Truck)car;
                    tempString[0] = t.Make;
                    tempString[1] = t.Model;
                    tempString[2] = t.Milage.ToString();
                    tempString[3] = t.Year.ToString();
                    tempString[4] = t.Price.ToString("c");
                    tempString[5] = t.EngineSize;
                    tempString[6] = t.AverageMpg.ToString();
                    tempString[7] = t.CustomerID.ToString();
                    tempString[8] = "";
                    tempString[9] = t.MaxTowing.ToString();

                    tempListviewItem = new ListViewItem(tempString);
                    listView1.Items.Add(tempListviewItem);
                }
                else if (car is SportCar)
                {
                    SportCar s = (SportCar)car;
                    tempString[0] = s.Make;
                    tempString[1] = s.Model;
                    tempString[2] = s.Milage.ToString();
                    tempString[3] = s.Year.ToString();
                    tempString[4] = s.Price.ToString("c");
                    tempString[5] = s.EngineSize;
                    tempString[6] = s.AverageMpg.ToString();
                    tempString[7] = s.CustomerID.ToString();
                    tempString[8] = s.ZeroToSixty.ToString();
                    tempString[9] = "";

                    tempListviewItem = new ListViewItem(tempString);
                    listView1.Items.Add(tempListviewItem);
                }
                else
                {
                    tempString[0] = car.Make;
                    tempString[1] = car.Model;
                    tempString[2] = car.Milage.ToString();
                    tempString[3] = car.Year.ToString();
                    tempString[4] = car.Price.ToString();
                    tempString[5] = car.EngineSize;
                    tempString[6] = car.AverageMpg.ToString();
                    tempString[7] = car.CustomerID.ToString();
                    tempString[8] = "";
                    tempString[9] = "";
                    tempListviewItem = new ListViewItem(tempString);
                    listView1.Items.Add(tempListviewItem);
                }
            }
        }

        private void btnDisplayAllCars_Click(object sender, EventArgs e)
        {
            DisplayListOfCars(ListOfCars);
        }
 //=================================================end of ex.5======================================
//===================================================================================================
 //6.	Add a method GetMostExpensiveCar(…). This method should take a car list and return 
 //the most expensive car. Add a button that calls the method and display the most expensive car.
        private Car GetMostExpensiveCar()//method
        {
            Car c = ListOfCars[0];
            for (int i=0; i < ListOfCars.Count; i++ )
            {
                if (ListOfCars[i].Price > c.Price)
                    c = ListOfCars[i];
            }
            return c;
        }

        private void btnDisplayMostExpensiveCar_Click(object sender, EventArgs e)//button
        {
            Car c1 = GetMostExpensiveCar();
            List<Car> tempList = new List<Car>();
            tempList.Add(c1);
            DisplayListOfCars(tempList);
        }
//=======================================end of ex.6====================================================
 //====================================================================================================
//7.	Add a method ‘GetCarsByMake(….)’. This method takes a car make and returns a list of cars of 
        //the given make. Add a button to call the method, pass to it a car make from user input 
        //and display the results
        private List<Car> GetCarsByMake(string M)//method
        {
            List<Car> tempList = new List<Car>();
            for (int i =0; i<ListOfCars.Count; i++)
            {
                if (ListOfCars[i].Make==M)
                {
                    tempList.Add(ListOfCars[i]);
                }
            }
            return tempList;
        }

        private void btnGetCarsByMade_Click(object sender, EventArgs e)//button
        {          
                string make = txtMadeInput.Text.Trim();
                List<Car> tempL = GetCarsByMake(make);
                if (tempL.Count == 0)
                    MessageBox.Show("Your input make is not found");
                else
                    DisplayListOfCars(tempL);           
        }
//====================================end of ex.7========================================================
//=======================================================================================================
//8.	Add a method ‘GetCarsByCustomerID(….)’. This method takes a customerID and returns a list of cars 
        //owned by this customer. Add a button to call the method, pass to it a customerID from 
        //user input, then display the results.
        private List<Car> GetCarsByCustomerID(int customerID)//method
        {
            List<Car> tempList = new List<Car>();
            for (int i = 0; i < ListOfCars.Count; i++)
            {
                if (ListOfCars[i].CustomerID == customerID)
                {
                    tempList.Add(ListOfCars[i]);
                }
            }
            return tempList;
        }

        private void btnGetCarsByCustomerID_Click(object sender, EventArgs e)//button
        {
            try
            {
                int cusID = int.Parse(txtInputCustomerID.Text);
                List<Car> tempL = GetCarsByCustomerID(cusID);
                if (tempL.Count == 0)
                    MessageBox.Show("Your input make is not found");
                else
                    DisplayListOfCars(tempL);
            }
            catch (FormatException fe)
            { MessageBox.Show(fe.Message); }
            catch (ArgumentException ae)
            { MessageBox.Show(ae.Message); }
        }
//============================================end of ex.8===============================================
//======================================================================================================
//9.	Add a method ‘GetCarsByType(….)’.  This method takes the type of car, example: 
//Car, SportCar, Truck, and returns a list of cars of the given type
//Provide a textbox or combobox for the user to enter a type. Add a button to call this method and 
//display its results
        private List<Car> GetCarsByType(string T)//method
        {
            List<Car> tempList = new List<Car>();
            for (int i = 0; i < ListOfCars.Count; i++)
            {
                if (T == "Sport Car")
                {
                    if (ListOfCars[i] is SportCar)
                        tempList.Add(ListOfCars[i]);                    
                }
                else if (T=="Truck")
                {
                    if (ListOfCars[i] is Truck)                   
                        tempList.Add(ListOfCars[i]);                   
                }
                else                
                    tempList.Add(ListOfCars[i]);               

            }
            return tempList;
        }

        private void btnGetCarsByType_Click(object sender, EventArgs e)//button
        {
            if (cboInputCarType.SelectedIndex < 0)
                MessageBox.Show("Select Car Type");
            else
            {
                string type = cboInputCarType.SelectedItem.ToString();
                List<Car> tempL = GetCarsByType(type);
                DisplayListOfCars(tempL);
            }
        }
//=====================================end of ex.9========================================================
    }
}
