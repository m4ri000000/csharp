def calculate_savings_months(income, rent, goal, other_expenses=0):
    monthly_savings = income - rent - other_expenses

    if monthly_savings <= 0:
        return "It's not possible to save with the current income and expenses."

    months = 0
    total_savings = 0

    while total_savings < goal:
        total_savings += monthly_savings
        months += 1

        if months > 12:
            return f"You won't reach your goal in 12 months. Total savings after a year: R${total_savings:.2f}"

    return f"It will take {months} months to save up to R${goal:.2f}."

def calculate_rent_percentage(income, rent):
    if income <= 0:
        return "Income must be greater than 0 to calculate percentage."

    percentage = (rent / income) * 100
    return f"You spend {percentage:.2f}% of your income on rent."

monthly_income = 2500  
monthly_rent = 0    
savings_goal = 20000   
additional_expenses = 330  

result = calculate_savings_months(monthly_income, monthly_rent, savings_goal, additional_expenses)
print(result)

rent_percentage = calculate_rent_percentage(monthly_income, monthly_rent)
print(rent_percentage)
