# OpeningHours

Handles opening hours for any domain.

SQL Server is used to store opening hours for a set 
of dates. A SQL Server Project defines the
structure of the database and the user defined function
that returns whether a specified DateTime refers to
a timepoint when the domain is open for business.

A library contains OpeningHoursChecker that performs
the check whether the business is open for a specified
DateTime.

Unit tests verifies the logic using OpeningHoursChecker 
as the "system under test". 

An MVC project contains an API controller that also
uses OpeningHoursChecker to return true or false based
on the following paramters: year, month, day, hour and
minute.

## Prerequisites

- Latest update of Visual Studio Enterprise 2017
- SQL Server
