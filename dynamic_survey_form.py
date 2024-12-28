def dynamic_survey():
    #Define a Question class to store the question text and options
    survey = {
        "q1": {
            "question": "Do you like sports? \n A-) Yes \n B-) No",
            "options": {"a": "q2", "b": "q3"}
        },
        "q2": {
            "question": "How often do you play sports? \n A-) Daily \n B-) Weekly \n C-) Rarely",
            "options": {"a": "q4", "b": "q5", "c": "q6"}
        },
        "q3": {
            "question": "Would you like to play sports in the future? \n A-) Yes \n B-) No",
            "options": {"a": "q7", "b": "q8"}
        },
        "q4": {
            "question": "Which sport do you like the most? \n A-) Football \n B-) Basketball \n C-) Others",
            "options": {"a": "q9", "b": "q9", "c": "q9"}
        },
        "q5": {
            "question": "Do you watch sports? \n A-) Yes \n B-) No",
            "options": {"a": "q10", "b": "q11"}
        },
        "q6": {
            "question": "Do you prefer indoor or outdoor sports? \n A-) Indoor \n B-) Outdoor",
            "options": {"a": "q12", "b": "q13"}
        },
        "q7": {
            "question": "Which sport would you like to try? \n A-) Swimming \n B-) Tennis \n C-) Others",
            "options": {"a": "q14", "b": "q14", "c": "q14"}
        },
        "q8": {
            "question": "Do you prefer other hobbies instead? \n A-) Yes \n B-) No",
            "options": {"a": "q15", "b": "q16"}
        },
        "q9": {
            "question": "Do you play this sport professionally? \n A-) Yes \n B-) No",
            "options": {"a": "q17", "b": "q18"}
        },
        "q10": {
            "question": "Who is your favorite athlete? \n A-) A football player \n B-) A basketball player \n C-) Others",
            "options": {"a": "q19", "b": "q19", "c": "q19"}
        },
        "q11": {
            "question": "Do you follow any sport news? \n A-) Yes \n B-) No",
            "options": {"a": "q20", "b": "q20"}
        },
        "q12": {
            "question": "Which indoor sport is your favorite? \n A-) Chess \n B-) Table Tennis \n C-) Others",
            "options": {"a": "q21", "b": "q22", "c": "q23"}
        },
        "q13": {
            "question": "Which outdoor sport is your favorite? \n A-) Running \n B-) Cycling \n C-) Others",
            "options": {"a": "q24", "b": "q25", "c": "q26"}
        },
        "q14": {
            "question": "Do you need help starting this sport? \n A-) Yes \n B-) No",
            "options": {"a": "q27", "b": "q28"}
        },
        "q15": {
            "question": "What is your favorite hobby? \n A-) Reading \n B-) Gaming \n C-) Others",
            "options": {"a": "q40", "b": "q41", "c": "q42"}
        },
        "q16": {
            "question": "Would you like to explore new hobbies? \n A-) Yes \n B-) No",
            "options": {"a": "q43", "b": "q44"}
        },
        "q17": {
            "question": "Have you won any tournaments? \n A-) Yes \n B-) No",
            "options": {"a": "q45", "b": "q46"}
        },
        "q18": {
            "question": "Would you consider going professional? \n A-) Yes \n B-) No",
            "options": {"a": "q47", "b": "q48"}
        },
        "q19": {
            "question": "Do you aspire to be like them? \n A-) Yes \n B-) No",
            "options": {"a": "q49", "b": "q50"}
        },
        "q20": {
            "question": "What is your favorite news source? \n A-) TV \n B-) Social Media \n C-) Websites",
            "options": {"a": "q51", "b": "q52", "c": "q53"}
        },
        "q21": {
            "question": "Chess: do you prefer playing on a board or online? \n A-) Board \n B-) Online",
            "options": {"a": "q29", "b": "q30"}
        },
        "q22": {
            "question": "Table Tennis: do you prefer singles or doubles? \n A-) Singles \n B-) Doubles",
            "options": {"a": "q31", "b": "q32"}
        },
        "q23": {
            "question": "Another indoor sport. Is it a team sport? \n A-) Yes \n B-) No",
            "options": {"a": "q33", "b": "q34"}
        },
        "q24": {
            "question": "Running: do you prefer short or long distance? \n A-) Short \n B-) Long",
            "options": {"a": "q35", "b": "q36"}
        },
        "q25": {
            "question": "Cycling: do you prefer mountain or road biking? \n A-) Mountain \n B-) Road",
            "options": {"a": "q37", "b": "q38"}
        },
        "q26": {
            "question": "Which other outdoor sport do you like? \n A-) Hiking \n B-) Surfing \n C-) Others",
            "options": {"a": "q39", "b": "q39", "c": "q39"}
        },
        "q27": {
            "question": "What kind of help do you need? \n A-) Coaching \n B-) Equipment \n C-) Both",
            "options": {"a": "q54", "b": "q55", "c": "q56"}
        },
        "q28": {
            "question": "Great! Are you planning to start by yourself or with friends? \n A-) Myself \n B-) Friends",
            "options": {"a": "q57", "b": "q58"}
        },
        "q29": {
            "question": "Board Chess: do you play in local clubs? \n A-) Yes \n B-) No",
            "options": {"a": "q59", "b": "q60"}
        },
        "q30": {
            "question": "Online Chess: do you play in tournaments? \n A-) Yes \n B-) No",
            "options": {"a": "q61", "b": "q62"}
        },
        "q31": {
            "question": "Singles: do you compete or just play for fun? \n A-) Compete \n B-) Fun",
            "options": {"a": "q63", "b": "q64"}
        },
        "q32": {
            "question": "Doubles: do you have a regular partner? \n A-) Yes \n B-) No",
            "options": {"a": "q65", "b": "q66"}
        },
        "q33": {
            "question": "Which indoor team sport do you prefer? \n A-) Volleyball \n B-) Indoor soccer \n C-) Others",
            "options": {"a": "q67", "b": "q68", "c": "q69"}
        },
        "q34": {
            "question": "Which indoor solo sport do you prefer? \n A-) Bowling \n B-) Badminton \n C-) Others",
            "options": {"a": "q70", "b": "q71", "c": "q72"}
        },
        "q35": {
            "question": "Short distance: do you focus on sprints? \n A-) Yes \n B-) No",
            "options": {"a": "q73", "b": "q74"}
        },
        "q36": {
            "question": "Long distance: do you run marathons? \n A-) Yes \n B-) No",
            "options": {"a": "q75", "b": "q76"}
        },
        "q37": {
            "question": "Mountain biking: do you participate in trail events? \n A-) Yes \n B-) No",
            "options": {"a": "q77", "b": "q78"}
        },
        "q38": {
            "question": "Road biking: do you ride in groups or alone? \n A-) Groups \n B-) Alone",
            "options": {"a": "q79", "b": "q80"}
        },
        "q39": {
            "question": "Nice choice! Is this a hobby or are you competitive? \n A-) Hobby \n B-) Competitive",
            "options": {"a": "q81", "b": "q82"}
        },
        "q40": {
            "question": "You like Reading. Do you prefer fiction or non-fiction? \n A-) Fiction \n B-) Non-fiction",
            "options": {"a": "q83", "b": "q84"}
        },
        "q41": {
            "question": "You like Gaming. Do you prefer PC or console? \n A-) PC \n B-) Console",
            "options": {"a": "q85", "b": "q86"}
        },
        "q42": {
            "question": "You have other hobbies. Are they creative or physical? \n A-) Creative \n B-) Physical",
            "options": {"a": "q87", "b": "q88"}
        },
        "q43": {
            "question": "You want new hobbies! Do you prefer indoor or outdoor? \n A-) Indoor \n B-) Outdoor",
            "options": {"a": "q89", "b": "q90"}
        },
        "q44": {
            "question": "You don't want to explore new hobbies. Are you sure? \n A-) Yes \n B-) No",
            "options": {"a": "q91", "b": "q92"}
        },
        "q45": {
            "question": "You have won tournaments! Was it local or international? \n A-) Local \n B-) International",
            "options": {"a": "q93", "b": "q94"}
        },
        "q46": {
            "question": "You haven't won tournaments yet. Will you try soon? \n A-) Yes \n B-) No",
            "options": {"a": "q95", "b": "q96"}
        },
        "q47": {
            "question": "You are considering going pro! Are you training daily? \n A-) Yes \n B-) No",
            "options": {"a": "q97", "b": "q98"}
        },
        "q48": {
            "question": "Not going pro. Are you playing just for fun? \n A-) Yes \n B-) No",
            "options": {"a": "q99", "b": "q100"}
        },
        "q49": {
            "question": "You aspire to be like them. Are you taking lessons? \n A-) Yes \n B-) No",
            "options": {"a": "q101", "b": "q102"}
        },
        "q50": {
            "question": "You do not aspire to be like them. Different goals, huh? \n A-) Yes \n B-) No",
            "options": {"a": "q103", "b": "q104"}
        },
        "q51": {
            "question": "You watch TV news. Do you also follow online? \n A-) Yes \n B-) No",
            "options": {"a": "q105", "b": "q106"}
        },
        "q52": {
            "question": "You use social media. Which platform mostly? \n A-) Twitter \n B-) Instagram \n C-) Others",
            "options": {"a": "q107", "b": "q108", "c": "q109"}
        },
        "q53": {
            "question": "You prefer websites. Do you read blogs or official outlets? \n A-) Blogs \n B-) Official",
            "options": {"a": "q110", "b": "q111"}
        },
        "q54": {
            "question": "Coaching needed. Do you have a local coach? \n A-) Yes \n B-) No",
            "options": {"a": "q112", "b": "q113"}
        },
        "q55": {
            "question": "Equipment needed. Are you buying soon? \n A-) Yes \n B-) No",
            "options": {"a": "q114", "b": "q115"}
        },
        "q56": {
            "question": "Coaching + equipment needed. Got a budget? \n A-) Yes \n B-) No",
            "options": {"a": "q116", "b": "q117"}
        },
        "q57": {
            "question": "Starting by yourself. Do you research techniques online? \n A-) Yes \n B-) No",
            "options": {"a": "q118", "b": "q119"}
        },
        "q58": {
            "question": "Starting with friends. Do they have experience? \n A-) Yes \n B-) No",
            "options": {"a": "q120", "b": "q121"}
        },
        "q59": {
            "question": "Local clubs: do you travel for tournaments? \n A-) Yes \n B-) No",
            "options": {"a": "q122", "b": "q123"}
        },
        "q60": {
            "question": "No local clubs: would you join one someday? \n A-) Yes \n B-) No",
            "options": {"a": "q124", "b": "q125"}
        },
        "q61": {
            "question": "You play in online tournaments. Do you win often? \n A-) Yes \n B-) No",
            "options": {"a": "q126", "b": "q127"}
        },
        "q62": {
            "question": "No tournaments. Are you interested? \n A-) Yes \n B-) No",
            "options": {"a": "q128", "b": "q129"}
        },
        "q63": {
            "question": "You compete in singles. Do you have a coach? \n A-) Yes \n B-) No",
            "options": {"a": "q130", "b": "q131"}
        },
        "q64": {
            "question": "You play singles for fun. Do you play with friends? \n A-) Yes \n B-) No",
            "options": {"a": "q132", "b": "q133"}
        },
        "q65": {
            "question": "You have a doubles partner. Do you train regularly? \n A-) Yes \n B-) No",
            "options": {"a": "q134", "b": "q135"}
        },
        "q66": {
            "question": "No regular partner. Are you looking for one? \n A-) Yes \n B-) No",
            "options": {"a": "q136", "b": "q137"}
        },
        "q67": {
            "question": "Volleyball: do you play on a team? \n A-) Yes \n B-) No",
            "options": {"a": "q138", "b": "q139"}
        },
        "q68": {
            "question": "Indoor soccer: do you play in a league? \n A-) Yes \n B-) No",
            "options": {"a": "q140", "b": "q141"}
        },
        "q69": {
            "question": "Other indoor team sport. Do you have enough players? \n A-) Yes \n B-) No",
            "options": {"a": "q142", "b": "q143"}
        },
        "q70": {
            "question": "Bowling: do you compete or just recreational? \n A-) Compete \n B-) Recreational",
            "options": {"a": "q144", "b": "q145"}
        },
        "q71": {
            "question": "Badminton: do you play doubles or singles? \n A-) Doubles \n B-) Singles",
            "options": {"a": "q146", "b": "q147"}
        },
        "q72": {
            "question": "Other solo indoor sport. Do you do it weekly? \n A-) Yes \n B-) No",
            "options": {"a": "q148", "b": "q149"}
        },
        "q73": {
            "question": "Sprints: do you compete in track meets? \n A-) Yes \n B-) No",
            "options": {"a": "q150", "b": "q151"}
        },
        "q74": {
            "question": "No sprints. Do you do interval training? \n A-) Yes \n B-) No",
            "options": {"a": "q152", "b": "q153"}
        },
        "q75": {
            "question": "Marathons: have you run more than one? \n A-) Yes \n B-) No",
            "options": {"a": "q154", "b": "q155"}
        },
        "q76": {
            "question": "No marathons. Are you planning one? \n A-) Yes \n B-) No",
            "options": {"a": "q156", "b": "q157"}
        },
        "q77": {
            "question": "Trail events: do you travel to different trails? \n A-) Yes \n B-) No",
            "options": {"a": "q158", "b": "q159"}
        },
        "q78": {
            "question": "No trail events. Would you try them? \n A-) Yes \n B-) No",
            "options": {"a": "q160", "b": "q161"}
        },
        "q79": {
            "question": "Group rides: do you compete in road races? \n A-) Yes \n B-) No",
            "options": {"a": "q162", "b": "q163"}
        },
        "q80": {
            "question": "Alone: do you track your performance? \n A-) Yes \n B-) No",
            "options": {"a": "q164", "b": "q165"}
        },
        "q81": {
            "question": "Hobby: do you do it weekly or monthly? \n A-) Weekly \n B-) Monthly",
            "options": {"a": "q166", "b": "q167"}
        },
        "q82": {
            "question": "Competitive: do you train daily? \n A-) Yes \n B-) No",
            "options": {"a": "q168", "b": "q169"}
        },
        "q83": {
            "question": "Fiction reading: do you have a favorite author? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q170"}
        },
        "q84": {
            "question": "Non-fiction reading: do you read biographies? \n A-) Yes \n B-) No",
            "options": {"a": "q171", "b": "q171"}
        },
        "q85": {
            "question": "Gaming on PC: do you build your own PC? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q172"}
        },
        "q86": {
            "question": "Gaming on Console: do you have multiple consoles? \n A-) Yes \n B-) No",
            "options": {"a": "q173", "b": "q173"}
        },
        "q87": {
            "question": "Creative hobbies: do you paint or draw? \n A-) Paint \n B-) Draw",
            "options": {"a": "q174", "b": "q174"}
        },
        "q88": {
            "question": "Physical hobbies: do you do them at home or gym? \n A-) Home \n B-) Gym",
            "options": {"a": "q175", "b": "q175"}
        },
        "q89": {
            "question": "Indoor new hobbies. Are you learning online? \n A-) Yes \n B-) No",
            "options": {"a": "q176", "b": "q176"}
        },
        "q90": {
            "question": "Outdoor new hobbies. Do you join clubs? \n A-) Yes \n B-) No",
            "options": {"a": "q177", "b": "q177"}
        },
        "q91": {
            "question": "You re certain. Are you open to changing your mind? \n A-) Maybe \n B-) No",
            "options": {"a": "q178", "b": "q178"}
        },
        "q92": {
            "question": "You might explore new hobbies after all. Great! \n A-) Ok \n B-) Ok",
            "options": {"a": "q179", "b": "q179"}
        },
        "q93": {
            "question": "Local tournaments: do you plan to go international? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q170"}
        },
        "q94": {
            "question": "International tournaments: is traveling expensive? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q174"}
        },
        "q95": {
            "question": "You will try tournaments soon. Are you excited? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q96": {
            "question": "You won't try tournaments soon. Maybe in the future? \n A-) Possibly \n B-) Not sure",
            "options": {"a": "q172", "b": "q173"}
        },
        "q97": {
            "question": "Training daily for going pro. Seeing progress? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q98": {
            "question": "Not training daily. Looking for a coach? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q99": {
            "question": "Playing for fun: do you play in local leagues? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q100": {
            "question": "Not even for fun. Are you quitting sports entirely? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q101": {
            "question": "Taking lessons. Do you feel improvement? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q102": {
            "question": "No lessons. Are you self-taught? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q103": {
            "question": "Different goals. Are you focusing on something else? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q104": {
            "question": "No goals at all? Are you just relaxing? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q105": {
            "question": "Yes, you follow online as well. Is it social media or official sites? \n A-) Social \n B-) Official",
            "options": {"a": "q170", "b": "q171"}
        },
        "q106": {
            "question": "No online following. Do you only watch TV? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q107": {
            "question": "Mostly Twitter. Do you follow sports accounts? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q108": {
            "question": "Mostly Instagram. Do you check reels for sports? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q109": {
            "question": "Other social media. Are you active there? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q110": {
            "question": "Reading blogs. Do you comment or just read? \n A-) Comment \n B-) Read",
            "options": {"a": "q172", "b": "q173"}
        },
        "q111": {
            "question": "Official outlets. Do you follow big publications? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q112": {
            "question": "Local coach found. Are they experienced? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q113": {
            "question": "No local coach. Online coaching? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q114": {
            "question": "Buying equipment soon. Do you have the budget? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q115": {
            "question": "Not buying yet. Will you borrow from someone? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q116": {
            "question": "Yes, you have a budget for both. Are you ready now? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q117": {
            "question": "No budget. Do you plan to save up? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q118": {
            "question": "You research techniques online. Do you watch YouTube? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q119": {
            "question": "Not researching. Are you going in blind? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q120": {
            "question": "Friends have experience. Will they coach you? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q121": {
            "question": "Friends also novices. Are you learning together? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q122": {
            "question": "You travel for tournaments. Do you enjoy it? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q123": {
            "question": "You don't travel for tournaments. Too busy? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q124": {
            "question": "You'd join a club someday. Are you waiting for free time? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q125": {
            "question": "You wouldn't join a club. Prefer playing alone? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q126": {
            "question": "You often win in online tournaments. Are you pro? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q127": {
            "question": "You rarely win. Do you still enjoy it? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q128": {
            "question": "Interested in future tournaments. Are you training? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q129": {
            "question": "Not interested in tournaments. Do you watch them? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q130": {
            "question": "Coach for singles competition. Is it helpful? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q131": {
            "question": "No coach. Are you self taught? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q132": {
            "question": "You play singles for fun with friends. Is that enough? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q133": {
            "question": "You don't play with friends. Just alone? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q134": {
            "question": "Train regularly with your doubles partner. Is it competitive? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q135": {
            "question": "Not training regularly. Just casual? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q136": {
            "question": "Looking for a doubles partner. Any leads yet? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q137": {
            "question": "Not looking for a partner. Solo is fine? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q138": {
            "question": "Volleyball on a team. Practice frequency? \n A-) Often \n B-) Rarely",
            "options": {"a": "q172", "b": "q173"}
        },
        "q139": {
            "question": "Not on a team. Just for fun? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q140": {
            "question": "Indoor soccer in a league. Competitive level? \n A-) High \n B-) Low",
            "options": {"a": "q178", "b": "q179"}
        },
        "q141": {
            "question": "Not in a league. Just pick-up games? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q142": {
            "question": "You have enough players. Official or casual? \n A-) Official \n B-) Casual",
            "options": {"a": "q172", "b": "q173"}
        },
        "q143": {
            "question": "Not enough players. Recruiting more? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q144": {
            "question": "Compete in bowling. Local tournaments? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q145": {
            "question": "Recreational bowling. Family nights? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q146": {
            "question": "Badminton doubles. Is your partner skilled? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q147": {
            "question": "Badminton singles. Compete in events? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q148": {
            "question": "You do it weekly. Are you in a local club? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q149": {
            "question": "Less often. Want to do it more? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q150": {
            "question": "Track meets. Pro or amateur? \n A-) Pro \n B-) Amateur",
            "options": {"a": "q172", "b": "q173"}
        },
        "q151": {
            "question": "No track meets. Sprint just for fitness? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q152": {
            "question": "Interval training. Getting results? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q153": {
            "question": "No interval training. Casual runs? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q154": {
            "question": "More than one marathon. You must love running! \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q155": {
            "question": "One marathon so far. Another one planned? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q156": {
            "question": "Planning your first marathon. Nervous? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q157": {
            "question": "Not planning a marathon. 5Ks or 10Ks maybe? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q158": {
            "question": "Different trails: scenic or tough? \n A-) Scenic \n B-) Tough",
            "options": {"a": "q172", "b": "q173"}
        },
        "q159": {
            "question": "Not traveling. Maybe local trails? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q160": {
            "question": "You are open to trail events. Are you training? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q161": {
            "question": "No to trail events. Something else? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q162": {
            "question": "Road races: do you place well? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q163": {
            "question": "No competition. Just group rides for fun? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q164": {
            "question": "You track performance alone. Using apps? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q165": {
            "question": "No performance tracking. Just ride freely? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q166": {
            "question": "Weekly hobby. Share with others? \n A-) Yes \n B-) No",
            "options": {"a": "q172", "b": "q173"}
        },
        "q167": {
            "question": "Monthly hobby. Want more often? \n A-) Yes \n B-) No",
            "options": {"a": "q174", "b": "q175"}
        },
        "q168": {
            "question": "Yes, you train daily for competition. Serious? \n A-) Yes \n B-) No",
            "options": {"a": "q178", "b": "q179"}
        },
        "q169": {
            "question": "No daily training. Casual competitor? \n A-) Yes \n B-) No",
            "options": {"a": "q170", "b": "q171"}
        },
        "q170": {
            "question": "Thanks for sharing ❤️ Any final comment? \n A-) Yes \n B-) No ",
            "options": {"a": "q180", "b": "q_end"}
        },
        "q171": {
            "question": "That is good. Do you have any comments to add? \n A-) Yes \n B-) No",
            "options": {"a": "q_180", "b": "q_end"}
        },
        "q172": {
            "question": "Great details. Do you have any comments to add ? \n A-) Yes \n B-) No",
            "options": {"a": "q_180", "b": "q_end"}
        },
        "q173": {
            "question": "Nice to know. Any final comment? \n A-) Yes \n B-) No",
            "options": {"a": "q180", "b": "q_end"}
        },
        "q174": {
            "question": "Art or sports—both are perfect. Do you have any comments to add? \n A-) Yes \n B-) No",
            "options": {"a": "q_180", "b": "q_end"}
        },
        "q175": {
            "question": "Keep it up 💪🏼 Do you have any comments to add ? \n A-) Yes \n B-) No",
            "options": {"a": "180", "b": "q_end"}
        },
        "q176": {
            "question": "Learning new hobbies is fun. Do you have any comments to add? \n A-) Yes \n B-) No",
            "options": {"a": "q_180", "b": "q_end"}
        },
        "q177": {
            "question": "Clubs can be great. Do you have any comments to add? \n A-) Yes \n B-) No",
            "options": {"a": "q_180", "b": "q_end"}
        },
        "q178": {
            "question": "Changing your mind is good. Survey ends now. Any final comments? \n A-) Yes \n B-) No",
            "options": {"a": "q180", "b": "q_end"}
        },
        "q179": {
            "question": "Wonderful! Do you have any comments to add? \n A-) Yes \n B-) No",
            "options": {"a": "q_180", "b": "q_end"}
        },
        "q180": {
            "question": "What is your comment? Type it!",
            "options": {}
        },
        "q_end": {
            "question": "Thanks! The survey is now complete.",
            "options": {}
        },
    }

    current_question = "q1"
    responses = {}

    while current_question:
        question_data = survey[current_question]
        print(question_data["question"])

        #Stop if we have reached the final statement with no further options
        if question_data["question"] == "Thanks! The survey is now complete.":
            break

        user_input = input("Your answer: ").lower()

        #If this question has no options left we store the answer and end
        if not question_data["options"]:
            responses[current_question] = user_input
            break

        if user_input in question_data["options"]:
            responses[current_question] = user_input
            current_question = question_data["options"][user_input]
        else:
            print("Invalid choice. Please try again.")

    print("\nSurvey completed. Your responses:")
    for question, answer in responses.items():
        print(f"{survey[question]['question']} - {answer}")

    #At the end we interpret the responses and display a final summary:
    final_message = interpret_results(responses)
    print("\nRESULT: ")
    print(final_message)


def interpret_results(responses):
    likes_sports = (responses.get("q1") == "a")
    watch_sports = (responses.get("q5") == "a")

    if likes_sports and watch_sports:
        main_result = "You are clearly a sports enthusiast."
    elif likes_sports and not watch_sports:
        main_result = "You like playing sports but not watching them."
    else:
        main_result = "Sports may not be your top interest and that is okay."

    #If the user likes sports and plays daily
    if likes_sports and responses.get("q2") == "a":
        main_result += "\n You are very active you play sports daily."

    #If the user might want to play sports in the future
    if responses.get("q3") == "a":
        main_result += "\nYou are open to exploring sports in the future—great potential ahead."
    elif responses.get("q3") == "b":
        main_result += "\nIt seems you have decided not to pursue sports further."

    #If the user plays sports professionally
    if responses.get("q9") == "a":
        main_result += "\nPlaying professionally. That is a serious commitment."

    #If the user’s favorite hobby is reading
    if responses.get("q15") == "a":
        main_result += "\nYou also enjoy reading fantastic way to relax and learn."

    #If the user’s favorite hobby is gaming
    if responses.get("q15") == "b":
        main_result += "\nYou also love gaming—there is a whole world of fun waiting."

    #If the user is interested in new hobbies
    if responses.get("q16") == "a":
        main_result += "\nYou are adventurous with hobbies always exploring something new."
    elif responses.get("q16") == "b":
        main_result += "\nYou seem content with your current hobbies."

    return main_result


#Uncomment the line below if you want to run the survey directly here
dynamic_survey()