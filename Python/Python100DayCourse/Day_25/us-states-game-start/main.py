import turtle

import pandas

sc = turtle.Screen()
sc.title("Us State Game")
img = "blank_states_img.gif"
turtle.addshape(img)
turtle.shape(img)
guessed_state = []

while len(guessed_state) < 50:
    answer_state = turtle.textinput(title=f"Your score {len(guessed_state)}/50 ",
                                    prompt="Enter the state name").title()
    data = pandas.read_csv("50_states.csv")
    all_states = data.state.to_list()
    if answer_state == "Exit":
        missing_state = [state for state in all_states if state not in guessed_state]
        # missing_state = []
        # for state in all_states:
        #     if state not in guessed_state:
        #         missing_state.append(state)
        new_data = pandas.DataFrame(missing_state)
        new_data.to_csv("./state_to_learn.csv")
        break
    if answer_state in all_states:
        guessed_state.append(answer_state)
        t = turtle.Turtle()
        t.hideturtle()
        t.penup()
        state_data = data[data.state == answer_state]
        t.goto(int(state_data.x), int(state_data.y))
        t.write(state_data.state.item())
