Reverse = function(number) {
 var reversed = 0;

 while (number != 0) {
  reversed *= 10;
  reversed += number % 10;
  number -= number % 10;
  number /= 10;
 }

 return reversed;
}
function processData(input) {
    //Enter your code here
    var inputArr = input.split(" ");
    var from = Number(inputArr[0]);
    var to = Number(inputArr[1]);
    var k = Number(inputArr[2]);
    var howManyNums = to - from;
    var beautiDaysCandidates = [];
    if(from > to){
        return 0;
    }
    for(var i = 0; i <= howManyNums; i+=1){
        beautiDaysCandidates.push(from+i);
    }
    var beautiDays = 0;
    beautiDaysCandidates.forEach(function(ele){
        var originalEle = ele;
        var reversedEle = Reverse(ele);
        var wholeOrNot = (originalEle - reversedEle)/k;
        wholeOrNot % 1 === 0 ? beautiDays+=1 : "Enjoy"; 
    });
    console.log(beautiDays);
} 
processData([20,23,6]);