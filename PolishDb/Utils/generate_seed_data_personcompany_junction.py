import random
import json

# Load the previously generated seed data
with open('seed-persons-data.json') as json_file:
    persons = json.load(json_file)

# Generate data for CompanyPerson junction table
company_persons = []

for person in persons:
    company_count = random.randint(1, 5)  # Random number of companies per person

    for _ in range(company_count):
        company_id = random.randint(1, 50)  # Assuming you have 50 companies
        employment_type_id = random.randint(1, 2)  # Assuming 2 employment types

        company_person = {
            "Id": len(company_persons) + 1,  # Autoincremented id
            "CompanyId": company_id,
            "PersonId": person["Id"],
            "EmploymentTypeId": employment_type_id
        }

        company_persons.append(company_person)

# Save the data to a JSON file
with open('company-persons-data.json', 'w') as json_file:
    json.dump(company_persons, json_file, indent=4)
