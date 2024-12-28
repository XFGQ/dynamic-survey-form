using System;
using System.Collections.Generic;

namespace DynamicSurveyCSharp
{
    //Define a Question class to store the question text and options
    public class Question
    {
        public string Text { get; set; }
        public Dictionary<string, string> Options { get; set; }

        public Question(string text, Dictionary<string, string> options)
        {
            Text = text;
            Options = options;
        }
    }

    //Main survey logic
    class Program
    {
        static void Main(string[] args)
        {
            //Create our survey as a Dictionary<string, Question>
            Dictionary<string, Question> survey = BuildSurvey();

            //Tracking the current question ID starting at "q1"
            string currentQuestion = "q1";
            //Store user responses: questionID -> useris choice
            Dictionary<string, string> responses = new Dictionary<string, string>();

            while (!string.IsNullOrEmpty(currentQuestion))
            {
                Question questionData = survey[currentQuestion];
                Console.WriteLine(questionData.Text);

                //If this question has no options it must be an end state (like "q_end" or "q180")
                if (questionData.Options.Count == 0)
                {
                    //It might still allow the user to type something (ex. final comment)
                    string finalInput = Console.ReadLine().Trim();
                    responses[currentQuestion] = finalInput;
                    break;
                }

                //Otherwise read user input for the next step
                Console.Write("Your answer: ");
                string userInput = Console.ReadLine().Trim().ToLower();

                // Validate if userInput is a recognized option
                if (questionData.Options.ContainsKey(userInput))
                {
                    // Record the response
                    responses[currentQuestion] = userInput;

                    // Move on to the next question based on this answer
                    currentQuestion = questionData.Options[userInput];
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.\n");
                }
            }

            Console.WriteLine("\nSurvey completed. Your responses:");
            foreach (var kvp in responses)
            {
                Console.WriteLine($"[{kvp.Key}] {survey[kvp.Key].Text} => {kvp.Value}");
            }

            //Produce the dynamic final message:
            string finalMessage = InterpretResults(responses);
            Console.WriteLine("\n--- DYNAMIC RESULT ---");
            Console.WriteLine(finalMessage);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }


