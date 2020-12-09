#include <iostream>
#include <string>
#include <fstream>
using namespace std;

int pseudoRand(const string& name, int age);
int passStrength(string pass);

int main(int, char**)
{
	// User WELCOME starts
	cout << "Welcome to USW Cyber App!" << std::endl;

	int age, acc, pin;

	string name;
	cout << "Enter full name: ";
	getline(cin, name);

	cout << "Enter your age: ";

	while (!(cin >> age))	// Keep asking for input until a valid age is entered
	{
		// To clear the invalid input buffer
		cin.clear();
		cin.ignore(10000, '\n');
		cout << "You have entered wrong input" << endl;
		cout << "Enter your age: ";
	}
	cout << "Enter your account number: ";

	while (!(cin >> acc))	// Keep asking for input until a valid account number is entered
	{
		cin.clear();
		cin.ignore(10000, '\n');
		cout << "You have entered wrong input" << endl;
		cout << "Enter your account number: (Digits only)";
	}
	// Calling pseudoRand function to generate a unique pin
	cout << "Generating pin..." << endl;
	pin = pseudoRand(name, age);

	cout << "Hi " << name << " Your account " << acc << " has been created." << endl;
	cout << "Your unique pin number is: ";
	// Fill up the remaining digits with zeros
	if (pin < 10)
		cout << "000" << pin;
	else if (pin < 100)
		cout << "00" << pin;
	else if (pin < 1000)
		cout << "0" << pin;
	// User WELCOME END

	// 2FA TASK

	int userPin = -1, userAcc = -1;
	bool notMatch = true;	// By Default notMatch is true
	do {

		cout << "\nEnter your account number: " << endl;
		while (!(cin >> userAcc))	// Keep asking for input until a valid user account is entered
		{
			// To clear the invalid input buffer
			cin.clear();
			cin.ignore(10000, '\n');
			cout << "You have entered wrong input" << endl;
			cout << "Enter your account number(Digits only): ";
		}
		cout << "\nEnter your pin number: " << endl;
		while (!(cin >> userPin))	// Keep asking for input until a valid user userPin is entered
		{
			cin.clear();
			cin.ignore(10000, '\n');
			cout << "You have entered wrong pin" << endl;
			cout << "Enter your pin number(Digits only): ";
		}
		notMatch = userAcc != acc || userPin != pin;
		if (notMatch)
			cout << "The account number and the pin entered do not match the records. \n\n";
	} while (notMatch);	// If userAcc and Pin do not match


	// Username Input from the user
	string username;
	bool found = false;
	do {
		cout << "\nEnter a Username: ";
		cin >> username;

		// Reading data from the file
		ifstream inData;
		string temp;
		inData.open("2FA_users.txt");
		// Keep matching username until the end of file is achieved or the file failed to open
		while (!inData.eof() && !inData.fail())
		{
			// Fetch complete line
			getline(inData, temp);
			// Split from starting character of the line to the first space
			// to get username from file
			temp = temp.substr(0, temp.find(' '));
			if (temp == username) {	// if user exists, toggle found to true and break the loop
				cout << "Username alread exists.";
				found = true;
				break;
			}// else make it false
			found = false;
		}
		inData.close();

	} while (found);	// keep asking for username until found is false
	// Password Input from the user
	string password;
	int strength = 0;	// Initial value of the strength
	while (strength != 3) {

		cout << "\nEnter a Password: ";
		cin >> password;
		strength = passStrength(password);
		// Show output based on the strength of the password
		switch (strength)
		{
		case 3:	// 3 Represents Strong Password
			cout << "\nPassword Strength is Strong **** \n";
			break;
		case 2:	// 2 Represents Medium Password
			cout << "\nPassword Strength is Medium *** \n";
			break;
		case 1: // 1 Represents Weak Password
			cout << "\nPassword Strength is Weak ** \n";
			break;
		default: // Any other value of strength represents an invalid password
			cout << "\nPassword is Invalid ! \n";
			break;
		}
		if (strength != 3) { // Only if passowrd is not strong
			cout << "A Strong password contains a length of 18\n";
			cout << "4 Uppercase Letters, 3 Numbers and 3 Symbols. \n";
		}
	}
	// Writing to the File
	ofstream outData;
	outData.open("2FA_users.txt", ios_base::app);	// ios_base::app to append instead of overwriting
	outData << username << " " << userAcc << " " << userPin << " " << password << endl;
	outData.close();

}

// Function to generate a pin for the user
int pseudoRand(const string& name, int age) {

	int vowels = 0;
	// To count the vowels
	for (char i : name) {
		if (i == 'a' || i == 'e' || i == 'i' ||
			i == 'o' || i == 'u' || i == 'A' ||
			i == 'E' || i == 'I' || i == 'O' ||
			i == 'U')
		{
			++vowels;
		}
	}
	// Reverse the Age
	int reversedNumber = 0, remainder;
	while (age != 0) {
		remainder = age % 10;
		reversedNumber = reversedNumber * 10 + remainder;
		age /= 10;
	}
	// Generate the pin
	return vowels * reversedNumber;
}
// Function to calculate the Strength of the Password
int passStrength(string pass) {
	// Count Integers for each type of character
	int numbers = 0, uppercase = 0, symbols = 0;

	for (int i = 0; i < pass.length(); i++)
	{
		if (pass[i] >= '0' && pass[i] <= '9')	// if the char is in the range of digits
			numbers++;
		else if (pass[i] >= 'A' && pass[i] <= 'Z')	// if the char is in the range of Uppercase letters
			uppercase++;
		else if (pass[i] >= 'a' && pass[i] <= 'z')	// in case of lowercase letters, the count will be skipped
			continue;
		else	// any char except the above mentioned characters will be considered a symbol
			symbols++;
	}
	if (pass.length() >= 18 && uppercase >= 4 && numbers >= 3 && symbols >= 3)
		return 3;	// 3 Represents Strong Password
	else if (pass.length() >= 16 && uppercase >= 2 && numbers >= 2 && symbols >= 2)
		return 2;	// 2 Represents Medium Password
	else if (pass.length() >= 14 && uppercase >= 1 && numbers >= 1 && symbols >= 1)
		return 1;	// 1 Represents Weak Password
	else
		return -1;	// -1 Represents Invalid Password
}