SELECT right(Email, len(Email) - charindex('@', Email)) as [Email Provider],
       Count(*)                                         as [Number of Users]
From Users
GROUP BY right(Email, len(Email) - charindex('@', Email))
order by [Number of Users] desc, [Email Provider]