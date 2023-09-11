**Linked to Project hosted:** (https://ecopowersolutionswebapp.azurewebsites.net/index.html)
# CMPG-323-Project-2---30844495
 The project entails the development of a comprehensive CRUD RESTful API for EcoPower Logistics, facilitating the seamless management of logistics data by integrating REST architecture and database operations to enhance efficiency and customer experience.

# EcoPower Logistics CRUD RESTful API Project
Welcome to the EcoPower Logistics CRUD RESTful API project! This repository serves as the central hub for the development of a comprehensive API that will revolutionize the way we manage logistics data within the solar energy systems context.

# Table of Contents
- Project Overview
- Project Aim
- Getting Started
- Prerequisites
GitHub Repository
API Documentation
Database Setup
API Implementation
Functionality
Customer Management
Order Management
Product Management
Project Close-out
Contributions and Issues
License
Project Aim

# Project Overview
The primary goal of the EcoPower Logistics CRUD RESTful API project is to create a powerful tool that optimizes our logistics operations. By integrating the RESTful architecture and utilizing CRUD operations, we aim to streamline the management of logistics data related to solar energy systems. This API will enhance the efficiency, accuracy, and customer experience throughout the entire logistics process, from sourcing components to final delivery.

# Getting Started
Before diving into the project, ensure you have all the necessary resources in place.

# Prerequisites
To successfully work on this project, make sure you have the following prerequisites:

Access to the NWU Azure tenant using your MS Fed account: 12345678@mynwu.ac.za
Created a resource group following the appropriate naming convention.
Installed Visual Studio 2022 Community Edition.
Installed .NET Core 6.
GitHub Repository
If you've already created a repository for Project 2 named 'CMPG 323 Project 2 - <add your student number>', you're all set. If not, create a new repository that will serve as the central hub for your project.

# API Documentation
Your project repository should contain a ReadME.md file. This document will be your project's guide, explaining how stakeholders should interact with the API and understand its functionalities.

# Database Setup
Configure your Azure SQL Server:

Create a secure service account with appropriate credentials.
Set up an Azure SQL Server with a free-tier F1 database.
Execute the provided SQL script to create the required database tables.
API Implementation
Clone the repository to your local environment and create a new .NET Core Web API project. Scaffold the database into the project and apply dependency injection by adding the DBContext to the Startup.cs file.

# Functionality
The project focuses on building key functionalities within the API.

# Customer Management
Implement CRUD operations for customers, including retrieval of all customers, fetching a single customer by ID, creating new customers, updating existing customers, and deleting customers.
Order Management
Develop CRUD operations for orders, allowing retrieval of all orders, fetching a specific order by ID, creating new orders, updating orders, and deleting orders.
Implement a method to retrieve all orders for a specific customer.
Product Management
Create endpoints for CRUD operations on products, including retrieval of all products, fetching a specific product by ID, creating new products, updating products, and deleting products.
Implement a method to retrieve all products for a particular order.
Project Close-out
As the project nears completion, ensure the following aspects are addressed:

# Security: Set up proper authentication to restrict API access. Never store sensitive credentials on GitHub.

Web API Cloud Hosting: Create an API Service connected to a free-tier service plan on Azure. Publish your API securely on Azure.

Project Documentation: Keep your ReadME.md file updated with clear instructions on using the API. List all endpoints and additional aspects you've implemented. Additionally, create a reference list for all sources you've used.

Contributions and Issues
We encourage collaboration and appreciate your feedback. If you encounter issues or have suggestions for improvements, follow these steps:

# Fork the repository.
Create a new branch for your feature or bug fix.
Make your changes and commit them.
Push your changes to your fork.
Create a pull request with detailed information about your changes.
For any issues you encounter, please use the GitHub issue tracker to report them.

# License
This project is licensed under the MIT License, granting you the freedom to use, modify, and distribute the code according to the license terms.


