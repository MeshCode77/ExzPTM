Select e.id, e.id_podr,e.lastname, e.firstname, e.parentname, e.position, e.num_talon, e.vid_podg, e.date_of_passage, e.dateExpired, DATEADD(DAY, -14, dateExpired) AS RESULT
From employees e
