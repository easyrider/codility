/**
 * https://codility.com/demo/results/demo64Q7EQ-ZP6/ 100%
 * by Ad 
 */

function solution(A) {
    var B = [];
    var result;
    
    if (A.length === 1) {
        return A[0] <= 0 ? 1 : A[0] + 1;
    }
    
    for (var i = 0; i <= A.length-1; i++) {
        if (A[i] > 0 && B[A[i]] === undefined) {
            B[A[i]] = A[i];
        }
    }
    
    if (!B.length) {
        return 1;
    }
    
    for (var j = 1; j <= B.length; j++) {
        if (!B.hasOwnProperty(j)) {
            result =  j;
            break;
        }
    }
    
    return result;
}