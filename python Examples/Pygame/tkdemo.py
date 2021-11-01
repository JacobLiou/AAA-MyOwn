from tkinter import *

top = Tk()

# python tkinter tutorial
# turtlr基于 Tk  桌面应用 wxpython pyGTK pyQT
name = Label(top, text="Name").grid(row=0, column=0)
e1 = Entry(top).grid(row=0, column=1)
password = Label(top, text="Password").grid(row=1, column=0)
e2 = Entry(top).grid(row=1, column=1)
submit = Button(top, text="Submit").grid(row=2, column=1)

top.mainloop()
