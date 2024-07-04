-- Versione 1: somma di tutti gli ordini che arrivano dal regno unito
select
	SUM(amount) as total_amount
from
	Orders ord
    JOIN Customers cs ON ord.customer_id = cs.customer_id
WHERE
	cs.country = 'UK';

-- Versione 2: somma di tutti gli ordini che arrivano dal regno unito per singolo cliente
select
	ord.customer_id,
    cs.first_name || ' ' || cs.last_name as customer_name,
	SUM(amount) as total_amount
from
	Orders ord
    JOIN Customers cs ON ord.customer_id = cs.customer_id
WHERE
	cs.country = 'UK'
GROUP BY ord.customer_id;