var _queueArray;
var _tail:number;
var _head:number;
var _length:number;

newQueue(3);
enqueue(1);
enqueue(2);
enqueue(3);
enqueue(4);
enqueue(5); //overflow

console.log(dequeue());
console.log(dequeue());
console.log(dequeue());
console.log(dequeue());
console.log(dequeue());//underflow

function isFull():boolean
{
    if((_tail > _length && _head == 0))
        return true;
    else
        return false;
}

function isEmpty():boolean
{
    if((_tail <= _head))
        return true;
    else
        return false;
}

function newQueue(size:number)
{
    _queueArray = [size];
    _head = 0; //the queue is empty
    _tail = 0;
    _length = size;
}

function enqueue(newItem:number)
{
    if(isFull())
    {
        console.log("Cannot enqueue. Full");
        return null;
    }
    _queueArray[_tail] = newItem;
    _tail++;
}

function dequeue():number
{
    if(isEmpty())
    {
        console.log("Cannot dequeue. Empty");
        return null;
    }
    var item:number = _queueArray[_head];
    _head++;
    return item;
}