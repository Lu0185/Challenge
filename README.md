# Challenge
Contact Manager

Goal is to create a contact manager that connects two tables: 

Contact (table)
○ First Name
○ Last Name
○ Address (table, FK, navigation from Contact)
  ■ Street
  ■ City
  ■ State
  ■ Postal Code
  
  Features are should include on the Contact list
  ○ Grid
  ○ Search
      ■ Optionally, implement “Fuzzy Search”:
      ■  Searching in one textbox should search all fields using “contains”
    search approach
      ■ Filter the grid as the user types in the search box
        ○ Implement “New Contact” button
        ○ Implement “Edit Contact” button
        ○ Implement “Delete Contact” button
        
On the homepage to view a list of the contacts from the two tables you would need to click the "Contact Info" tab on the tool bar. The "Contacts", and "Address" tabs will bring you to each individual entities where you can create, view details, edit and delete an entry.

To update the appsetting connection string located in the Web.config (Root file) preceding the "appsetting" elemen, following the following example: 
<connectionStrings>
    <add name="Context" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog="Name of your database";Integrated Security=SSPI;" providerName="System.Data.SqlClient"/>
</connectionStrings> then save. Once the application has been built and ran connection should be established and/or created.
