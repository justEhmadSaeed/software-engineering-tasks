#include <iostream>
#include <string>
using namespace std;

int pseudoRand(const string& name, int age) {

	int vowels = 0;
	for (char i : name) {
		if (i == 'a' || i == 'e' || i == 'i' ||
			i == 'o' || i == 'u' || i == 'A' ||
			i == 'E' || i == 'I' || i == 'O' ||
			i == 'U')
		{
			++vowels;
		}
	}

	int reversedNumber = 0, remainder;
	while (age != 0) {
		remainder = age % 10;
		reversedNumber = reversedNumber * 10 + remainder;
		age /= 10;
	}

	return vowels * reversedNumber;
}

int main(int, char**)
{
	// User WELCOME starts
	cout << "Welcome to USW Cyber App!" << std::endl;

	int age, acc, rand;

	string name;
	cout << "Enter full name: ";
	getline(cin, name);

	cout << "Enter your age: ";
	cin >> age;

	while (!(cin >> age))
	{
		cin.clear();
		cin.ignore(10000, '\n');
		cout << "You have entered wrong input" << endl;
		cout << "Enter your age: ";
	}
	cout << "Enter your account number: ";
	
	while (!(cin >> acc))
	{
		cin.clear();
		cin.ignore(10000, '\n');
		cout << "You have entered wrong input" << endl;
		cout << "Enter your account number: (Digits only)";
	}

	cout << "Generating pin..." << endl;
	rand = pseudoRand(name, age);

	cout << "Hi " << name << " Your account " << acc << " has been created." << endl;
	cout << "Your unique pin number is: ";
	if (rand < 10)
		cout << "000" << rand;
	else if (rand < 100)
		cout << "00" << rand;
	else if (rand < 1000)
		cout << "0" << rand;
	// User WELCOME END

	// 2FA TASK
	int userPin, userAcc;
	cout << "\n\nEnter your account number: " << endl;

	while (!(cin >> userAcc))
	{
		cin.clear();
		cin.ignore(10000, '\n');
		cout << "You have entered wrong input" << endl;
		cout << "Enter your account number: (Digits only)";
	}
	cout << "\n\nEnter your pin number: " << endl;
	;
	while (!(cin >> userPin))
	{
		cin.clear();
		cin.ignore(10000, '\n');
		cout << "You have entered wrong pin" << endl;
		cout << "Enter your pin number: (Digits only)";
	}
}