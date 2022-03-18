var _stackArray;
var _top:number;

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

function isStackEmpty():boolean
{
    if(_top == 0)
        return true;
    else
        return false;
}

function newStack(size:number)
{
     _stackArray = [size];
    _top = 0; //the stack is empty
}

function Push(newItem:number)
{
    _stackArray[_top] = newItem;
    _top=_top+1;
}

function Pop():number
{
    if(isStackEmpty())
    {
        console.log("Stack Underflow") //nothing in the stack
    }
    else
    {
        var value:number =  _stackArray[_top];
        _top--;//decrement the top
        return value;
    }
}