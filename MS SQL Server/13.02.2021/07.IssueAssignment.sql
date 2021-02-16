SELECT  i.Id, u.Username + ' : ' + i.Title FROM Issues i
JOIN  Users u ON i.AssigneeId = u.Id
ORDER BY i.Id DESC, i.AssigneeId ASC