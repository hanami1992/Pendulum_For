----SELECT Tracks.title 
----FROM Albums inner join Tracks on Albums.id = Tracks.album
----WHERE Albums.artist like 'Amaranthe';

--SELECT Albums.release,  (dateadd(millisecond,sum(datediff(millisecond,0,cast(Tracks.length as datetime))),0))
--FROM Albums inner join Tracks on Albums.id = Tracks.album
--WHERE Albums.title like 'Hold your colour'
--Group by Albums.release;

SELECT *
FROM Albums;

select *
from Tracks;

SELECT SUM (length) 
    FROM Tracks 


--UPDATE Tracks
--SET url = 'asdfkas5'
--WHERE Tracks.title like 'Leave Everything Behind'