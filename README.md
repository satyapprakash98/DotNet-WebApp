# DotNet-WebApp

Simple web application that takes information from web, updates the database and shows the entries of the database;

step 1:  Create a new web application(MVC) and Download the dependencies 
             a) Microsoft.EntityFrameworkCore   b) a.SqlServer   c) a.Tools

step 2: Displaying the HTML form using index.cshtml file in the View folder, add the html code in this file

step 3: Connect with Database
           i. Create a database >> table of required specifications
           ii. Inside VSCode Goto Tools >> Connect to database >> 
             Image02\SQLEXPRESS >> test connection >> Advanced and copy the 
            connection string
          iii. the following instruction creates the Models folder and classes for the 
              database communication: 
          scaffold-DbContext "Connection string" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
          creates two files- (DataBaseName+Context.cs) and tblName+s.cs
          
          Using the db: WebDBContext db = new WebDBContext(); and start refering the database as db 
          
step 4: Submit the form details to Database
  The index.cshtml form when filled and the submit button is pressed, the control gets diverted to the         submit action. The submit action takes the tbluserDetail as input to the function and adds into the table   or db.
   public IActionResult Submit(TblUserDetail tblUserDetail) - name of the action function
   @model MyWebApplication.Models.TblUserDetail - links the data submitted in the form with the table.
   
Step 5: Displaying the Details inside the Database
  Inside the Layout.cshtml file a button with List as name is added on pressed redirects to the List action   in home controller, which provides the list of data to the List View file.
  @model IEnumerable<MyWebApplication.Models.TblUserDetail> - the input parameter to the List View file       which can be accessed as "Model"
