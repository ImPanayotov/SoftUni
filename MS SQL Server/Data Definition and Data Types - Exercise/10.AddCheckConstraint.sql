ALTER TABLE Users 
ADD CONSTRAINT CHK_Password_Lenght 
CHECK (DATALENGTH([Password]) >= 4)