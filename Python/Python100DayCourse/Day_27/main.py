from tkinter import *

window = Tk()
window.minsize(500, 300)
window.config(padx=100, pady=200)
# my_label = Label(text="Lisan Hossain", font=("MonoLisa", 20, "bold"))
# my_label.grid(column=0, row=0)

#
# # my_label["text"] = "New Text"
# # my_label.config(text="New Text")
# #
# def btn_clicked():
#     my_label.config(text=input.get())
#
#
# btn = Button(text="Click Me", command=btn_clicked)
# btn.grid(column=1,row=1)
#
# input = Entry(width=10)
# input.grid(column=2,row=2)


# def spining():
#     print(spinbox.get())


# spinbox = Spinbox(from_=0,
#                   to=10, width=5,
#                   command=spining)
# spinbox.pack()


# def ch_fn():
#     print(check_state.get())
#
#
# check_state = IntVar()
# check_btn = Checkbutton(text="Is it ON", variable=check_state, command=ch_fn)
# check_btn.pack()


# Challenge:
def change_label():
    label.config(text=input.get())


label = Label(text="A Label")
label.grid(column=0, row=0)

btn_1 = Button(text="Button", command=change_label)
btn_1.grid(column=1, row=2)

btn_2 = Button(text="Button_2", command=change_label)
btn_2.grid(column=2, row=0)

input = Entry(text="text")
input.grid(column=3, row=2)

window.mainloop()
