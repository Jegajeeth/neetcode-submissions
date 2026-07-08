-- Write your query below

select s.seller_name from seller as s 
LEFT JOIN orders as o
ON o.seller_id = s.seller_id AND EXTRACT(YEAR FROM o.sale_date) = 2020
where o.order_id IS null
ORDER BY s.seller_name ASC;