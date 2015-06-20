/*  Write a function that finds all the prime numbers in a range
 It should return the prime numbers in an array
 It must throw an Error if any of the range params is not convertible to Number
 It must throw an Error if any of the range params is missing
 */
function solve() {
    function FindAllPrimeNumbersInRange(start, end) {

        if (isNaN(start) || isNaN(end)) {
            throw new Error();
        }

        // Eratosthenes algorithm to find all primes under n
        var i,
            array = [],
            upperLimit = Math.sqrt(end),
            output = [];

        // Make an array from 2 to (n - 1)
        for (i = 0; i <= end; i++) {
            array.push(true);
        }

        // Remove multiples of primes starting from 2, 3, 5,...
        for (i = 2; i < upperLimit; i++) {
            if (array[i]) {
                for (var j = i * i; j <= end; j += i) {
                    array[j] = false;
                }
            }
        }
        if (start < 2) {
            start = 2
        }
        // All array[i] set to true are primes
        for (i = start; i <= end; i++) {
            if (array[i]) {
                output.push(i);
            }
        }

        return output;
    }

    return FindAllPrimeNumbersInRange;
}