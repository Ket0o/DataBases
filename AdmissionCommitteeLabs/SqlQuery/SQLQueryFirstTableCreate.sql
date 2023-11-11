CREATE TABLE ApplicantsData (
    Applicant_ID INT PRIMARY KEY CHECK (Applicant_ID >= 0),
    Identity_and_citizenship_document_code INT CHECK (Identity_and_citizenship_document_code >= 0),
    Previous_education_document_code INT CHECK (Previous_education_document_code >= 0),
    Admission_application_and_personal_data_processing_consent_code INT CHECK (Admission_application_and_personal_data_processing_consent_code >= 0),
    Enrollment_application_code INT CHECK (Enrollment_application_code >= 0),
    Unifield_State_Exam_scores INT CHECK (Unifield_State_Exam_scores >= 0 AND Unifield_State_Exam_scores <= 300)
);
