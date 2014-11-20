/**
 * https://codility.com/demo/results/demoU2GQHH-BPE/  O(1) 100%/100%
 * by AD
 */

function solution(X, Y, D) {
    if (X >= Y) {
        return 0;
    }
    
    return Math.ceil( (Y-X) / D );
}

