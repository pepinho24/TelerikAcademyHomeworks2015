/**
 * Problem 6. Larger than neighbours

 Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).
 */
function isLargerThanNeighbours(arr, index) {
    index = index*1;
    if (index < 0 || 2 > arr.length|| index >= arr.length) {
        // invalid index or no neighbours
        return -1;
    }

    if (index === 0 ) {
        if (arr[index] > arr[index + 1]) {
            return true;
        }
    }
    else if (index === arr.length -1 ) {
        if (arr[index] > arr[index - 1]) {
            return true;
        }
    }
    else{
        if (arr[index] > arr[index - 1]&&arr[index] > arr[index + 1]) {
            return true;
        }
    }
    return false;
}

console.log(isLargerThanNeighbours([2,0,4,5],0 ));// true
console.log(isLargerThanNeighbours([1,2,0,4,5],1 ));// true
console.log(isLargerThanNeighbours([1,2,0,4,5],2 ));// false
console.log(isLargerThanNeighbours([1,2,0,4,5],3 ));// false
console.log(isLargerThanNeighbours([1,2,0,4,5],4 ));// true