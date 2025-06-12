# 🌐 OpdrachtASP.NETCore

This ASP.NET Core MVC application was developed as a school assignment to demonstrate multilingual support, form handling with validation, custom tag helpers, and the use of controllers and views.

---

## 🎯 Project Overview

- Provides a **welcome page** that displays content in **Dutch, English, and French**, automatically adapting to the user's browser language settings.  
- Contains a **contact form** where users can enter their **name, email, and message** with validation rules ensuring:
  - All fields are required  
  - Email format is valid  
  - Message length constraints  
- Implements a **custom Tag Helper (`<lorem>`)** that injects placeholder *Lorem Ipsum* text into views.  
- Uses MVC architecture with custom controllers and views.  
- Adjusts layout and styling to provide a clean user experience.

---

## 🔧 Key Components

| Feature           | Description                                   |
|-------------------|-----------------------------------------------|
| Welcome Page      | Multilingual content based on browser language |
| Contact Form      | Input validation on Name, Email, and Message |
| Custom Tag Helper | `<lorem>` tag outputs predefined placeholder text |
| MVC Structure     | Controllers handle requests; strongly-typed views for data |

---

## 🚀 Running the Project

1. Clone the repo and open it in Visual Studio.  
2. Restore NuGet packages.  
3. Run the app.  
4. The welcome page language adapts based on your browser's language.  
5. Navigate to the contact form to submit messages with validation.

---

## 📚 Technologies Used

- ASP.NET Core MVC  
- Razor Views  
- Custom Tag Helpers  
- Model Binding and Validation  

---

## 🎓 Notes

- This project was created as a learning assignment to explore multilingual content, MVC forms, validation, and custom tag helpers.  
- No persistent storage (database) is used; data is kept in-memory for demo purposes.
