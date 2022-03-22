var _queueArray;
var _tail:number;
var _head:number;
var _length:number;

newQueue(3);
Enqueue(1);
Enqueue(2);
Enqueue(3);
Enqueue(4);
Enqueue(5); //overflow

console.log(Dequeue());
console.log(Dequeue());
console.log(Dequeue());
console.log(Dequeue());
console.log(Dequeue());//underflow

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

function Enqueue(newItem:number)
{
    if(isFull())
    {
        console.log("Cannot enqueue. Full");
    }
    _queueArray[_tail] = newItem;
    if(_tail == _length)
        _tail =1;
    else
        _tail++;
}

function Dequeue():number
{
    if(isEmpty())
    {
        console.log("Cannot dequeue. Empty");
        return null;
    }
    var item:number = _queueArray[_head];
    if (_head == _length)
        _head = 1;
    else
        _head++;
    return item;
}