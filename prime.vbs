'ali yazbek
'input a number and output one diviser or 0 if the number is prime
'..we need to use d as divisor
n=int(inputbox("enter a number"))
if n mod 2=0 then  
    msgbox 2
else  
    d=3
    while d^2 <= n
        if n mod d=0 then
            msgbox d
            '--- end program
        end if
        d= d+2
    wend
    msgbox 0
end if
'--- end program