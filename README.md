# 🍔 Food Delivery System (.NET 10 | Clean Architecture)

A console-based **Food Delivery System** built using **.NET 10 and C# 14**, designed to demonstrate strong **OOP principles, SOLID design**, and modern C# features like **Records** and **Primary Constructors**.

---

## 📌 Overview

This project simulates a real-world food delivery flow:

- Customer adds items to cart  
- Applies discounts  
- Proceeds to checkout  
- Payment is processed  
- Order is finalized  

The focus is on:
- Proper domain modeling  
- Clean architecture (logical separation)  
- Maintainable and scalable design  

---

## ⚙️ Tech Stack

- .NET 10  
- C# 14  
- Console Application  

---

## 🏗️ Project Structure

```text
FoodDeliverySystem
│
├── Domain
│   ├── Entities
│   └── Interfaces
│
├── Services
│
├── Infrastructure
│   └── Payments
│
│ └── Program.cs
```
## 📊 Sample Output
<img width="655" height="209" alt="image" src="https://github.com/user-attachments/assets/e4039af4-e19d-457e-9a43-491976c43574" />

## 🧾 Concepts & Technologies Used

This project demonstrates a strong combination of **OOP principles, SOLID design, and modern C# features**.

### 🧠 Object-Oriented Programming (OOP)

- **Encapsulation** → Controlled access to data (Cart, Order)
- **Abstraction** → Base classes like `User`, `Payment`
- **Inheritance** → `User → Customer, Admin`
- **Polymorphism** → Runtime behavior in payment processing
- **Method Overloading** → DiscountManager Methods
- **Method Overriding** → Payment implementations
- **Interfaces** → `IPaymentProcessor` for loose coupling
- **Exception Handling** → Input validation and safe execution
- **Sealed Class** → DiscountManager

---

### 🧱 SOLID Principles

- **SRP** → Each class has a single responsibility  
- **OCP** → Easily extendable without modifying existing code  
- **LSP** → Subtypes behave correctly as base types  
- **ISP** → Small, focused interfaces  
- **DIP** → Depend on abstractions, not concrete implementations  

---

### ✨ Modern C# Features

- **Records** → Immutable value objects (e.g., `Address`)
- **Primary Constructors** → Reduced boilerplate
- **Expression-bodied members** → Cleaner methods
- **Required properties** → Safer object initialization

---

### 🏗️ Design Principles

- **Composition over Inheritance**
  - `Customer HAS-A Cart`
  - `Customer HAS-A Address`

- **Separation of Concerns**
  - Domain, Services, Infrastructure, Presentation

- **Immutable**
  - Order: Immutable
  - Addreess: Immutable

---

### ⚙️ Technical Skills Demonstrated

- Clean Architecture (logical separation)
- Domain-driven design thinking
- Scalable and maintainable coding practices
