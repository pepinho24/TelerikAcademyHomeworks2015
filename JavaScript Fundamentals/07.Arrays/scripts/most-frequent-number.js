function findMostFrequentNumber(arr) {
    var i,
        maxCount = 0,
        num,
        number,
        freq = [];

    for (i = 0; i < arr.length; i += 1) {
        if (isNaN(freq[arr[i]])) {
            freq[arr[i]] = 1;
        }
        else {
            freq[arr[i]] += 1;
        }
    }

    for (number in freq) {
        //console.log(number + ': ' + freq[number] + ' times')
        if (freq[number] > maxCount) {
            maxCount = freq[number];
            num = number;
        }
    }

    return {
        mostFrequentNumber: num,
        numberOfOccurrences: maxCount
    }
}

var number = findMostFrequentNumber([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
console.log(number.mostFrequentNumber + ': ' + number.numberOfOccurrences + ' time(s)')