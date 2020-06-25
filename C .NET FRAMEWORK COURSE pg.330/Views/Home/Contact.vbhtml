<h3>@ViewBag.Message</h3>

<p>Please answer the following quick questions to get your Auto Insurance Quote.</p>

<div class="row no-gutters m-3 " style="background-image:url(/Content/Img/carAdvtr.jpg);
        background-position:center; background-repeat:no-repeat; background-size:cover; padding:10px;
        text-shadow: 0 0 15px white, 0 0 15px white;">
  <div class="card mx-auto shadow rounded border-primary">
    <div class="card-body text-center">
      @Using (Html.BeginForm("Calculator", "Home", FormMethod.Post))
            {
                <div Class="row no-gutters">
                    <div Class="form-group col-md-12">
                        <Label for="firstName">First Name</label>
                        <input name = "FirstName" type="text" Class="form-control-sm input-xs">
                    </div>

                    <div Class="form-group col-md-12">
                        <Label for="lastName">Last Name</label>
                        <input name = "LastName" type="text" Class="form-control-sm input-xs">
                    </div>

                    <div Class="form-group col-md-12">
                        <Label for="emailAddress">E-mail Address</label>
                        <input name = "EmailAddress" type="email" Class="form-control-sm input-xs">
                    </div>

                    <div Class="form-group col-md-12">
                        <Label for="age">What Is your current age?</label>
                        <select Class="form-control-sm input-xs" name="Age">
                            <option value = "Younger than 18" > Younger than 18</Option>
                            <option value = "Bwt. 18-25" > Between 18-25</Option>
                            <option value = "Bwt. 25-100" > Between 25-100</Option>
                            <option value = "Older than 100" > Older than 100</Option>
                        </select>
                    </div>

                    <div Class="form-group col-md-12">
                        <Label for="carYear">What Model-Year Is your car?</label>
                        <select Class="form-control-sm input-xs" name="CarYear">
                            <option value = "Before 2000" > Before 2000</Option>
                            <option value = "Between 2000-2015" > Between 2000-2015</Option>
                            <option value = "After 2015" > After 2015</Option>
                        </select>
                    </div>

                    <div Class="form-group col-md-12">
                        <Label for="carModel">What Model Is your car?</label>
                        <select Class="form-control-sm input-xs" name="CarModel">
                            <option value = "Porsche" > Porsche</Option>
                            <option value = "Other" > Other</Option>
                        </select>
                    </div>

                    <div Class="form-group col-md-12">
                        <Label for="carMake">What Make Is your car?</label>
                        <select Class="form-control-sm input-xs" name="CarMake">
                            <option value = "911 Carrera" > 911 Carrera</Option>
                            <option value = "Other" > Other</Option>
                        </select>
                    </div>

                    <div Class="form-group col-md-12">
                        <Label for="tickets">How many speeding tickets do you have?</label>
                        <select Class="form-control-sm input-xs" name="Tickets">
                            <option value = "0" > 0</Option>
                            <option value = "1" > 1</Option>
                            <option value = "2" > 2</Option>
                            <option value = "3" > 3</Option>
                            <option value = "4" > 4</Option>
                            <option value = "5" > 5</Option>
                        </select>
                    </div>

                    <div Class="form-group col-md-12">
                        <Label for="DUI">Have you ever had DUI's?</label>
                        <select Class="form-control-sm input-xs" name="DUI">
                            <option value = "Yes" > Yes, unfortunately.</Option>
                            <option value = "Never" > Never</Option>
                        </select>
                    </div>

                    <div Class="form-group col-md-12">
                        <Label for="coverage">What type of coverage are you looking for?</label>
                        <select Class="form-control-sm input-xs" name="CoverageType">
                            <option value = "Full" > Full coverage</Option>
                            <option value = "Other" > Other</Option>
                        </select>
                    </div>
                </div>
                <Button type = "submit" Class="btn btn-lg btn-primary"> Submit </button>
            }
        </div>
    </div>
</div>
