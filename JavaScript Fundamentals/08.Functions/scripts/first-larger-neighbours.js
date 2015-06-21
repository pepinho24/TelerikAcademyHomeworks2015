/**
 * Problem 7. First larger than neighbours

 Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.
 */
function isLargerThanNeighbours(arr, index) {
    index = index*1;
    if (index < 0 || 2 > arr.length || index >= arr.length) {
        // invalid index or no neighbours
        return -1;
    }

    if (index === 0) {
        if (arr[index] > arr[index + 1]) {
            return true;
        }
    }
    else if (index === arr.length - 1) {
        if (arr[index] > arr[index - 1]) {
            return true;
        }
    }
    else {
        if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]) {
            return true;
        }
    }
    return false;
}

function firstLargerThanNeighbours(arr) {
    var i;

    for (i in arr) {
        if (isLargerThanNeighbours(arr, i)) {
            return i;
        }
    }
    return -1;
}
//console.log(isLargerThanNeighbours([1,2,0,4,5],1 ));// true
console.log(firstLargerThanNeighbours([1,2,0,4,5]));// 1
console.log(firstLargerThanNeighbours([1,2,3,4,5]));// 4
console.log(firstLargerThanNeighbours([1,2,3,4,4]));// -1