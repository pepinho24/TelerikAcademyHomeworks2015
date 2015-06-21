/**
 Problem 3. Occurrences of word

 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.
 */

function findNumberOfOccurrences(text, word, caseSensitive) {
    var caseSensitiveOptions = caseSensitive === true ? 'g' : 'gi';
    var regex = new RegExp(word, caseSensitiveOptions)
    return text.match(regex)
}

function findIndexesOfOccurrences(text, word, caseInsensitive) {
    var indexes = [];
    var index = 0;
    if(caseInsensitive===true){
        text = text.toLowerCase();
        word=word.toLowerCase();
    }
    while (index <= text.length) {
        if (text.indexOf(word, index) >= 0) {
            index = text.indexOf(word, index);
            indexes.push(index)
            index+=1;
        }
        else{
            break;
        }
    }
    return indexes
}
var str = 'sed Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at sed mollis arcu. Sed consectetur faucibus erat suscipit cursus. Sed luctus sit amet odio scelerisque mollis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Suspendisse lectus sem, efficitur eu mi accumsan, dignissim consectetur ligula. Mauris interdum luctus augue vitae finibus. Proin dui nisl, ullamcorper non iaculis non, varius sit amet dolor.'

var caseSensitiveSearch = findNumberOfOccurrences(str, 'Sed', true); // case sensitive
var caseInsensitiveSearch = findNumberOfOccurrences(str, 'Sed'); // case insensitive
var caseInsensitiveSearchIndexes = findIndexesOfOccurrences(str,'Sed',true);
var caseSensitiveSearchIndexes = findIndexesOfOccurrences(str,'Sed');

console.log('Case sensitive: ' + caseSensitiveSearch);
console.log('Case insensitive: ' + caseInsensitiveSearch);
console.log('Case sensitive indexes: ' + caseSensitiveSearchIndexes);
console.log('Case insensitive indexes: ' + caseInsensitiveSearchIndexes);