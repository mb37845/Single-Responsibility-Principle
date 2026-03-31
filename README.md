## User finance learning project

Description: Create a console application that allows users to manage their personal finances by tracking their income and expenses, and generating financial reports.

Requirements:

    User Management
        Implement user registration and login functionality.
        Securely store user credentials.

    Income Management
        Allow users to add, view, and delete income entries.
        Each income entry should include the date, amount, source (e.g., salary, freelance), and a description.
        Categorize income sources and allow users to filter by category.

    Expense Management
        Allow users to add, view, and delete expense entries.
        Each expense entry should include the date, amount, category (e.g., groceries, rent), and a description.
        Categorize expenses and allow users to filter by category.

    Reports
        Generate reports that summarize income and expenses over a specified period (e.g., monthly, quarterly, annually).
        Display total income, total expenses, and net savings for the selected period.
        Provide a breakdown of income and expenses by category.

    Data Persistence
        Store user data, income entries, and expense entries in files.
        Load data when the application starts.

    User Input Validation
        Validate user inputs for correctness and completeness.
        Provide meaningful error messages for invalid inputs.

    Basic Data Structures
        Use lists or dictionaries to manage collections of income and expense entries.




# User stories 

| **User Story** | **Description** |
|----------------|------------------|
| **User Management** | |
| US1 | As a user, I want to be able to register an account, so that I can securely store my financial data. |
| US2 | As a user, I want to be able to log in to my account, so that I can access my financial data. |
| US3 | As a user, I want my credentials to be securely stored, so that my account is protected. |
| **Income Management** | |
| US4 | As a user, I want to add an income entry with the date, amount, source, and description, so that I can track my income accurately. |
| US5 | As a user, I want to view a list of all my income entries, so that I can review my income history. |
| US6 | As a user, I want to delete an income entry, so that I can manage my records and correct any mistakes. |
| US7 | As a user, I want to categorize my income sources, so that I can filter and analyze my income by category. |
| **Expense Management** | |
| US8 | As a user, I want to add an expense entry with the date, amount, category, and description, so that I can track my expenses accurately. |
| US9 | As a user, I want to view a list of all my expense entries, so that I can review my spending history. |
| US10 | As a user, I want to delete an expense entry, so that I can manage my records and correct any mistakes. |
| US11 | As a user, I want to categorize my expenses, so that I can filter and analyze my spending by category. |
| **Reports** | |
| US12 | As a user, I want to generate a report summarizing my income over a specified period, so that I can see my total earnings. |
| US13 | As a user, I want to generate a report summarizing my expenses over a specified period, so that I can see my total spending. |
| US14 | As a user, I want to see my net savings for a selected period, so that I can understand my financial balance. |
| US15 | As a user, I want to see a breakdown of my income and expenses by category, so that I can analyze my financial habits. |
| **Data Persistence** | |
| US16 | As a user, I want my financial data to be saved to a file, so that it is not lost when the application is closed. |
| US17 | As a user, I want my financial data to be loaded when I start the application, so that I can continue from where I left off. |
| **User Input Validation** | |
| US18 | As a user, I want the application to validate my input data, so that I can avoid errors and maintain data integrity. |
| US19 | As a user, I want to receive meaningful error messages for invalid inputs, so that I can correct my mistakes. |
| **Basic Data Structures** | |
| US20 | As a developer, I want to use lists or dictionaries to manage collections of income and expense entries, so that the data is organized and easy to manipulate. |
