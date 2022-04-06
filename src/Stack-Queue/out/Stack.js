var _stackArray;
var _top;
//push some values onto the stack
newStack(10);
Push(1);
Push(2);
Push(3);
Push(4);
//pop them off and see the order reversed
console.log(Pop());
console.log(Pop());
console.log(Pop());
console.log(Pop());
function isStackEmpty() {
    if (_top == 0)
        return true;
    else
        return false;
}
function newStack(size) {
    _stackArray = [size];
    _top = 0; //the stack is empty
}
function Push(newItem) {
    _stackArray[_top] = newItem;
    _top = _top + 1;
}
function Pop() {
    if (isStackEmpty()) {
        console.log("Stack Underflow"); //nothing in the stack
    }
    else {
        var value = _stackArray[_top];
        _top--; //decrement the top
        return value;
    }
}
//# sourceMappingURL=Stack.js.map