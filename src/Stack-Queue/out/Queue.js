var _queueArray;
var _tail;
var _head;
var _length;
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
console.log(dequeue()); //underflow
function isFull() {
    if ((_tail > _length && _head == 0))
        return true;
    else
        return false;
}
function isEmpty() {
    if ((_tail <= _head))
        return true;
    else
        return false;
}
function newQueue(size) {
    _queueArray = [size];
    _head = 0; //the queue is empty
    _tail = 0;
    _length = size;
}
function enqueue(newItem) {
    if (isFull()) {
        console.log("Cannot enqueue. Full");
        return null;
    }
    _queueArray[_tail] = newItem;
    _tail++;
}
function dequeue() {
    if (isEmpty()) {
        console.log("Cannot dequeue. Empty");
        return null;
    }
    var item = _queueArray[_head];
    _head++;
    return item;
}
//# sourceMappingURL=Queue.js.map