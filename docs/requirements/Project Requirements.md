#Project Requirements

- Login page is displayed when a person first enters the website and goes to the website

##Log-in Page
o  When the login page is loaded, a textbox with the words “Enter Username:” next to it will appear.
o  When the login page is loaded, a textbox with the words “Enter password” underneath the Username textbox.
o  Under the username and password boxes is a ‘Login’ button
o  When the ‘Login’ button is pushed, the controller will check the database to ensure that the username and password match, if they match, the user will be sent to the ‘Homepage’, otherwise, the user will be redirected back to the login page.
o  At the bottom of the page a ‘Create new account’ button will be located.  When clicked, the user will be directed to the ‘Create new account’ page.

##Create account page
o Top text box will be for the person’s name
o Next text box will be for the username.
o When the username is input the controller will check the database to ensure that username is not already in use.
o The next selection box will be for the user type (Personal, Service Provider, Support Organization)
o Next textbox allows for the user to enter their zipcode.  When the zipcode is entered, it will check and autofill the name of the city and state.
o Textbox both autofilled when the user inputs the zipcode or can be manually filled in by the user.
o Textbox both autofilled when the user inputs the zipcode or can be manually filled in by the user.  Limited to two-letter state code.
o Next textbox is for the user to enter their email.
o Last is the ‘Create account’ button, which when clicked will store all the previously entered data into the database.
o Also, when the ‘Create account’ button is clicked an email will be sent to the email provided by the user to verify the account
o When the ‘Create account’ button is clicked the user will be led to the ‘Please verify your created account’ page.



##Verify Account Page
o The ‘Verify account page’ will only contain the words “Please check your {insert email address here} for a verification email.

##Account Verified Page
o When the user clicks on their email to verify the page, it takes them to the ‘Account verified page’
o The words ‘account has been verified’ will be displayed on the top
o A button will be located underneath saying “Return to Login page”  When clicked, the user will return to the login page.

##Home Page
o On the user’s homepage, it will display the user’s picture and name.
o In the middle it will display recent Posts from users and groups they follow.
o At the top of the homepage, a search box will allow the user to input a search.  When the ‘search’ button is clicked, the controller will then search for the appropriate information input into the search box.
o Above posts from others, a large textbox will be open for the user to enter a ‘post’.  <See Post section>
 
##Other People’s pages
o When navigating to another user’s page the controller will check to make sure the other user has given permission for that user to view their page.
o This page will be set up similar to the user’s homepage with the ability to view posts from the user whose page is being visited

##Post
o Each post will have a large text field to enter in information
o When the ‘Post’ button is clicked, the controller will check if there is any information in the textbox
  - If there is text in the textbox the post will be logged into the database and then posted on that page
  - If there is no information in the textbox, nothing will occur.
o Once a post is ‘posted’ a ‘Like’ button will be located under the post
o A ‘reply’ textbox will be located underneath the ‘post’ with a ‘reply’ button.
  - When the ‘reply’ button is pushed the controller will check if there is anything in the textbox
    * If nothing is in the textbox nothing happens
    * If something is in the textbox the controller will store it in the database and the page will then display it under the ‘Post’

