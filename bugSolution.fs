let swapTuple x y = 
    (y, x)

let x2 = 10
let y2 = 20
let (x3,y3) = swapTuple x2 y2
printf "%d %d" x3 y3 //This will correctly print 20 10

//Alternative using pattern matching
let swapTuple2 (x,y) = (y,x)
let (x4,y4) = swapTuple2 (x2,y2)
printf "%d %d" x4 y4