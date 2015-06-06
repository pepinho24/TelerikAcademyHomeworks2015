function sortUsingSelectionSortAlgorithm(arr) {
    /* a[0] to a[n-1] is the array to sort */
    var i,
        j,
        len = arr.length,
        temp,
        iMin;

    /* advance the position through the entire array */
    /*   (could do j < n-1 because single element is also min element) */
    for (j = 0; j < len - 1; j++) {
        /* find the min element in the unsorted a[j .. n-1] */

        /* assume the min is the first element */
        iMin = j;
        /* test against elements after j to find the smallest */
        for (i = j + 1; i < len; i++) {
            /* if this element is less, then it is the new minimum */
            if (arr[i] < arr[iMin]) {
                /* found new minimum; remember its index */
                iMin = i;
            }
        }

        if (iMin != j) {
            //swap(a[j], a[iMin]);
            // a^=b, b^=a, a^=b - swap variables using XOR operation,
            // details: http://en.wikipedia.org/wiki/XOR_swap_algorithm
            // http://michalbe.blogspot.com/2013/03/javascript-less-known-parts-bitwise.html
            arr[j]^=arr[iMin];
            arr[iMin]^= arr[j];
            arr[j]^=arr[iMin];
         //   temp = arr[j];
         //   arr[j] = arr[iMin];
         //   arr[iMin]= temp;
        }
    }

    return arr;
}

console.log(sortUsingSelectionSortAlgorithm([1,2,5,7,4,2,6,4,8,2,1,5,6,7,8,4,1,23,5,4,8,1,-48,4]))