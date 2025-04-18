# ASP.NET Unit Testing Demo

This is a beginner-level ASP.NET Core Web API project that demonstrates how to perform unit testing using xUnit.

## 📌 What is Unit Testing?

Unit testing is a software testing technique where individual units or components of the application are tested in isolation to verify that they work as expected. It helps catch bugs early and ensures your code behaves correctly.

## 📁 Project Structure

The solution contains two projects:

1. **xunitExample** – ASP.NET Core Web API project with a controller and a basic logic method.
2. **xunitExample.Tests** – xUnit test project that tests the API controller logic.

## ✅ Testing Methodology – AAA Pattern

We follow the **AAA** methodology in writing tests:

- **Arrange**: Set up any necessary objects and prepare the prerequisites.
- **Act**: Call the method being tested.
- **Assert**: Verify the result is as expected.
