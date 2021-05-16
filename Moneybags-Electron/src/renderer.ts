// This file is required by the index.html file and will
// be executed in the renderer process for that window.
// All of the Node.js APIs are available in this process.
import * as electron from "electron";
import { Titlebar, Color, Themebar } from "custom-electron-titlebar"


const win = electron.remote.getCurrentWindow(); /* Note this is different to the
html global `window` variable */

// When document has loaded, initialise
document.onreadystatechange = (event) => {
    if (document.readyState == "complete") {
        console.log('Document Ready')
    }
};

let titleBar: Titlebar = new Titlebar({
    backgroundColor: Color.fromHex('#444'),
    shadow: false,
    icon: 'res/moneybag_emoji.ico',
    titleHorizontalAlignment: "center"
});

let windowCreatePersonaHeader: HTMLElement = document.getElementById('windowCreatePersonaHeader');
let windowCreatePersona: HTMLElement = document.getElementById('windowCreatePersona');

var mousePosition: { x: number, y: number };
var offset: number[] = [0, 0];
var isDown: boolean = false;


// Function to create a draggable element/panel
// Be sure to have CSS set the position of the panel to absolute
function createDraggableWindow(window: HTMLElement, windowHandle: HTMLElement) {
    windowHandle.addEventListener('mousedown', function (e) {
        isDown = true;
        offset = [window.offsetLeft - e.clientX,
        window.offsetTop - e.clientY];
    }, true);

    document.addEventListener('mouseup', function () {
        isDown = false;
    }, true);

    document.addEventListener('mousemove', function (event) {
        event.preventDefault();
        if (isDown) {
            mousePosition = {
                x: event.clientX,
                y: event.clientY
            };
            window.style.left = (mousePosition.x + offset[0]) + 'px';
            window.style.top = (mousePosition.y + offset[1]) + 'px';
        }
    }, true);
}

createDraggableWindow(windowCreatePersona, windowCreatePersonaHeader);

function hideWindow(window: HTMLElement, windowHandle: HTMLElement) {
    window.style.visibility = 'hidden';
    windowHandle.style.visibility = 'hidden';
}

function showWindow(window: HTMLElement, windowHandle: HTMLElement) {
    window.style.visibility = 'visible';
    windowHandle.style.visibility = 'visible';
}

