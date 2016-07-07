class Empty:
    def __init__ (self):
        self.IsEmpty = True

Empty = Empty()

class Node:
    def __init__ (self, value, tail):
        self.IsEmpty = False
        self.Value = value
        self.Tail = tail


count = input("number")
l = Empty
for i in range(0,count):
    l = Node(i, l)

x = l
while not (x.IsEmpty):
    print_backward(x.Value)
    x = x.Tail

