SELECT *
FROM MOVIE1272 M
WHERE LOWER(M.TITLE) NOT LIKE '[aei]%' OR UPPER(M.TITLE) NOT LIKE '[AEI]%';
ORDER BY (M.TITLE) ASC;




