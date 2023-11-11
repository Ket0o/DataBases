CREATE TABLE ApplicantsRankingLists (
    Ranking_list_ID INT PRIMARY KEY CHECK (Ranking_list_ID >= 1),
    Personal_file_ID INT CHECK (Personal_file_ID >= 1),
    Scores_with_all_achievements_considered INT CHECK (Scores_with_all_achievements_considered >= 0),
    Rank_position INT CHECK (Rank_position >= 1),
    FOREIGN KEY (Personal_file_ID) REFERENCES PersonalFile(Personal_file_Id)
);