        private static Dictionary<string, Question> BuildSurvey()
        {
            //For brevity this matches your final Python dictionary but in C#
            //Each question ID -> new Question( "question text", new Dictionary<string, string>{ ... } )
            return new Dictionary<string, Question>
            {

                {
                    "q1",
                    new Question(
                        "Do you like sports? \n\n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q2"},
                            {"b", "q3"}
                        }
                    )
                },
                {
                    "q2",
                    new Question(
                        "How often do you play sports? \n A-) Daily \n B-) Weekly \n C-) Rarely",
                        new Dictionary<string, string>
                        {
                            {"a", "q4"},
                            {"b", "q5"},
                            {"c", "q6"}
                        }
                    )
                },
                {
                    "q3",
                    new Question(
                        "Would you like to play sports in the future? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q7"},
                            {"b", "q8"}
                        }
                    )
                },
                {
                    "q4",
                    new Question(
                        "Which sport do you like the most? \n A-) Football \n B-) Basketball \n C-) Others",
                        new Dictionary<string, string>
                        {
                            {"a", "q9"},
                            {"b", "q9"},
                            {"c", "q9"}
                        }
                    )
                },
                {
                    "q5",
                    new Question(
                        "Do you watch sports? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q10"},
                            {"b", "q11"}
                        }
                    )
                },
                {
                    "q6",
                    new Question(
                        "Do you prefer indoor or outdoor sports? \n A-) Indoor \n B-) Outdoor",
                        new Dictionary<string, string>
                        {
                            {"a", "q12"},
                            {"b", "q13"}
                        }
                    )
                },
                {
                    "q7",
                    new Question(
                        "Which sport would you like to try? \n A-) Swimming \n B-) Tennis \n C-) Others",
                        new Dictionary<string, string>
                        {
                            {"a", "q14"},
                            {"b", "q14"},
                            {"c", "q14"}
                        }
                    )
                },
                {
                    "q8",
                    new Question(
                        "Do you prefer other hobbies instead? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q15"},
                            {"b", "q16"}
                        }
                    )
                },
                {
                    "q9",
                    new Question(
                        "Do you play this sport professionally? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q17"},
                            {"b", "q18"}
                        }
                    )
                },
                {
                    "q10",
                    new Question(
                        "Who is your favorite athlete? \n A-) A football player \n B-) A basketball player \n C-) Others",
                        new Dictionary<string, string>
                        {
                            {"a", "q19"},
                            {"b", "q19"},
                            {"c", "q19"}
                        }
                    )
                },
                {
                    "q11",
                    new Question(
                        "Do you follow any sport news? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q20"},
                            {"b", "q20"}
                        }
                    )
                },
                {
                    "q12",
                    new Question(
                        "Which indoor sport is your favorite? \n A-) Chess \n B-) Table Tennis \n C-) Others",
                        new Dictionary<string, string>
                        {
                            {"a", "q21"},
                            {"b", "q22"},
                            {"c", "q23"}
                        }
                    )
                },
                {
                    "q13",
                    new Question(
                        "Which outdoor sport is your favorite? \n A-) Running \n B-) Cycling \n C-) Others",
                        new Dictionary<string, string>
                        {
                            {"a", "q24"},
                            {"b", "q25"},
                            {"c", "q26"}
                        }
                    )
                },
                {
                    "q14",
                    new Question(
                        "Do you need help starting this sport? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q27"},
                            {"b", "q28"}
                        }
                    )
                },
                {
                    "q15",
                    new Question(
                        "What is your favorite hobby? \n A-) Reading \n B-) Gaming \n C-) Others",
                        new Dictionary<string, string>
                        {
                            {"a", "q40"},
                            {"b", "q41"},
                            {"c", "q42"}
                        }
                    )
                },
                {
                    "q16",
                    new Question(
                        "Would you like to explore new hobbies? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q43"},
                            {"b", "q44"}
                        }
                    )
                },
                {
                    "q17",
                    new Question(
                        "Have you won any tournaments? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q45"},
                            {"b", "q46"}
                        }
                    )
                },
                {
                    "q18",
                    new Question(
                        "Would you consider going professional? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q47"},
                            {"b", "q48"}
                        }
                    )
                },
                {
                    "q19",
                    new Question(
                        "Do you aspire to be like them? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q49"},
                            {"b", "q50"}
                        }
                    )
                },
                {
                    "q20",
                    new Question(
                        "What is your favorite news source? \n A-) TV \n B-) Social Media \n C-) Websites",
                        new Dictionary<string, string>
                        {
                            {"a", "q51"},
                            {"b", "q52"},
                            {"c", "q53"}
                        }
                    )
                },
                {
                    "q21",
                    new Question(
                        "Chess: do you prefer playing on a board or online? \n A-) Board \n B-) Online",
                        new Dictionary<string, string>
                        {
                            {"a", "q29"},
                            {"b", "q30"}
                        }
                    )
                },
                {
                    "q22",
                    new Question(
                        "Table Tennis: do you prefer singles or doubles? \n A-) Singles \n B-) Doubles",
                        new Dictionary<string, string>
                        {
                            {"a", "q31"},
                            {"b", "q32"}
                        }
                    )
                },
                {
                    "q23",
                    new Question(
                        "Another indoor sport. Is it a team sport? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q33"},
                            {"b", "q34"}
                        }
                    )
                },
                {
                    "q24",
                    new Question(
                        "Running: do you prefer short or long distance? \n A-) Short \n B-) Long",
                        new Dictionary<string, string>
                        {
                            {"a", "q35"},
                            {"b", "q36"}
                        }
                    )
                },
                {
                    "q25",
                    new Question(
                        "Cycling: do you prefer mountain or road biking? \n A-) Mountain \n B-) Road",
                        new Dictionary<string, string>
                        {
                            {"a", "q37"},
                            {"b", "q38"}
                        }
                    )
                },
                {
                    "q26",
                    new Question(
                        "Which other outdoor sport do you like? \n A-) Hiking \n B-) Surfing \n C-) Others",
                        new Dictionary<string, string>
                        {
                            {"a", "q39"},
                            {"b", "q39"},
                            {"c", "q39"}
                        }
                    )
                },
                {
                    "q27",
                    new Question(
                        "What kind of help do you need? \n A-) Coaching \n B-) Equipment \n C-) Both",
                        new Dictionary<string, string>
                        {
                            {"a", "q54"},
                            {"b", "q55"},
                            {"c", "q56"}
                        }
                    )
                },
                {
                    "q28",
                    new Question(
                        "Great. Are you planning to start by yourself or with friends? \n A-) Myself \n B-) Friends",
                        new Dictionary<string, string>
                        {
                            {"a", "q57"},
                            {"b", "q58"}
                        }
                    )
                },
                {
                    "q29",
                    new Question(
                        "Board Chess: do you play in local clubs? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q59"},
                            {"b", "q60"}
                        }
                    )
                },
                {
                    "q30",
                    new Question(
                        "Online Chess: do you play in tournaments? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q61"},
                            {"b", "q62"}
                        }
                    )
                },
                {
                    "q31",
                    new Question(
                        "Singles: do you compete or just play for fun? \n A-) Compete \n B-) Fun",
                        new Dictionary<string, string>
                        {
                            {"a", "q63"},
                            {"b", "q64"}
                        }
                    )
                },
                {
                    "q32",
                    new Question(
                        "Doubles: do you have a regular partner? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q65"},
                            {"b", "q66"}
                        }
                    )
                },
                {
                    "q33",
                    new Question(
                        "Which indoor team sport do you prefer? \n A-) Volleyball \n B-) Indoor soccer \n C-) Others",
                        new Dictionary<string, string>
                        {
                            {"a", "q67"},
                            {"b", "q68"},
                            {"c", "q69"}
                        }
                    )
                },
                {
                    "q34",
                    new Question(
                        "Which indoor solo sport do you prefer? \n A-) Bowling \n B-) Badminton \n C-) Others",
                        new Dictionary<string, string>
                        {
                            {"a", "q70"},
                            {"b", "q71"},
                            {"c", "q72"}
                        }
                    )
                },
                {
                    "q35",
                    new Question(
                        "Short distance: do you focus on sprints? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q73"},
                            {"b", "q74"}
                        }
                    )
                },
                {
                    "q36",
                    new Question(
                        "Long distance: do you run marathons? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q75"},
                            {"b", "q76"}
                        }
                    )
                },
                {
                    "q37",
                    new Question(
                        "Mountain biking: do you participate in trail events? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q77"},
                            {"b", "q78"}
                        }
                    )
                },
                {
                    "q38",
                    new Question(
                        "Road biking: do you ride in groups or alone? \n A-) Groups \n B-) Alone",
                        new Dictionary<string, string>
                        {
                            {"a", "q79"},
                            {"b", "q80"}
                        }
                    )
                },
                {
                    "q39",
                    new Question(
                        "Nice choice! Is this a hobby or are you competitive? \n A-) Hobby \n B-) Competitive",
                        new Dictionary<string, string>
                        {
                            {"a", "q81"},
                            {"b", "q82"}
                        }
                    )
                },
                {
                    "q40",
                    new Question(
                        "You like Reading. Do you prefer fiction or non-fiction? \n A-) Fiction \n B-) Non-fiction",
                        new Dictionary<string, string>
                        {
                            {"a", "q83"},
                            {"b", "q84"}
                        }
                    )
                },
                {
                    "q41",
                    new Question(
                        "You like Gaming. Do you prefer PC or console? \n A-) PC \n B-) Console",
                        new Dictionary<string, string>
                        {
                            {"a", "q85"},
                            {"b", "q86"}
                        }
                    )
                },
                {
                    "q42",
                    new Question(
                        "You have other hobbies. Are they creative or physical? \n A-) Creative \n B-) Physical",
                        new Dictionary<string, string>
                        {
                            {"a", "q87"},
                            {"b", "q88"}
                        }
                    )
                },
                {
                    "q43",
                    new Question(
                        "You want new hobbies! Do you prefer indoor or outdoor? \n A-) Indoor \n B-) Outdoor",
                        new Dictionary<string, string>
                        {
                            {"a", "q89"},
                            {"b", "q90"}
                        }
                    )
                },
                {
                    "q44",
                    new Question(
                        "You don't want to explore new hobbies. Are you sure? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q91"},
                            {"b", "q92"}
                        }
                    )
                },
                {
                    "q45",
                    new Question(
                        "You have won tournaments. Was it local or international? \n A-) Local \n B-) International",
                        new Dictionary<string, string>
                        {
                            {"a", "q93"},
                            {"b", "q94"}
                        }
                    )
                },
                {
                    "q46",
                    new Question(
                        "You haven't won tournaments yet. Will you try soon? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q95"},
                            {"b", "q96"}
                        }
                    )
                },
                {
                    "q47",
                    new Question(
                        "Youis considering going pro! Are you training daily? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q97"},
                            {"b", "q98"}
                        }
                    )
                },
                {
                    "q48",
                    new Question(
                        "Not going pro. Are you playing just for fun? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q99"},
                            {"b", "q100"}
                        }
                    )
                },
                {
                    "q49",
                    new Question(
                        "You aspire to be like them. Are you taking lessons? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q101"},
                            {"b", "q102"}
                        }
                    )
                },
                {
                    "q50",
                    new Question(
                        "You do not aspire to be like them. Different goals, huh? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q103"},
                            {"b", "q104"}
                        }
                    )
                },
                {
                    "q51",
                    new Question(
                        "You watch TV news. Do you also follow online? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q105"},
                            {"b", "q106"}
                        }
                    )
                },
                {
                    "q52",
                    new Question(
                        "You use social media. Which platform mostly? \n A-) Twitter \n B-) Instagram \n C-) Others",
                        new Dictionary<string, string>
                        {
                            {"a", "q107"},
                            {"b", "q108"},
                            {"c", "q109"}
                        }
                    )
                },
                {
                    "q53",
                    new Question(
                        "You prefer websites. Do you read blogs or official outlets? \n A-) Blogs \n B-) Official",
                        new Dictionary<string, string>
                        {
                            {"a", "q110"},
                            {"b", "q111"}
                        }
                    )
                },
                {
                    "q54",
                    new Question(
                        "Coaching needed. Do you have a local coach? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q112"},
                            {"b", "q113"}
                        }
                    )
                },
                {
                    "q55",
                    new Question(
                        "Equipment needed. Are you buying soon? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q114"},
                            {"b", "q115"}
                        }
                    )
                },
                {
                    "q56",
                    new Question(
                        "Coaching + equipment needed. Got a budget? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q116"},
                            {"b", "q117"}
                        }
                    )
                },
                {
                    "q57",
                    new Question(
                        "Starting by yourself. Do you research techniques online? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q118"},
                            {"b", "q119"}
                        }
                    )
                },
                {
                    "q58",
                    new Question(
                        "Starting with friends. Do they have experience? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q120"},
                            {"b", "q121"}
                        }
                    )
                },
                {
                    "q59",
                    new Question(
                        "Local clubs: do you travel for tournaments? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q122"},
                            {"b", "q123"}
                        }
                    )
                },
                {
                    "q60",
                    new Question(
                        "No local clubs: would you join one someday? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q124"},
                            {"b", "q125"}
                        }
                    )
                },
                {
                    "q61",
                    new Question(
                        "You play in online tournaments. Do you win often? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q126"},
                            {"b", "q127"}
                        }
                    )
                },
                {
                    "q62",
                    new Question(
                        "No tournaments. Are you interested? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q128"},
                            {"b", "q129"}
                        }
                    )
                },
                {
                    "q63",
                    new Question(
                        "You compete in singles. Do you have a coach? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q130"},
                            {"b", "q131"}
                        }
                    )
                },
                {
                    "q64",
                    new Question(
                        "You play singles for fun. Do you play with friends? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q132"},
                            {"b", "q133"}
                        }
                    )
                },
                {
                    "q65",
                    new Question(
                        "You have a doubles partner. Do you train regularly? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q134"},
                            {"b", "q135"}
                        }
                    )
                },
                {
                    "q66",
                    new Question(
                        "No regular partner. Are you looking for one? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q136"},
                            {"b", "q137"}
                        }
                    )
                },
                {
                    "q67",
                    new Question(
                        "Volleyball: do you play on a team? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q138"},
                            {"b", "q139"}
                        }
                    )
                },
                {
                    "q68",
                    new Question(
                        "Indoor soccer: do you play in a league? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q140"},
                            {"b", "q141"}
                        }
                    )
                },
                {
                    "q69",
                    new Question(
                        "Other indoor team sport. Do you have enough players? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q142"},
                            {"b", "q143"}
                        }
                    )
                },
                {
                    "q70",
                    new Question(
                        "Bowling: do you compete or just recreational? \n A-) Compete \n B-) Recreational",
                        new Dictionary<string, string>
                        {
                            {"a", "q144"},
                            {"b", "q145"}
                        }
                    )
                },
                {
                    "q71",
                    new Question(
                        "Badminton: do you play doubles or singles? \n A-) Doubles \n B-) Singles",
                        new Dictionary<string, string>
                        {
                            {"a", "q146"},
                            {"b", "q147"}
                        }
                    )
                },
                {
                    "q72",
                    new Question(
                        "Other solo indoor sport. Do you do it weekly? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q148"},
                            {"b", "q149"}
                        }
                    )
                },
                {
                    "q73",
                    new Question(
                        "Sprints: do you compete in track meets? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q150"},
                            {"b", "q151"}
                        }
                    )
                },
                {
                    "q74",
                    new Question(
                        "No sprints. Do you do interval training? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q152"},
                            {"b", "q153"}
                        }
                    )
                },
                {
                    "q75",
                    new Question(
                        "Marathons: have you run more than one? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q154"},
                            {"b", "q155"}
                        }
                    )
                },
                {
                    "q76",
                    new Question(
                        "No marathons. Are you planning one? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q156"},
                            {"b", "q157"}
                        }
                    )
                },
                {
                    "q77",
                    new Question(
                        "Trail events: do you travel to different trails? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q158"},
                            {"b", "q159"}
                        }
                    )
                },
                {
                    "q78",
                    new Question(
                        "No trail events. Would you try them? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q160"},
                            {"b", "q161"}
                        }
                    )
                },
                {
                    "q79",
                    new Question(
                        "Group rides: do you compete in road races? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q162"},
                            {"b", "q163"}
                        }
                    )
                },
                {
                    "q80",
                    new Question(
                        "Alone: do you track your performance? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q164"},
                            {"b", "q165"}
                        }
                    )
                },
                {
                    "q81",
                    new Question(
                        "Hobby: do you do it weekly or monthly? \n A-) Weekly \n B-) Monthly",
                        new Dictionary<string, string>
                        {
                            {"a", "q166"},
                            {"b", "q167"}
                        }
                    )
                },
                {
                    "q82",
                    new Question(
                        "Competitive: do you train daily? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q168"},
                            {"b", "q169"}
                        }
                    )
                },
                {
                    "q83",
                    new Question(
                        "Fiction reading: do you have a favorite author? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q170"}
                        }
                    )
                },
                {
                    "q84",
                    new Question(
                        "Non-fiction reading: do you read biographies? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q171"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q85",
                    new Question(
                        "Gaming on PC: do you build your own PC? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q172"}
                        }
                    )
                },
                {
                    "q86",
                    new Question(
                        "Gaming on Console: do you have multiple consoles? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q173"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q87",
                    new Question(
                        "Creative hobbies: do you paint or draw? \n A-) Paint \n B-) Draw",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q174"}
                        }
                    )
                },
                {
                    "q88",
                    new Question(
                        "Physical hobbies: do you do them at home or gym? \n A-) Home \n B-) Gym",
                        new Dictionary<string, string>
                        {
                            {"a", "q175"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q89",
                    new Question(
                        "Indoor new hobbies. Are you learning online? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q176"},
                            {"b", "q176"}
                        }
                    )
                },
                {
                    "q90",
                    new Question(
                        "Outdoor new hobbies. Do you join clubs? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q177"},
                            {"b", "q177"}
                        }
                    )
                },
                {
                    "q91",
                    new Question(
                        "You’re certain. Are you open to changing your mind? \n A-) Maybe \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q178"}
                        }
                    )
                },
                {
                    "q92",
                    new Question(
                        "You might explore new hobbies after all. Great! \n A-) Ok \n B-) Ok",
                        new Dictionary<string, string>
                        {
                            {"a", "q179"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q93",
                    new Question(
                        "Local tournaments: do you plan to go international? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q170"}
                        }
                    )
                },
                {
                    "q94",
                    new Question(
                        "International tournaments: is traveling expensive? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q174"}
                        }
                    )
                },
                {
                    "q95",
                    new Question(
                        "You will try tournaments soon. Are you excited? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q96",
                    new Question(
                        "You won't try tournaments soon. Maybe in the future? \n A-) Possibly \n B-) Not sure",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q97",
                    new Question(
                        "Training daily for going pro. Seeing progress? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q98",
                    new Question(
                        "Not training daily. Looking for a coach? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q99",
                    new Question(
                        "Playing for fun: do you play in local leagues? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q100",
                    new Question(
                        "Not even for fun. Are you quitting sports entirely? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q101",
                    new Question(
                        "Taking lessons. Do you feel improvement? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q102",
                    new Question(
                        "No lessons. Are you self-taught? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q103",
                    new Question(
                        "Different goals. Are you focusing on something else? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q104",
                    new Question(
                        "No goals at all? Are you just relaxing? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q105",
                    new Question(
                        "Yes, you follow online as well. Is it social media or official sites? \n A-) Social \n B-) Official",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q106",
                    new Question(
                        "No online following. Do you only watch TV? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q107",
                    new Question(
                        "Mostly Twitter. Do you follow sports accounts? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q108",
                    new Question(
                        "Mostly Instagram. Do you check reels for sports? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q109",
                    new Question(
                        "Other social media. Are you active there? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q110",
                    new Question(
                        "Reading blogs. Do you comment or just read? \n A-) Comment \n B-) Read",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q111",
                    new Question(
                        "Official outlets. Do you follow big publications? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q112",
                    new Question(
                        "Local coach found. Are they experienced? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q113",
                    new Question(
                        "No local coach. Online coaching? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q114",
                    new Question(
                        "Buying equipment soon. Do you have the budget? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q115",
                    new Question(
                        "Not buying yet. Will you borrow from someone? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q116",
                    new Question(
                        "Yes, you have a budget for both. Are you ready now? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q117",
                    new Question(
                        "No budget. Do you plan to save up? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q118",
                    new Question(
                        "You research techniques online. Do you watch YouTube? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q119",
                    new Question(
                        "Not researching. Are you going in blind? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q120",
                    new Question(
                        "Friends have experience. Will they coach you? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q121",
                    new Question(
                        "Friends also novices. Are you learning together? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },

                {
                    "q122",
                    new Question(
                        "You travel for tournaments. Do you enjoy it? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q123",
                    new Question(
                        "You don't travel for tournaments. Too busy? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q124",
                    new Question(
                        "You'd join a club someday. Are you waiting for free time? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q125",
                    new Question(
                        "You wouldn't join a club. Prefer playing alone? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q126",
                    new Question(
                        "You often win in online tournaments. Are you pro? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q127",
                    new Question(
                        "You rarely win. Do you still enjoy it? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q128",
                    new Question(
                        "Interested in future tournaments. Are you training? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q129",
                    new Question(
                        "Not interested in tournaments. Do you watch them? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q130",
                    new Question(
                        "Coach for singles competition. Is it helpful? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q131",
                    new Question(
                        "No coach. Are you self taught? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q132",
                    new Question(
                        "You play singles for fun with friends. Is that enough? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q133",
                    new Question(
                        "You don't play with friends. Just alone? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q134",
                    new Question(
                        "Train regularly with your doubles partner. Is it competitive? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q135",
                    new Question(
                        "Not training regularly. Just casual? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q136",
                    new Question(
                        "Looking for a doubles partner. Any leads yet? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q137",
                    new Question(
                        "Not looking for a partner. Solo is fine? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q138",
                    new Question(
                        "Volleyball on a team. Practice frequency? \n A-) Often \n B-) Rarely",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q139",
                    new Question(
                        "Not on a team. Just for fun? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q140",
                    new Question(
                        "Indoor soccer in a league. Competitive level? \n A-) High \n B-) Low",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q141",
                    new Question(
                        "Not in a league. Just pick up games? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q142",
                    new Question(
                        "You have enough players. Official or casual? \n A-) Official \n B-) Casual",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q143",
                    new Question(
                        "Not enough players. Recruiting more? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q144",
                    new Question(
                        "Compete in bowling. Local tournaments? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q145",
                    new Question(
                        "Recreational bowling. Family nights? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q146",
                    new Question(
                        "Badminton doubles. Is your partner skilled? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q147",
                    new Question(
                        "Badminton singles. Compete in events? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q148",
                    new Question(
                        "You do it weekly. Are you in a local club? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q149",
                    new Question(
                        "Less often. Want to do it more? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q150",
                    new Question(
                        "Track meets. Pro or amateur? \n A-) Pro \n B-) Amateur",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q151",
                    new Question(
                        "No track meets. Sprint just for fitness? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q152",
                    new Question(
                        "Interval training. Getting results? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q153",
                    new Question(
                        "No interval training. Casual runs? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q154",
                    new Question(
                        "More than one marathon. You must love running! \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q155",
                    new Question(
                        "One marathon so far. Another one planned? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q156",
                    new Question(
                        "Planning your first marathon. Nervous? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q157",
                    new Question(
                        "Not planning a marathon. 5Ks or 10Ks maybe? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q158",
                    new Question(
                        "Different trails: scenic or tough? \n A-) Scenic \n B-) Tough",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q159",
                    new Question(
                        "Not traveling. Maybe local trails? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q160",
                    new Question(
                        "Youis open to trail events. Are you training? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q161",
                    new Question(
                        "No to trail events. Something else? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q162",
                    new Question(
                        "Road races: do you place well? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q163",
                    new Question(
                        "No competition. Just group rides for fun? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q164",
                    new Question(
                        "You track performance alone. Using apps? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q165",
                    new Question(
                        "No performance tracking. Just ride freely? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q166",
                    new Question(
                        "Weekly hobby. Share with others? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q172"},
                            {"b", "q173"}
                        }
                    )
                },
                {
                    "q167",
                    new Question(
                        "Monthly hobby. Want more often? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q174"},
                            {"b", "q175"}
                        }
                    )
                },
                {
                    "q168",
                    new Question(
                        "Yes, you train daily for competition. Serious? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q178"},
                            {"b", "q179"}
                        }
                    )
                },
                {
                    "q169",
                    new Question(
                        "No daily training. Casual competitor? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q170"},
                            {"b", "q171"}
                        }
                    )
                },
                {
                    "q170",
                    new Question(
                        "Thanks for sharing ❤️ Any final comment? \n A-) Yes \n B-) No ",
                        new Dictionary<string, string>
                        {
                            {"a", "q180"},
                            {"b", "q_end"}
                        }
                    )
                },
                {
                    "q171",
                    new Question(
                        "That is good. Do you have any comments to add? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q180"},
                            {"b", "q_end"}
                        }
                    )
                },
                {
                    "q172",
                    new Question(
                        "Great details. Do you have any comments to add ? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q180"},
                            {"b", "q_end"}
                        }
                    )
                },
                {
                    "q173",
                    new Question(
                        "Nice to know. Any final comment? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q180"},
                            {"b", "q_end"}
                        }
                    )
                },
                {
                    "q174",
                    new Question(
                        "Art or sports—both are perfect. Do you have any comments to add? \n A-) Yes \n B-) Yes",
                        new Dictionary<string, string>
                        {
                            {"a", "q180"},
                            {"b", "q_end"}
                        }
                    )
                },
                {
                    "q175",
                    new Question(
                        "Keep it up 💪🏼 Do you have any comments to add ? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q180"},
                            {"b", "q_end"}
                        }
                    )
                },
                {
                    "q176",
                    new Question(
                        "Learning new hobbies is fun. Do you have any comments to add?  \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q180"},
                            {"b", "q_end"}
                        }
                    )
                },
                {
                    "q177",
                    new Question(
                        "Clubs can be great. Do you have any comments to add? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q180"},
                            {"b", "q_end"}
                        }
                    )
                },
                {
                    "q178",
                    new Question(
                        "Changing your mind is good. Survey ends now. Any final comments? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q180"},
                            {"b", "q_end"}
                        }
                    )
                },
                {
                    "q179",
                    new Question(
                        "Changing your mind is good. Survey ends now. Any final comments? \n A-) Yes \n B-) No",
                        new Dictionary<string, string>
                        {
                            {"a", "q180"},
                            {"b", "q_end"}
                        }
                    )
                },
                {
                    "q180",
                    new Question(
                        "What is your comment? Type it!",
                        new Dictionary<string, string>()
                    )
                },
                {
                    "q_end",
                    new Question(
                        "Thanks! The survey is now complete.",
                        new Dictionary<string, string>()
                    )
                },
            };
        }

        private static string InterpretResults(Dictionary<string, string> responses)
        {
            bool likesSports = responses.ContainsKey("q1") && responses["q1"] == "a";
            bool watchSports = responses.ContainsKey("q5") && responses["q5"] == "a";

            //Basic branching example:
            string mainResult;
            if (likesSports && watchSports)
            {
                mainResult = "Youis clearly a sports enthusiast.";
            }
            else if (likesSports && !watchSports)
            {
                mainResult = "You like playing sports, but not watching them.";
            }
            else
            {
                mainResult = "Sports may not be your top interest, but thatis okay.";
            }

            //Add more custom logic:
            //Example: if they said 'a' on q2 => daily sports
            if (responses.ContainsKey("q2") && responses["q2"] == "a")
            {
                mainResult += "\nWow, you are very active—you play sports daily!";
            }

            //If user wants to play sports in future => q3 == "a"
            if (responses.ContainsKey("q3"))
            {
                if (responses["q3"] == "a")
                    mainResult += "\nYou are open to exploring sports in the future great potential ahead.";
                else
                    mainResult += "\nIt seems you have decided not to pursue sports further.";
            }

            //If user plays a sport professionally => q9 == "a"
            if (responses.ContainsKey("q9") && responses["q9"] == "a")
            {
                mainResult += "\nPlaying professionally. Thatis serious commitment.";
            }

            //If user’s favorite hobby is reading => q15 == "a"
            if (responses.ContainsKey("q15") && responses["q15"] == "a")
            {
                mainResult += "\nYou also enjoy reading fantastic way to relax and learn.";
            }
            //If user’s favorite hobby is gaming => q15 == "b"
            if (responses.ContainsKey("q15") && responses["q15"] == "b")
            {
                mainResult += "\nYou also love gaming there is a whole world of fun waiting.";
            }

            //If user is interested in new hobbies => q16 == "a"
            if (responses.ContainsKey("q16"))
            {
                if (responses["q16"] == "a")
                    mainResult += "\nYou are adventurous with hobbies always exploring something new.";
                else
                    mainResult += "\nYou seem content with your current hobbies.";
            }


            return mainResult;
        }
    }
}
