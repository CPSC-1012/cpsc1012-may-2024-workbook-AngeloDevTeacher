// See https://aka.ms/new-console-template for more information
using CalendarApp;

/// <summary>
/// This project will allow you to create and read appointments and display them on a calendar.
/// The appointments should save the appointment name and the appointment date.
/// Author: Angelo Encarnacion
/// Last Modified: July 16th 2024
/// </summary>
/// 

// General Plan:
// Display program intro
// Display Menu
// Prompt for Option:
//  1 - Create appointment
//  2 - Display appointments (by month)
//  3 - Display appointments (by name?)
//  0 - Quit the program

//
//

void DisplayProgramIntro()
{

}

void DisplayProgramMenu()
{

}

Appointment thisAppointment = new Appointment("Hello", DateTime.Parse("July 17, 2024"));

thisAppointment.AppointmentName = "";



Console.WriteLine(thisAppointment.ToString());