-- Write your query below

SELECT e.employee_id, CASE
    WHEN (e.employee_id % 2 != 1) OR (e.name LIKE 'M%') THEN 0
    ELSE e.salary
    END AS bonus
 FROM employees as e ORDER BY e.employee_id
     