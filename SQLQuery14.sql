select customer_id , name from customer
where nationality like 'A%';

select flight_id , MAX (price)
from Booking 
group by flight_id ;

select AVG(no_passengers)
from Flight;

delete from Flight
where date1 < '1/1/2009' ;
