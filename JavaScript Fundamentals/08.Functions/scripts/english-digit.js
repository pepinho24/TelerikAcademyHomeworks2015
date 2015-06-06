/*Problem 1. English digit

 Write a function that returns the last digit of given integer as an English word.
 Examples:

 input	output
 512	two
 1024	four
 12309	nine
 *
 * */

function returnLastDigitOfIntegerAsEnglishWord(number) {
    var digitsAsStrings = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine']
    return digitsAsStrings[number % 10];
}

console.log(returnLastDigitOfIntegerAsEnglishWord(512));
console.log(returnLastDigitOfIntegerAsEnglishWord(1024));
console.log(returnLastDigitOfIntegerAsEnglishWord(12309));