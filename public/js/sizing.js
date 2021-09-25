const height = window.innerHeight;
const maxHeight = [height * 0.2, height * 0.25, height * 0.5];
function sizeBlocks(){
    let blocks = document.getElementsByClassName("block");
    for(let i = 0; i < blocks.length; i++){
        blocks[i].style.height = height + 'px';
    }
}


function resizeOnScroll(maxHeight, block){

}