use Company_SD
--Display all the employees Data.
select * 
from Employee
--Display the employee First name, last name, Salary and Department number.
select Fname, Lname, Salary, Dno 
from Employee
--Display all the projects names, locations and the department which is responsible about it.
select Pname, Plocation, Dnum 
from Project
--If you know that the company policy is to pay an annual commission for each employee with specific percent equals 10% of his/her annual salary. Display each employee full name and his annual commission in an ANNUAL COMM column (alias).
select Fname + ' ' + Lname as "Full Name", Salary * 0.1 as "ANNUAL COMM" 
from Employee
--Display the Department id, name and id and the name of its manager.
select Dnum, Dname, MGRSSN, Fname 
from Departments inner join Employee 
on MGRSSN = SSN
--Display the name of the departments and the name of the projects under its control.
select Dname, Pname
from Departments inner join Project 
on Project.Dnum = Departments.Dnum
--Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select Dependent.*, Fname  
from Dependent inner join Employee
on ESSN = SSN

--Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project
select  sum(Hours), Essn, Fname from Project inner join Works_for
on Pno = Pnumber 
inner join Employee
on ESSn = SSN
where Pname = 'Al Rabwah'
group by Essn, Fname
having  sum(Hours) >= 10;

--Find the names of the employees who directly supervised with Kamel Mohamed.
select Fname from Employee
where Superssn = (select SSN from Employee where CONCAT(Fname, ' ', Lname) = 'Kamel Mohamed')

 --Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select Fname, Pname from Employee inner join Works_for
on SSN = ESSn
inner join Project
on Pno = Pnumber
order by Pname

--For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.
select Pnumber, Dname, Lname, Bdate, [Address] from Project p inner join	Departments d 
on p.Dnum = d.Dnum 
inner join Employee 
on MGRSSN = SSN
where City = 'Cairo'

--Display All Employees data and the data of their dependents even if they have no dependents
select * from Employee left outer join Dependent
on ESSN = SSN

--Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
insert into Employee(SSN, Superssn, Salary, Dno) values(102672,112233,3000,30)

--Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
insert into Employee(Dno, SSN) values(30, 102660)

--Upgrade your salary by 20 % of its last value.
update Employee
set Salary += Salary * 0.2
where ssn = 102672

--Part 3
--For each project, list the project name and the total hours per week (for all employees) spent on that project.
select Pname,Sum(Hours) from Works_for inner join Project
on Pno = Pnumber
group by Pname

--For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select Dname, max(salary) as "Max", min(salary) as "Min", avg(salary) as "Avg" from Departments inner join Employee
on Dno = Dnum
group by Dname

--In the department table insert new department called "DEPT IT”, with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
insert into Departments(Dname,Dnum,MGRSSN,[MGRStart Date]) values('DEPT IT', 100,112233,'1-11-2006')

--4 Do what is required if you know that: Mrs.Noha Mohamed (SSN=968574) moved to be the manager of the new department (id = 100), and they give you (your SSN =102672) her position (Dept. 20 manager)
--a. First try to update her record in the department table
update  Departments
set MGRSSN = 968574
where Dnum = 100 
--b. Update your record to be department 20 manager.
	update  Departments
set MGRSSN = 102672
where Dnum = 20 
--c. Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
update Employee
set Superssn = 102672
where SSN = 102660

--Unfortunately, the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position. 
--Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).
update Employee 
	set Superssn = 102672
where Superssn = 223344
update Departments
	set MGRSSN = 102672
	where MGRSSN = 223344
update Employee
	set Superssn = (select Superssn from Employee where SSN = 223344)
	where SSN = 102672
delete from Employee
where ssn = 223344
delete from "Dependent"
where ESSN = 223344



