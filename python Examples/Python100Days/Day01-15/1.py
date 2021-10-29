import sys

#查看python版本
print(sys.version)
print(sys.version_info)

import this
print(this.d)

import turtle

turtle.pensize(4)
turtle.pencolor('green')

turtle.forward(100)
turtle.right(90)

turtle.forward(100)
turtle.right(90)

turtle.forward(100)
turtle.right(90)

turtle.forward(100)
turtle.right(90)


turtle.color('red', 'yellow')
turtle.begin_fill()

while True:
    turtle.forward(200)
    turtle.left(170)
    if(abs(turtle.pos()) < 1):
        break
turtle.end_fill()
turtle.done()

# turtle.mainloop()

