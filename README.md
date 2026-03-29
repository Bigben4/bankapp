# BankApp (VB.NET)

This is my first VB.NET project: a simple desktop banking application built with Windows Forms. It demonstrates basic object-oriented programming concepts in VB.NET, including classes, properties, methods, and simple data validation.

Project structure
- `Form1.vb`, `Form1.Designer.vb`, `Form1.resx` - Main Windows Form UI
- `bankAccountClass.vb` - Base class representing a bank account
- `savingsAccounts.vb` - Savings account class (likely inherits from `bankAccountClass`)

What this project does
- Create bank account objects with owner, account number, and balance
- Allow deposits and withdrawals with simple checks (e.g., deposit limits, insufficient funds)
- Display messages to the user via message boxes

Why this project
- Educational: practicing VB.NET syntax and Windows Forms development
- Demonstrates creating classes, constructors, properties, and simple UI interactions

Possible modifications and improvements
- Replace `MsgBox` calls with updated UI updates on the form (labels, listboxes) to avoid modal popups.
- Add persistent storage: save accounts to a file (JSON, XML) or a small database so data persists between runs.
- Improve validation and error handling: use exceptions for error states and centralize validation logic.
- Add account types (checking, savings) with different rules (interest, withdrawal limits).
- Add transaction history per account and show it in the UI.
- Add unit tests for core business logic (deposit/withdraw rules).
- Add authentication or basic multi-user support.
- Localize strings for multiple languages.

Security and best practices
- Do not store secrets or sensitive data in source control. Use `.env` or a secrets manager.
- Avoid using message boxes for program logic; prefer returning results and showing UI updates.

Notes and other suggestions
- Consider renaming `bankAccountClass` to `BankAccount` to follow .NET naming conventions.
- Make fields private where appropriate and expose read-only properties if mutation should be controlled.
- Remove any auto-generated GUID account numbers if predictable or replace with a safer approach if needed.

If you want, I can:
- Rename classes and refactor to follow .NET naming conventions.
- Add simple JSON persistence for accounts.
- Replace `MsgBox` calls with UI updates on `Form1`.
- Add basic unit tests using NUnit or MSTest.

