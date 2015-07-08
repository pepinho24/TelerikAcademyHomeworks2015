function solve() {
    function SumArrayOfNumbers(numbers) {
        var sum;

        if (numbers === undefined) {
            throw new Error();
        }

        if (numbers.length === 0) {
            return null;
        }

        sum = 0;

        for (var i = 0; i < numbers.length; i += 1) {
            if (isNaN(numbers[i])) {
                throw new Error();
            }
            sum += +numbers[i];
        }

        return sum;
    }

    return SumArrayOfNumbers;
}
/*
 Write a function that sums an array of numbers:
 Numbers must be always of type Number
 Returns null if the array is empty
 Throws Error if the parameter is not passed (undefined)
 Throws if any of the elements is not convertible to Number
 * */