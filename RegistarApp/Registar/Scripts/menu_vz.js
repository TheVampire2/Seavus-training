$(document).ready(function(){

  //properties for changing slider's width and margin 
var animateWidth;
var animateMargin;

var hAnimateWidth;
var hAnimateMargin;

 //currently selected or hovvered menu item
var isSelected;
var isHovered;

    ///functions -- with leading h are for hover -functions
// returns current sliders margin
function getMargin() {
    var margin = 0;
    for (var i = 0; i < isSelected; i++) {
        margin += itemsWidth[i];
    }
    return margin;
}
function hGetMargin() {
    var margin;
    if (isSelected < isHovered) {
        margin = 0;
        for (var i = 0; i < isHovered; i++) {
            margin += itemsWidth[i];
        }
        return margin;
    }
    else if (isSelected > isHovered) {
        margin = animateMargin;
        for (var i = isSelected - 1; i >= isHovered; i--) {
            margin -= itemsWidth[i];
        }
        return margin;
    }
    else return animateMargin;
   
}

// set the properties of the sliders
function selected() {
    animateWidth = itemsWidth[isSelected];
    animateMargin = getMargin();
}

function hovered() {
    hAnimateWidth = itemsWidth[isHovered];
    hAnimateMargin = hGetMargin();
}

//animte the sliders
function animateSliders() {

    slider1.animate({
        width: animateWidth,
        "margin-left": animateMargin
    }, 500);
    slider2.animate({
        width: animateWidth,
        "margin-left": animateMargin
    }, 300);
    slider3.animate({
        width: animateWidth,
        "margin-left": animateMargin
    }, 700);
}

function hAnimateSliders() {

    slider1.animate({
        width: hAnimateWidth,
        "margin-left": hAnimateMargin
    }, 500);
    slider2.animate({
        width: hAnimateWidth,
        "margin-left": hAnimateMargin
    }, 300);
    slider3.animate({
        width: hAnimateWidth,
        "margin-left": hAnimateMargin
    }, 700);
}
//stop all the sliders
function stopSliders() {
    slider1.stop();
    slider2.stop();
    slider3.stop();
}
// set width to all the sliders
function setSliderWidth() {
    slider1.width(arguments[0]);
    slider2.width(arguments[0]);
    slider3.width(arguments[0]);
}

    //making hover functions to all menu items 

    //setting the currently selected menu item and sliding the slider
function itemClick() {

    var page = document.location.href.match(/[^\/]+$/);
    for (var i = 0; i < arguments.length; i++) {
        if (arguments[i].indexOf(page) > -1) {
            isSelected = i;
            setSliderWidth(itemsWidth[i]);
            selected();
            animateSliders();
            break;
        }
    }

}


// get the sliders ---- can be refactored 
var slider1 = $("#slider1");
var slider2 = $("#slider2");
var slider3 = $("#slider3");

// get the menu items
var items = $(".title");
var itemsWidth = [];

// get the menu items width
for (var i = 0; i < items.length; i++) {
    itemsWidth[i] = items[i].offsetWidth;
   // console.log(itemsWidth[i]);
}


//set start situation


    //console.log(document.location.href.match(/[^\/]+$/));

    //enter strings in format in order with menu items:
    //selected__("index.html,home.html","about.html,about")
itemClick("index.html,Home,index.html", "register.html", "settings.html");

$(".title").hover(function () {
    isHovered = $(this).index();
    hovered();
    stopSliders();
    hAnimateSliders();
},function(){
    stopSliders();
    animateSliders();
});   





});