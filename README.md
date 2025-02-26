The Gym Management System is a desktop application built with C# (.NET), Windows Forms, and Entity Framework Core.  
It allows gym administrators to manage memberships, payments, classes, and trainers while enabling members to log in and check their status.  
--> Features  
1- Member & Admin Login – Secure authentication for different roles  
2- Membership Validation – Prevents login if membership is expired or unpaid  
3- CRUD Operations – Manage members, trainers, classes, and payments  
4- Smart Deletion – Prevents deleting a class if members are assigned (sets `ClassId = NULL`)  
5- Payment System – Tracks payments and auto-updates membership status  
