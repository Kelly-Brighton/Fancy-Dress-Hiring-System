This is a desktop application developed using C# and Windows Forms that allows users to browse, like, and hire costumes. The system includes an admin panel for managing orders and products, as well as AI-powered search functionality.

Technologies used:
    C# (.NET Windows Forms)
    SQL Server
    ADO.NET
    MSTest (for testing)
    OpenAI API (AI integration)

How to run the Project
  Open the solution file FancyDressHiringSystem.slnx
  Ensure the SQL Server is running
  Create the database
    Run the provided SQL scripts (Tables: Users, Clothes, Basket, Likes, Orders)
  Update connection string if needed: Server=localhost;Database=FancyDressDB;Trusted_Connection=True;
  Run the project using Visual Studio

The system includes an AI assistant that allows users to search using natural language queries. It uses the OpenAI API to process user input and return relevant results

Testing was carried out using MSTest, including unit testing and integration testing for database operations

How to use:
  Register or log in as a user
  Browse costumes on the Home page
  Use filters or AI search
  Add items to the basket or likes
  Proceed to checkout and place an order
  Admin can update order status and send emails
     
