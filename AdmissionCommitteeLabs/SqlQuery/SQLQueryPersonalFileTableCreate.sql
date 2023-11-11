CREATE TABLE PersonalFile (
    Personal_file_Id INT PRIMARY KEY CHECK (Personal_file_Id >= 1),
    Applicant_ID INT CHECK (Applicant_ID >= 0),
    Document_submission_date DATE,
    FOREIGN KEY (Applicant_ID) REFERENCES ApplicantsData(Applicant_ID)
);
