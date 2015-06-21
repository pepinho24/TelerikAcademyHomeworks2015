function findByBinarySearch(arr, key, minIndex, maxIndex) {
    var imin = minIndex || 0,
        imax = maxIndex || arr.length-1,
        imid = (imax / 2) | 0;

    // continue searching while [imin,imax] is not empty
    while (imax >= imin) {
        // calculate the midpoint for roughly equal partition
        // imid = midpoint(imin, imax);
        imid = ((imax + imin) / 2) | 0;

        if (arr[imid] === key)
        // key found at index imid
            return imid;
        // determine which subarray to search
        else if (arr[imid] < key)
        // change min index to search upper subarray
            imin = imid + 1;
        else
        // change max index to search lower subarray
            imax = imid - 1;
    }
    // key was not found
    return -1;
}

console.log(findByBinarySearch([1,2,3,4,5,5,6,7,15,19],6))
console.log(findByBinarySearch([1,2,3,4,5,5,6,7,15,19],8))