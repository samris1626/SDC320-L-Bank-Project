Bank Account Management System
--
SDC320L – Course Project
Samantha Riser

--

Overview

This is a C# terminal-based application that demonstrates the fundamentals of object-oriented programming using a simple bank account simulation. The system creates different account types, performs basic transactions, and displays updated account information. It highlights inheritance, interfaces, composition, and polymorphism within a clean class structure.

Features

- Creation of checking and savings accounts
- Deposit and withdrawal operations
- Shared transaction behavior across account types (via interface)
- Contact information stored through composition
- Demonstration of polymorphism with a transaction list
- Console-based output and interaction

--

Data Model
Accounts
Each account stores:
- OwnerName
- ContactInfo (Address, Phone, Email)
- Balance

Checking Accounts
- Inherits from Account
- Implements ITransaction
- Supports deposits and withdrawals

Savings Accounts
- Inherits from Account
- Implements ITransaction
- Supports deposits and withdrawals

Contact Information
Includes:
- Address
- Phone
- Email

Transactions (Interface)

Defines:
- Deposit(decimal amount)
- Withdraw(decimal amount)

Relationships
- An Account is associated with a ContactInfo object (composition)
- Both CheckingAccount and SavingsAccount inherit from the Account base class
- Both account types share common behaviors through the ITransaction interface
- A list of ITransaction objects allows polymorphic behavior across accounts
