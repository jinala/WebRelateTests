NUM_RUNS=1
./UrlTests/bin/Debug/UrlTests --noresult 
$NUM_RUNS 1 1
./UrlTests/bin/Debug/UrlTests --noresult $NUM_RUNS 2 1
./UrlTests/bin/Debug/UrlTests --noresult $NUM_RUNS 3 1
./UrlTests/bin/Debug/UrlTests --noresult $NUM_RUNS 4 1
./UrlTests/bin/Debug/UrlTests --noresult $NUM_RUNS 1 0


./ExtractionTests/bin/Debug/ExtractionTests --noresult $NUM_RUNS 1
./ExtractionTests/bin/Debug/ExtractionTests --noresult $NUM_RUNS 0