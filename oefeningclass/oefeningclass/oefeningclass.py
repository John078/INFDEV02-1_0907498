class Empty:
  def __init__(self):
      self.IsEmpty = True
Empty = Empty()

class Node:
  def __init__(self, value, tail):
      self.IsEmpty = False
      self.Value   = value
      self.Tail    = tail
  

#optellen van elementen van list

def sum(l):                     
    if l.IsEmpty:
        return 0
    else:
        return sum(l.Tail) + l.Value

print(sum(Node(1,Node(2,Node(3,Node(4,Empty))))))



#toevoegen van elementen, in dit geval + 10

def add(step, l):     
        while not(l.IsEmpty):
            print(l.Value + step)
            return add(step, l.Tail)

print(add(10, Node(1,Node(2,Node(3,Empty)))))



#elementen gedeeld door 2 moeten geprint worden

def sum(end, l):                     
    while not(l.IsEmpty):
        if l.Value%2 == 0:
            print(l.Value)
        return sum(end,l.Tail)

print(sum(0,Node(1,Node(2,Node(3,Node(4,Node(5,Empty)))))))