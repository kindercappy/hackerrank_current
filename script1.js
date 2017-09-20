var scores = [100, 100, 50, 40, 40, 20, 10];
var alice = [5, 25, 50, 120];
function main() {
    // your code goes here
    var scoresWithRank = [];
	var aliceRanking = 0;
    var rankings = 0;
    var aliceRankings = [];
    scores.forEach(function(ele){
    	if (scoresWithRank.length>0) {
    		for(var i = 0; i < scoresWithRank.length; i+=1){
    			if (scoresWithRank[i][1]===ele) {
    				scoresWithRank.push([rankings,ele]);
    				return;
    			}
    		}
    	}
    	rankings+=1;
    	scoresWithRank.push([rankings,ele]);
    });
    alice.forEach(function(ele){
    	aliceRanking=0;
    	for(var i = 0; i < scoresWithRank.length; i+=1){
    		var score = scoresWithRank[i][1];
    		if (ele === score) {
    			aliceRankings.push(aliceRanking);
    			return;
    		}else if (ele < score) {
    			if (i < scoresWithRank.length-1) {
    				aliceRanking+=1;
    			}
    			// return;
    		}else if (ele > score) {
    			aliceRankings.push(scoresWithRank[i][0]);
    			return;
    		}
    	}
    	aliceRankings.push(aliceRanking);
    });
    console.log(aliceRankings);
}
main();
