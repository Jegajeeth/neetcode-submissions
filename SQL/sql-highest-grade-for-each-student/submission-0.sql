-- Write your query below

SELECT DISTINCT ON (maxresult.student_id) maxresult.student_id, eid.exam_id, maxresult.score FROM(
    SELECT er.student_id, MAX(score) as score
    FROM exam_results as er
    GROUP BY er.student_id
) as maxresult
INNER JOIN exam_results as eid
on maxresult.student_id = eid.student_id and maxresult.score = eid.score


