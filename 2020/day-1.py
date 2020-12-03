# Day-1: expense report


# Get input from file and add it to array
def getReportList(file):
    with open(file) as f:
        reportList = f.readlines()
    #strip '\n' and convert to int
    reportList = [int(x.strip()) for x in reportList]

    return reportList 

# Day-1_Puzzle-1 Find the two entries that sum to 2020 and then multiply those two numbers together.
def multiplySumOfTwoNumbersOf2020(reportList):
    result = 2020
    list = []
    for i in range (len(reportList)):
        current = reportList[i]
        for j in range (i+1, len(reportList)):
            sum = current + reportList[j]
            if sum == result:
                print('Sum: ' + str(sum) + ' = ' + str(current) + ' + ' + str(reportList[j]))
                print('Product: ' + str(current * reportList[j]) + ' = ' + str(current) + ' * ' + str(reportList[j]))
                return current * reportList[j]

# Day-1_Puzzle-2 Find the three entries that sum to 2020 and then multiply those two numbers together.
def multiplySumOfThreeNumbersOf2020(reportList):
    result = 2020
    for i in range (len(reportList)):
        current = reportList[i]
        for j in range (i+1, len(reportList)):
            for k in range (j+1, len(reportList)):
                sum = current + reportList[j] + reportList[k]
                if sum == result:
                    print('Sum: ' + str(sum) + ' = ' + str(current) + ' + ' + str(reportList[j]) + ' + ' + str(reportList[k]))
                    print('Product: ' + str(current * reportList[j] * reportList[k]) + ' = ' + str(current) + ' * ' + str(reportList[j]) + ' * ' + str(reportList[k]))
                    return (current * reportList[j] * reportList[k])


print()
print(multiplySumOfTwoNumbersOf2020(getReportList('ExpenseReport.txt')))
print()
print(multiplySumOfThreeNumbersOf2020(getReportList('ExpenseReport.txt')))