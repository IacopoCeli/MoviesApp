select
    ord.item,
    sh.status
FROM 
	Customers cs
    JOIN Orders ord ON cs.customer_id = ord.customer_id
    JOIN Shippings sh ON ord.order_id = sh.shipping_id
WHERE
	cs.first_name = 'John' AND cs.last_name = 'Reinhardt';