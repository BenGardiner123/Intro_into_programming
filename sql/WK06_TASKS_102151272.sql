UPDATE MOVIE1272
SET TMDB_VOTES = 1
WHERE RUNTIME >= 180 AND RATINGCODE = 'M'
OR RUNTIME >= 160 AND RATINGCODE = 'MA'