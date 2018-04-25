var btn = document.createElement("BUTTON")
btn.setAttribute("class" , "btn01");
document.body.appendChild(btn)
var btn02 = document.createElement("BUTTON")
btn02.setAttribute("class" , "btn02");
document.body.appendChild(btn02)
var artma=0;
var x = 462;
var backgroundImage = new Array(); 
backgroundImage[0] = "image/02.jpg"
backgroundImage[1] = "image/01.jpg"
backgroundImage[2] =  "image/03.jpg"
backgroundImage[3] = "image/01.jpg"
backgroundImage[4] =  "image/03.jpg"
backgroundImage[5] = "image/02.jpg"

var div02 = document.createElement("DIV")
div02.setAttribute("class" , "div055");
var divbig = document.createElement("DIV")
divbig.style.height = "450px";
document.body.appendChild(div02);
div02.appendChild(divbig);
div02.appendChild(btn)
div02.appendChild(btn02)



for(i = 0; i<backgroundImage.length; i++){
   
    var div = document.createElement("DIV")
    div.style.width = "440px";
    div.style.height= "300px";
    
    div.style.background="url("+backgroundImage[i]+")";
    div.style.position = "absolute;"
    div.style.border = "1px solid black"
    div.style.display = "inline-block";
    div.style.marginLeft = "20px"
    div.style.marginTop = "50px"
    div.style.display = "hidden"
    document.body.appendChild(div);
    divbig.appendChild(div);
    divbig.style.width = x + "px";
    x=x+462
    
}
btn.onclick=function(){
    artma+=1386;
    document.querySelector(".div055>div:first-child").style.right=artma+"px";

}
btn02.onclick=function(){
    artma-=1386;
    document.querySelector(".div055>div:first-child").style.left=artma+"px";

}
