CREATE TABLE EnrollmentOrders (
    Enrollment_order_ID INT PRIMARY KEY CHECK (Enrollment_order_ID >= 1),
    Ranking_list_ID INT CHECK (Ranking_list_ID >= 1),
    Full_name NVARCHAR(100),
    University_group NVARCHAR(10),
    FOREIGN KEY (Ranking_list_ID) REFERENCES ApplicantsRankingLists(Ranking_list_ID)
);
