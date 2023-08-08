import random
import json
from faker import Faker

fake = Faker('pl_PL')  # Initialize a Polish data generator

records = []

for _ in range(5000):
    gender = random.choice(['Female', 'Male'])
    is_female = gender == 'Female'
    is_male = gender == 'Male'
    spouse_gender = 'Male' if is_female else 'Female'
    
    has_wife = is_female and random.choice([True, False])
    has_husband = is_male and random.choice([True, False])
    
    has_mother = random.choice([True, False])
    has_father = random.choice([True, False])
    
    record = {
        "Id": len(records) + 1,  # Autoincremented id
        "FirstName": fake.first_name_female() if is_female else fake.first_name_male(),
        "LastName": fake.last_name(),
        "DateOfBirth": fake.date_of_birth(minimum_age=18, maximum_age=90).strftime('%Y-%m-%d'),
        "Gender": gender,
        "Earnings": random.uniform(10000, 100000),
        "Wife": has_wife,
        "Husband": has_husband,
        "SpouseName": fake.first_name_male() if is_female else fake.first_name_female() if has_wife else "",
        "Mother": has_mother,
        "Father": has_father,
        "MotherName": fake.first_name_female() if has_mother else "",
        "FatherName": fake.first_name_male() if has_father else ""
    }
    
    records.append(record)

with open('seed-data.json', 'w') as json_file:
    json.dump(records, json_file, indent=4)
