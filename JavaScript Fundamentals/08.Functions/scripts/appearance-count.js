/*<li> Write a function that counts how many times given number appears in given array.</li>
 <li> Write a test function to check if the function is working correctly.</li>*/
function countAppearances(array, key) {
    var num,
        count = 0;

    for (num in array) {
        if (array[num] === key) {
            count += 1;
        }
    }

    return count;
}

function testCountAppearances() {
    if (countAppearances([1, 2, 3, 3, 1, 2, 5, 7, 5, 3], 3) !== 3) {
        return false;
    }
    else if (countAppearances([1, 2, 3, 3, 1, 2, 5, 7, 5, 3], 5) !== 2) {
        return false;
    }
    else if (countAppearances([1, 2, 3, 3, 1, 2, 5, 7, 5, 3], 7) !== 1) {
        return false;
    }
    else if (countAppearances([1, 2, 3, 3, 1, 2, 5, 7, 5, 3], 1) !== 2) {
        return false;
    }
    else if (countAppearances([1, 2, 3, 3, 1, 2, 5, 7, 5, 3], 2) !== 2) {
        return false;
    }
    else {
        return true;
    }
}
var word = testCountAppearances() ? '' : 'not ';
console.log('The function is ' + word + 'working correctly!');