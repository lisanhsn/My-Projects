from tkinter import *

KM_VALUE = 1.609

window = Tk()

window.title("Miles to KM converter")
window.config(pady=20, padx=20)

is_equal = Label(text="is equal to")
is_equal.grid(column=0, row=2)
is_equal.config(pady=10)

result = Label(text="0")
result.grid(column=1, row=2)
result.config(pady=10)

km_data = Entry(width=10)
km_data.focus()
km_data.grid(column=1, row=1)

miles_unit = Label(text="KM")
miles_unit.grid(column=2, row=2)
miles_unit.config(padx=10)

km_unit = Label(text="Miles")
km_unit.grid(column=2, row=1)
km_unit.config(padx=10)


def calc():
    ans = int(km_data.get()) * KM_VALUE
    result.config(text=ans)


calculate_btn = Button(text="Calculate", command=calc)
calculate_btn.grid(column=1, row=3)

window.mainloop()
