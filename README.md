# Bimap Tesira Level Control

## Overview
This project was developed as part of the technical quest for the interview process. The purpose of this project is to create a C# application to control a 'Control Block-Level Control' for a Biamp Tesira Unit. The application will allow user to adjust the volume level using up and down command.

## General notes
	- In the unprotected system, the username and password are 'default' and 'default' respectively. In a protected environment, it requires a username and password to login to the system.(Biamp TTP3.0, 2017)

## Key Features
-**Authentication** - The application will prompt the user to enter the IP address of the Tesira unit, username, and the password. The application will then authenticate the user and allow the user to control the volume level.
-**Volume Control** - The application will allow the user to adjust the volume level using up and down command. The application will also display the current volume level.
-**TCP Connection** - The application will establish a TCP connection with the Tesira unit.
-**Automation** - Once the user login to the Tesira unit successfully, the application will automatically retrieve the list of available devices and display them in the drop-down list. Once the device is selected, it will automatically retrieve the number of channels of that particular device. The application will also automatically retrieve the current volume level and display it.

### Techincal choices
**SSHClient** - The SSHClient was used to establish a TCP connection with the Tesira unit. The SSHClient was used because it is a lightweight library that is easy to use and it is also cross-platform. The SSHClient also has a built-in method to authenticate the user. The SSHClient also has a built-in method to send and receive data. Moreover, both SSHClient and Tesira unit use the same port number, which is 22.

### Code Structure
-**Form1.cs:** Main form containing UI logic and event handlers.
-**Biamp_Level_Controller.cs:** Class handling TCP/IP and SSH connections to the Biamp Level Controller.
-**Level_Controller.cs:** Class providing methods for interacting with the Biamp Level Controller, such as retrieving level, and adjusting level.
-**ResponseParsers.cs:** Class providing methods for parsing responses from the Biamp Level Controller.

## Usage
1. Launch the application.
2. Enter the IP address of the Tesira unit.
3. Enter the username and password.			
4. Click the "Login" to connect to a Tesira unit.
5. Select the Instance Tag from the list of available devices.
6. Select the Channel no. of the device.
7. It will show the current volume level.
8. Click the "Up" button to increase the volume level.
9. Click the "Down" button to decrease the volume level.
10. Click the "Logout" button to disconnect from the Tesira unit.

### Challenges faced

- **Tesira Unit:** The Tesira unit was not available for testing. Therefore, I was not able to test the application with the Tesira unit.
- **Tesira Text Protocol 3.0:** I was not familiar with the Tesira Text Protocol 3.0. Therefore, I had to spend some time to learn about the protocol and how to use it.

### Learnings

--**Tesira Text Protocol 3.0:** I learned about the Tesira Text Protocol 3.0 and how to use it.

## Conclusion:
This project served as a valuable opportunity to apply and strengthen my skills in C#, API interaction using TCP/IP, and problem solving.

I enjoyed working on this project as this project allowed me to showcase my skills to effectively communicate with the external devices using TCP/IP like Tesira Device.

This solution is modular and can be easily extended to support other features like mute, unmute, etc.

## References
Biamp. (2022, October 21). Tesira command string calculator. Biamp Cornerstone. https://support.biamp.com/Tesira/Control/Tesira_command_string_calculator

biamp TTP3.0. (2017, February). http://cdn.biamp.com/software/docs/default-source/downloads/ttp_printed_documentation_3-0-feb17.pdf?sfvrsn=2. Retrieved January 15, 2024, from http://cdn.biamp.com/software/docs/default-source/downloads/ttp_printed_documentation_3-0-feb17.pdf?sfvrsn=2