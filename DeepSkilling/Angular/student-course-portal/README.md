# Student Course Portal
The Student Course Portal is an Angular-based web application developed as part of the Cognizant Digital Nurture 5.0 Angular Hands-On exercises. The project is designed to help students access course information, manage enrollments, view profiles, and explore academic resources through a modern and user-friendly interface.
## Project Setup
Before running the application, make sure the following are installed:
* Node.js (v20 or later)
* npm
* Angular CLI
To install Angular CLI globally:
```bash
npm install -g @angular/cli
```
## Running the Application
Start the development server using:

```bash
ng serve
```
Once the application is running, open your browser and navigate to:
```text
http://localhost:4200/
```
The application will automatically reload whenever source files are modified.
## Project Structure
This project follows Angular's standalone component architecture and includes:

* Routing configuration
* Reusable components
* Modular folder organization
* TypeScript-based development
* CSS styling
## Generating New Components
To create a new Angular component:
```bash
ng generate component component-name
```
Example:
```bash
ng generate component pages/home
```
## Building the Project
To generate a production build:
```bash
ng build
```
The compiled files will be created inside the `dist/` folder.
## Testing
Run unit tests using:
```bash
ng test
```
Run end-to-end tests (if configured):
```bash
ng e2e
```
