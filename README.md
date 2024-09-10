# Restaurant PDA System - Desktop Application

## Overview

This desktop application is a core component of the restaurant PDA (Personal Digital Assistant) system, designed to display and manage orders received from the Android app used by restaurant staff. The app is developed in C# using .NET WinForms and runs on a kitchen laptop or desktop to facilitate order management and printing.

The application reads orders from an SQL database hosted on a XAMPP server, ensuring centralized data storage and efficient communication between the Android app and the kitchen.

## Features

**Order Display:** Real-time display of orders as they are received from the Android app.
**Sound Notification:** A sound plays each time a new order is received, alerting kitchen staff.
**Automatic Printing:** If the "Auto Print" checkbox is checked, orders will be automatically printed using a small receipt printer. If unchecked, the operator can manually print the orders.
**SQL Database Integration:** Orders are retrieved from the SQL database hosted on a XAMPP server.

## Requirements
**Operating System:** Windows 7 or higher.
**Development Environment:** Visual Studio with .NET WinForms.
**Database:** XAMPP server hosting the SQL database.
**Printer:** A small receipt printer for printing orders.
**Network:** Ensure that the kitchen desktop is connected to the same network as the Android device for communication through the SQL database.

## Installation and Setup

### Set up XAMPP Server:

Install XAMPP on the kitchen laptop or server.
Set up the SQL database using the provided .sql file that defines the structure for storing menu items and orders.
Ensure the MySQL service is running on XAMPP.

### Database Configuration:

In the desktop application, configure the connection to the SQL database hosted on the XAMPP server.
Set the appropriate IP address (or localhost if the XAMPP server is on the same machine) and database credentials.
Printer Configuration:

Connect the receipt printer to the desktop where the application is running.
Ensure proper drivers are installed for the printer.
If "Auto Print" is enabled in the application, orders will automatically be sent to the printer when received. Otherwise, printing can be done manually.
Order Management:

As orders are placed via the Android app, they are stored in the SQL database.
The desktop application retrieves these orders in real-time and displays them on the screen.
A sound notification will play each time a new order is received to alert the kitchen staff.
Auto Print Feature:

If "Auto Print" is enabled, the application will automatically send the order to the connected receipt printer.
If "Auto Print" is disabled, the operator can manually print the order by selecting it from the order list and clicking the "Print" button.
SQL Database Integration
The desktop application interacts with the SQL database hosted on a XAMPP server to read the incoming orders.
Orders sent from the Android app are stored in the database, and the desktop app retrieves and displays them in real-time.
Configuration
Ensure the XAMPP server and SQL database are properly configured and accessible from the desktop application.
The kitchen desktop should have the correct IP address and database credentials set to retrieve the orders.
