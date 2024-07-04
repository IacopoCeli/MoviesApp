SELECT 
	first_name,
    last_name
FROM 
	Customers cs
    JOIN Orders ord ON cs.customer_id = ord.customer_id
WHERE
	ord.item = 'Keyboard';