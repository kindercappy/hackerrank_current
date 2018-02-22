var a = [4, 6, 5, 3, 3, 1];
var count = 0;
var numArray = [];
for (var i = 0; i < a.length; i += 1) {
    for (var j = 0; j < a.length; j += 1) {
        if (i === j) {
            continue;
        }
        var diff = Math.abs(a[i] - a[j]);
        if (diff === 1 || diff === 0) {
            for (var l = 0; l < numArray.length; l += 1) {
                if (numArray[l][0] === a[i] && numArray[l][1] === a[j] || numArray[l][1] === a[i] && numArray[l][0] === a[j]) {
                    break;
                }
            }
            numArray.push([a[i], a[j]]);
            break;
        }
    }
    var count1 = 0;
    var arrrayNum = numArray.filter(function(ele) {
        var greater = 0;
        for (var i = 0; i < numArray.length; i += 1) {
            if (ele[0] - numArray[i][0] !== 1 || ele[1] - numArray[i][1] !== 1 || ele[1] - numArray[i][0] !== 1 || ele[0] - numArray[i][1] !== 1) {
                return;
            } else {
                return numArray[i];
            }
        }
        count += 1;
    });
}
console.log(numArray);