class Empty:
    def Length(self):
        return 0
    def __str__(self):
        return "[]"
    def __rlshift__(l,x):
        return Node(x, l)
    def Map(self, f):
        return Empty()

class Node:
    def __init__(self, x, xs):
        self.Value = x
        self.Tail = xs
    def Length(self):
        return 1 + self.Tail.Length()
    def __str__(self):
        return str(self.Value) + "<<" + str(self.Tail)
    def __rlshift__(l, x):
        return Node(x, l)
    def Map(self, f):
        return Node(f(self.Value),self.Tail.Map(f))

l = Node(1, Node(2, Node(3, Empty())))
print(l.Map(lambda v: v + 10))