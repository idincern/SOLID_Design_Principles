using Single_Responsibility_Principle_IdealCode; 

Database db = new();
db.Connect();
PersonService ps = new();
ps.GetPersons();
