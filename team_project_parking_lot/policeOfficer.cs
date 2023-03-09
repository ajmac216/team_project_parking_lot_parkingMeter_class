/*
 Author: Kassidy Reynolds
 File Description: This file declares and defines the policeOfficer class,
 including the CheckSpace and IssueTicket methods.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace team_project_parking_lot
{
    internal class policeOfficer
    {
        private string name;
        private int badgeNumber;

        //Constructor for police officer
        public policeOfficer(string Name, int badge)
        {
            name = Name;
            badgeNumber = badge;
        }

        //Takes a parkedCars object and parkingMeter object as arguments and returns
        //true if the parked car is making a parking violation
        public bool CheckSpace(parkedCars carObj, parkingMeter meterObj)
        {
            if (carObj.min_parked - meterObj.purchased_mins > 0)
                return true;
            else
                return false;
        }

        //if the checked space is making a parking violation, a ticket is created and outputted
        //to the console
        public void IssueTicket(parkedCars carObj, parkingMeter meterObj)
        {
            if (CheckSpace(carObj, meterObj))
            {
                Console.WriteLine(CreateTicket());
            }
        }
    }
}
