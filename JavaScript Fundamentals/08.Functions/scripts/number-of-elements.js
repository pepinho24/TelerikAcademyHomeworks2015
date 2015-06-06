/**
 * Problem 4. Number of elements

 Write a function to count the number of div elements on the web page
 */

function getDivElementsCount(){
    return document.getElementsByTagName('div').length;
    // the other way is to count the occurrences of the string '<div' in the web page
}
console.log(getDivElementsCount());