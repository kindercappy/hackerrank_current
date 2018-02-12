var nums = [94431605, 679262176, 5284458];
function greater(n,m){
    var greaterM = m;
    var greaterN = n;
    if(greaterM > greaterN){
        //console.log(m);
        //console.log(n);    
        
        var small = greaterM - greaterN;
        // console.log(small);
        greater(greaterN,small);
    }else{
        var num1 = greaterN - greaterM; 
        return num1;
    }
}
function saveThePrisoner(n, m, s){
    // Complete this function
    var warnPrisnor = 0 ;
    var startCount = (m - 1);
    warnPrisnor = startCount+s;
    if(warnPrisnor > n){
        var num = greater(n,m);
        return num;
    }else{
        return warnPrisnor;
    }
}
var num = saveThePrisoner(nums[0],nums[1],nums[2]);
console.log(num);