/*Problem 2. Lexicographically comparison

 Write a script that compares two char arrays lexicographically (letter by letter).*/

function CompareCharArraysLexycographycally(firstCharArray, secondCharArray) {
    var firstLen, secondLen, minLen,index;

    if (!(Array.isArray(firstCharArray) && Array.isArray(secondCharArray))) {
        return false;
    }
    firstLen = firstCharArray.length;
    secondLen = secondCharArray.length;
    minLen = Math.min(firstLen,secondLen);

    for (var index = 0; index < minLen; index+=1) {
        if (secondCharArray[index] !== firstCharArray[index]) {
            return firstCharArray[index] < secondCharArray[index] ? -1 : 1;
        }
    }

    if (firstLen !== secondLen) {
     return   firstLen < secondLen ? -1 : 1;
    }

    return 0;
}

var firstArr, secondArr;
firstArr = ['a','b','c'];
secondArr = ['a','c','b'];
console.log(CompareCharArraysLexycographycally(firstArr,secondArr));

firstArr = ['a','b','c'];
secondArr = ['a','a','b'];
console.log(CompareCharArraysLexycographycally(firstArr,secondArr));

firstArr = ['b','b'];
secondArr = ['a','c','b'];
console.log(CompareCharArraysLexycographycally(firstArr,secondArr));

firstArr = ['a','b','c'];
secondArr = ['a','b'];
console.log(CompareCharArraysLexycographycally(firstArr,secondArr));

firstArr = ['a','b','c'];
secondArr = ['a','b','c'];
console.log(CompareCharArraysLexycographycally(firstArr,secondArr));