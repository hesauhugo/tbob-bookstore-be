# Application Developed
## Use cases
* As the system administrator, I want to register an user so that they have a record in the bookstore.
  * Action: The user must fill in a form with their name, e-mail address, password and telephone number.
  * Validation
    * The system must check the uniqueness of the e-mail
    * Check the password complexity
    * Format the phone number
  * Expected result: 
    * The admin ends the register the user and they get an e-mail to confirm and change password.
  * Acceptance criteria:
    * The registration form is accessible on the home page.
    * The system validates the uniqueness of the e-mail address and the complexity of the password.
    * After registration, the user receives a confirmation e-mail.