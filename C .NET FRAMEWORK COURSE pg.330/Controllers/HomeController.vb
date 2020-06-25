Public Class HomeController :  Controller
    {
        Private ReadOnly String  connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Academy;
                            Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                             ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        Public ActionResult Index()
        {
            Return View();
        }

        [HttpPost]
        Public ActionResult Calculator
        (string firstName, string lastName, string emailAddress, string age, string carYear, 
         String carModel, String carMake, int tickets, String dui, String coverageType)
        {
            Double Quote = 50;
            // Insuree's age.
            If (age == "Younger than 18") { Quote += 100; }
            If (age == "Bwt. 18-25" || age == "Older than 100") { Quote += 25; }

            // Insuree's car year, make and model. 
            If (carYear == "Before 2000" || carYear == "After 2015") { Quote += 25; }
            If (carModel == "Porsche") { Quote += 25; }
            If (carMake == "911 Carrera") { Quote += 25; }

            // Insuree's speedingTickets, DUI's & prefered coverage.
            Quote += 10 * tickets;
            If (dui == "Yes") { Quote += Quote * 0.25; }
            If (coverageType == "Full") { Quote += Quote * 0.50; }


            If (String.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {return View("~/Views/Shared/Error.cshtml");}
            Else
            {
                String queryString = @"INSERT INTO Insurees (FirstName, LastName, EmailAddress, Age, CarYear, CarModel, CarMake, Tickets, DUI, CoverageType, Quote)
                                    VALUES(@FirstName, @LastName, @EmailAddress, @Age, @CarYear, @CarModel, @CarMake, @Tickets, @DUI, @CoverageType, @Quote)";

                Using (SqlConnection connection = New SqlConnection(connectionString))
                {
                    SqlCommand command = New SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar);
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.NVarChar);
                    command.Parameters.Add("@Age", SqlDbType.NVarChar);
                    command.Parameters.Add("@CarYear", SqlDbType.NVarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.NVarChar);
                    command.Parameters.Add("@CarMake", SqlDbType.NVarChar);
                    command.Parameters.Add("@Tickets", SqlDbType.Int);
                    command.Parameters.Add("@DUI", SqlDbType.NVarChar);
                    command.Parameters.Add("@CoverageType", SqlDbType.NVarChar);
                    command.Parameters.Add("@Quote", SqlDbType.Money);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    command.Parameters["@Age"].Value = age;
                    command.Parameters["@CarYear"].Value = carYear;
                    command.Parameters["@CarModel"].Value = carModel;
                    command.Parameters["@CarMake"].Value = carMake;
                    command.Parameters["@Tickets"].Value = tickets;
                    command.Parameters["@DUI"].Value = dui;
                    command.Parameters["@CoverageType"].Value = coverageType;
                    command.Parameters["@Quote"].Value = Quote;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                ViewBag.TryGetValue = Quote;
                Return View("Success");
            }
            
        }
        
        Public ActionResult Coverage()
        {
            ViewBag.Message = "Coverage Calculator";
            Return View();
        }

        Public ActionResult Admin()
        {
            String queryString = @"SELECT FirstName, LastName, EmailAddress, Quote FROM Insurees";
            List<AcademyInsurees> insurees = New List<AcademyInsurees>();

            Using (SqlConnection connection = New SqlConnection(connectionString))
            {
                SqlCommand command = New SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                While (reader.Read())
                {
                    var insuree = New AcademyInsurees();
                    insuree.FirstName = reader["FirstName"].ToString();
                    insuree.LastName = reader["LastName"].ToString();
                    insuree.EmailAddress = reader["EmailAddress"].ToString();
                    insuree.Quote = Convert.ToDouble(reader["Quote"]);
                    insurees.Add(insuree);
                }

            }
                Return View(insurees);
        }
       
    }