class Question:
    def __init__(self, question_id, text, answer_type, next_question):
        self.id = question_id
        self.text = text
        self.answer_type = answer_type
        self.next_question = next_question

def main():
    #Defined all the questions
    questions = [
        Question(
            question_id=1,
            text="Do you use a phone?",
            answer_type="radio",
            next_question={
                "Yes": 2,
                "No": 3
            }
        ),
        Question(
            question_id=2,
            text="What brand of phone do you use?",
            answer_type="textbox",
            next_question={
                "Samsung": 4,
                "Apple": 5,
                "Xiaomi": 6
            }
        ),
        Question(
            question_id=3,
            text="What is the reason for not using a phone?",
            answer_type="textbox",
            next_question={}
        ),
        Question(
            question_id=4,
            text="Do you use Samsung because it is better?",
            answer_type="radio",
            next_question={
                "Yes": 6,
                "No": 7
            }
        ),
        Question(
            question_id=5,
            text="Why do you prefer Apple?",
            answer_type="textbox",
            next_question={}
        ),
        Question(
            question_id=6,
            text="Why do you like this brand?",
            answer_type="textbox",
            next_question={}
        ),
        Question(
            question_id=7,
            text="What brand do you think is better than Samsung?",
            answer_type="textbox",
            next_question={}
        )
    ]

    
    user_answers = {}#Dictionary to store the user's answers

    
    current_question_id = 1#The first question (starting)

    #Loop until no valid next question
    while current_question_id != 0:
        #Find the current question by ID
        current_question = next((q for q in questions if q.id == current_question_id), None)
        if current_question is None:
            print("Error: Question not found!")
            break

        #Display the question and read user input
        print(current_question.text)
        answer = input().strip()
        user_answers[current_question_id] = answer

        #Determines the next question ID based on the user's answer
        if answer in current_question.next_question:
            current_question_id = current_question.next_question[answer]
        elif not current_question.next_question:
            #If the answer is not in next_question end the survey
            current_question_id = 0
        else:
            print("Invalid answer. Please try again.")
            user_answers.pop(current_question_id)  #Remove invalid answer
            continue  #Asks the same question

    print("\nSurvey Completed. Your answers:")
    for q_id, ans in user_answers.items():
        print(f"Question {q_id}: {ans}")

if __name__ == "__main__":
    main()
