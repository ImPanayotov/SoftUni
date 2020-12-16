function ComputeGreatestCommonDiviser(x, y){

    while(y) {
        var t = y;
        y = x % y;
        x = t;
      }

      return x;
}


ComputeGreatestCommonDiviser(2154,458);