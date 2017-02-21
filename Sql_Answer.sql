  --1. Give the names of employees, whose salaries are greater than their immediate managers.

 SELECT a.name AS "Employee Name"
FROM employee a, employee b
WHERE a.manager_id = b.id and a.salary > b.salary

--Employee Name
Sally     
Dan             

--Confirmation:

   SELECT 
   a.id AS "Employee Id"
   ,a.name AS "Employee Name"
   , a.salary
   ,b.id AS "Manager Id"
   ,b.name AS "Manager Name"
  , b.salary
FROM employee a, employee b
WHERE a.manager_id = b.id 
and a.salary > b.salary

--Employee Id	Employee Name	salary	Manager Id	Manager Name	salary
	3			Sally     		550		4			Jane      		500
	6			Dan       		600		3			Sally     		550



-- 2. What is the average salary of employees who not manage anyone? In the sampe above that would be John, Mike, Joe and Dan, since they do not have anyone reporting to them.



SELECT AVG(a.salary) as 'Average Salary' 
FROM employee a
WHERE NOT EXISTS 
(
	SELECT b.name
	FROM employee b
	where b.manager_id = a.id
)


--Average Salary
400


--Confirmation
SELECT a.name
FROM employee a
WHERE NOT EXISTS 
(
	SELECT b.name
	FROM employee b
	where b.manager_id = a.id
)
