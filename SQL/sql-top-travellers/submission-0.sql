-- Write your query below
select name, coalesce(travelled_distance, 0) travelled_distance
from users as u
left join (
    select user_id, sum(distance) as travelled_distance
        from rides
            group by user_id
            ) as r
            on u.id = r.user_id
            order by 2 desc, 1 asc