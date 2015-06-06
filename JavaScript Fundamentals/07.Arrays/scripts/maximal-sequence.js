function FindMaximalSequence(array) {
    var count,
        maxCount = 0,
        len = array.length,
        arr = [],
        maxArr = [];

    if (len === 1) {
        return array;
    }
    arr.push(array[0]);
    count = 1;
    for (var i = 1; i < len; i += 1) {
        if (array[i] === array[i - 1]) {
            count += 1;
            arr.push(array[i]);
        }
        else {
            if (count > maxCount) {
                maxCount = count;
                maxArr = arr.slice(0);
            }
            arr = [];
            arr.push(array[i]);
            count = 1;
        }
    }
    if (count > maxCount) {
        maxCount = count;
        maxArr = arr.slice(0);
    }

    return maxArr;
}

console.log(FindMaximalSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));