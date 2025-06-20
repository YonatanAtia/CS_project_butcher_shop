# 🥩 Butcher Shop - Point of Sale System

Final project for Object-Oriented Programming course - Advanced sales management system for butcher shops

## 📋 Project Description

An advanced point-of-sale system for butcher shops that enables complete management of the purchasing process. The project was developed in C# with Windows Forms and includes a beautifully designed and intuitive graphical user interface.

## ✨ Key Features

### 🛒 Product & Purchase Management
- **Diverse Product Categories** - 18 different products across multiple categories:
  - **Meat Products**: Hot Dogs, Sinta, Steaks, Chicken (Wings, Whole, Legs)
  - **Fish Products**: Tuna, Amnon, Salmon
  - **Alcoholic Beverages**: Wine (Rioja, Bazelet, Champagne), Beer (Corona, Paulaner, Heineken), Spirits (Tequila, Gin, Vodka)
- **Smart Cart System** - Add/remove products with automatic quantity and price tracking
- **Real-time Inventory** - Dynamic product management with serial number tracking

### 📄 Invoice System
- **Detailed Receipt** - Complete tracking of 18 different products with serial numbers
- **Automatic Calculations** - Real-time price and quantity updates
- **Product Details Structure** - Custom data structure storing name, amount, price, and serial number
- **Cart Management** - Add/subtract individual items with price adjustment
- **Transaction Control** - Copy/restore cart states and clear functionality

### 🎨 User Interface
- **Stylized GUI** - Modern and professional graphical interface
- **Intuitive User Experience** - Easy and clear navigation
- **Custom Design** - Interface tailored for butcher shop work environment

## 🏗️ Architecture & Design

### Class Structure
- **Product Categories**: Organized hierarchy supporting meat, fish, and alcoholic beverages
- **Specialized Attributes**: Each product type has unique properties (e.g., fat percentage for meat, alcohol content for drinks)
- **Cart Management**: Centralized `CartList` class handling all purchase operations
- **Data Persistence**: Serializable classes for potential data storage

## 🛠️ Technologies
- **18 Pre-defined Products** with unique serial numbers
- **Dynamic Pricing System** with real-time calculations
- **Flexible Cart Operations** - add, remove, clear, and restore
- **Type-specific Properties** - wines have grape type and age, fish have fillet status, etc.

- **Language**: C#
- **Platform**: .NET Framework
- **User Interface**: Windows Forms
- **Architecture**: Object-Oriented Programming (OOP)

## 📚 Implemented OOP Concepts

- **Inheritance Hierarchy** - Complex class structure:
  - `Product` (base class)
  - `Meat` → `Fish`, `Cattle`, `Chicken` (specialized meat types)
  - `Alcohol_Drink` → `Wine`, `Beer`, `Other_Alcohol_Drink` (beverage categories)
- **Encapsulation** - Protected fields with public properties for data access control
- **Polymorphism** - Different product types with specialized attributes and behaviors
- **Abstraction** - Generic product handling through base class interfaces
- **Serialization** - All classes marked as `[Serializable]` for data persistence
- **Static Management** - Global cart management with static methods and properties

## 🚀 Running the Project

### System Requirements
- Windows 10/11
- .NET Framework 4.7.2 or higher
- Visual Studio 2019 or higher (for development)

### Installation & Execution
1. Clone the repository:
   ```bash
   git clone https://github.com/YonatanAtia/CS_project_butcher_shop.git
   ```

2. Open the project:
   - Open `Butcher_Shop.sln` in Visual Studio
   - Or double-click the Solution file

3. Run the project:
   - Press F5 or click the Start button
   - The project will compile and run automatically

## 🎯 Project Goals

This project was developed as part of an Object-Oriented Programming course with the aim of:
- Demonstrating the use of OOP concepts
- Developing a professional user interface
- Implementing complex business logic
- Working with data structures and algorithms

## 👨‍💻 Developers

**Yonatan Atia & Yahel Sade** - Programming Students  
Final project collaboration for OOP course

## 📄 License

This project was developed for educational purposes and is not intended for commercial use.

---

*Final project for Object-Oriented Programming course - 2025*
