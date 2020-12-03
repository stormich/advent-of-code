# Day-2: Password Philosophy
# Each line gives the password policy and then the password. 
# Get input from file and add it to array
def getLines(filepath):
    with open(filepath) as fp:
        lines = fp.readlines()
        
        return [x.strip() for x in lines]

# Day-2-Part-1
# The password policy indicates the lowest and highest number of times a given letter must appear for the password to be valid. 
# For example, 1-3 a means that the password must contain a at least 1 time and at most 3 times.
# How many passwords are valid according to their policies?
   
def validPasswordsPartOne(lines):
    totalCount = 0
    for i in range(0, len(lines)):
        count = 0
        str = lines[i].split(" ")
        string = str[2] # string password

        limit = str[0].split("-") #split 1-3
        min = int(limit[0]) #min=1
        max = int(limit[1]) #max=3

        char = str[1][-2] # 'a:' [-2] = a

        for j in range(0, len(string)):
            if string[j] == char:
                count +=1

        if count >= min and count <=max:
            totalCount +=1

    print('Part 1, Number of valid passwords: ', totalCount)

print()
validPasswordsPartOne(getLines('day-2-input.txt'))
print()

# Day-2-Part-2
# Each policy actually describes two positions in the password, where 1 means the first character, 2 means the second character, and so on. 
# (Be careful; Toboggan Corporate Policies have no concept of "index zero"!) Exactly one of these positions must contain the given letter. 
# Other occurrences of the letter are irrelevant for the purposes of policy enforcement.

#1-3 a: abcde is valid: position 1 contains a and position 3 does not.
#1-3 b: cdefg is invalid: neither position 1 nor position 3 contains b.
#2-9 c: ccccccccc is invalid: both position 2 and position 9 contain c.

def validPasswordsPartTwo(lines):
    totalCount = 0
    for i in range(0, len(lines)):
        match = False

        str = lines[i].split(" ")
        string = str[2] # string password 'sadsassaaaa'
        limit = str[0].split("-") #split 1-3
        pos1 = int(limit[0]) #pos1=1
        pos2 = int(limit[1]) #pos2=3
        char = str[1][-2] # 'a:' [-2] = a

        if pos1 <= len(string):
            if string[pos1-1] == char:
                totalCount +=1
                match = True
        if pos2 <= len(string):
            if string[pos2-1] == char:
                if(match):
                    totalCount -=1 # only one position can match
                else:
                    totalCount +=1

    print('Part 2, Number of valid passwords: ', totalCount)

validPasswordsPartTwo(getLines('day-2-input.txt'))
