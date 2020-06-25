﻿@      Using AutoInsuranceCalculator.Models
  @Model List<AcademyInsurees>

    <div class="row no-gutters m-3" style=" margin:auto; width:80%; border: 3px solid #73AD21;
      padding-left: 30px;  padding-bottom: 30px;   margin-top: 60px;  margin-bottom: 60px;">
      <div class="card col-sm-12 col-md-10 col-lg-6 mx-auto shadow">
        <div class="card-header text-center">
          <h3 class="m-0">Quotes Issued</h3>
        </div>
        <div class="card-body">
@foreach (var insuree in Model)
            {
                <div class="row">
                      <div class="col-sm-3">@insuree.FirstName</div>
            <div class="col-sm-3">@insuree.LastName</div>
            <div class="col-sm-4">@insuree.EmailAddress</div>
            <div class="col-sm-2">@insuree.Quote</div>
                    </div>
                                                                                                    }
                                                                                                </div>
                </div>
    </div>