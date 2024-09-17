ALTER TABLE [dbo].[Users]
ADD CONSTRAINT FK_Users_Patients
FOREIGN KEY ([patient_id]) REFERENCES [dbo].[Patients]([patient_id]) ON DELETE CASCADE;
