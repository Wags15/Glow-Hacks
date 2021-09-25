const height = window.innerHeight;
let animations;


function sizeBlocks() {
    let blocks = document.getElementsByClassName("block");
    for (let i = 0; i < blocks.length; i++) {
        blocks[i].style.height = height + 'px';
    }
    let mediumBlocks = document.getElementsByClassName("medium-block")
    for (let i = 0; i < mediumBlocks.length; i++) {
        mediumBlocks[i].style.height = Math.round(height/3) + 'px';
    }

    animations = document.getElementsByClassName("animation");
}

window.onscroll = function () {
    let diff = document.documentElement.scrollTop - height;

    if (diff >= -1*(height*.2) && animations[0].className != 'block-two-animation border animation'){
        animations[0].className = 'block-two-animation border animation';
    }else if(diff * -1 >= height-100 && animations[0].className != 'border animation'){
        animations[0].className = 'border animation';
    }
       
}



