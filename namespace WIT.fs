namespace WIT

module COMP3350 =
    (* Add 2 numbers x and y *)
    let add2 x y = x + y

    (* Compute the arithmetic average of x and y*)
    let avg2 x y = 
        ( float (x) + float (y) ) / 2.0

    (* Add the two numbers in a tuple *)
    let addTuples pairInts = 
      fst(pairInts) + snd(pairInts)

    (* Add the four numbers in a pair of tuples *)
    let addTuplesNested pairPair = 
        fst(fst pairPair) + fst(snd pairPair) + snd(fst pairPair) + snd(snd pairPair)
        

    (* Compute the greatest common divisor using Euclid's method *)
    let rec gcd x y =
        if (y = 0) then x

        else
            gcd y (x % y)
