#include <iostream>
#include <string>

using namespace std;

int Mortgage(bool gender, int age, int salary)
{
	if (gender)
	{
		return ((18 <= age < 35) ? (75 * salary) : (31 <= age < 45) ? (55 * salary) : (30 * salary));
	}
	else
	{
		return ((18 <= age < 30) ? (70 * salary) : (31 <= age < 40) ? (50 * salary) : (35 * salary));
	}
}

void main()
{
	bool _gender;
	bool _flag = true;
	string _str;
	int _age;
	int _salary;

	cout << "gender [male/female]: "; cin >> _str;
	cout << "age [18-55]: "; cin >> _age;
	cout << "salary [0-10000]: "; cin >> _salary;

	if (_str == "male")
		_gender = true;
	else if (_str == "female") _gender = false;
	else {
		_flag = false;
		cout << "\ngender invalid";
	}

	if (_age < 18 || _age > 55) {
		_flag = false;
		cout << "\nage invalid";
	}

	if (_salary < 0 || _salary > 10000) {
		_flag = false;
		cout << "\nsalary invalid";
	}

	if (_flag)
	{
		int Result = Mortgage(_gender, _age, _salary);
		cout << "\nMortgage = " << Result << endl;
	}
	else
	{
		cout << "\n\nERROR!!!" << endl;
	}
}