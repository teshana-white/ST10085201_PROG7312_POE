# ST10085201_PROG7312_POE
## Municipal Service Delivery App
The attached software is a municipal service delivery application, aimed at reporting issues regarding municipal related services in their area. The application is a windows form (.net framework) application that focuses on the need for users to report issues, view announcements and view the progress of their respective issues.  This README will go over how to run the application, as well as discuss how the data structures relating to the service request statuses  boost efficiency within the application.

## Reporting an issue 
On this page the user is able type out their location, select a category of the issue from a drop down, describe the issue and attach a file to the report which can be viewed via a generic list. Detailed below you may find instructions on how to run the application: 
1. On the main menu you will see four buttons; “Report Issues”, “Local Events”, “Service Status” and “Exit”. To report an issue click on “Report Issues” or to close click “Exit” 
2. If “Report Issues” was selected you will be navigated to the “Report Issues Form”. 
3. To begin reporting an issue you must navigate to the “Location” label, click on the adjacent text box and type in your location. 
4. Then you must select a category by clicking on the drop down seen in the combo box, you may then select a category from the ones listed in the combo box. 
5. You will then be required to type out a short description of your issue in the text box near the label “Description”. 
6. You may end there and submit the application to the system, or you may attach a file by clicking on the “Attach File” button. 
7. Once you are satisfied with your input you may click on the “Submit” button, where your issue will be submitted on the system. 
8. To view issues you must click on the “View Issues” button and to return to the main menu you must click on “Back to Main”, or click “Exit” to exit.

## Viewing Issues, Announcements and Searching
This is where the user can view announcements and local events and search for events created by the municipality. The ui consists of list boxes, as well as a text box, date time picker, combo box and search button. Below will be the detailed instructions on how to navigate and run this page:
1. On the main menu you will see four buttons; “Report Issues”, “Local Events”, “Service Status” and “Exit”. To view the local events and announcements click on “Local Events” or to close click “Exit” 
2. If “Local Events” was selected you will be navigated to the “Report Issues Form”. 
3. To search you may type the name of the event in the text box above, choose a date or select a category from the combo box. To process the data click the “Search” button.
4. The search results will appear in the list box under the label “Results” and the history will appear under the label “Search History”. Both will be cleared after exiting or returning to main.
5. To view the descriptions of the events, click on an item in the list box and a pop up ill appear with the event details. The same applies to the announcements.
6. To return to the main menu you must click on “Back to Main”, or click “Exit” to exit.

## Viewing Service Request Statuses and MST
On this window you will be able to view service requests and their statuses in a list box, as well as a MST graph to display the relationships between them. To run this window follow the instructions listed below:
1. On the main menu you will see four buttons; “Report Issues”, “Local Events”, “Service Status” and “Exit”. To view the service request statuses and MST click on “Service Status” or to close click “Exit” 
2. If “Service Status” was selected you will be navigated to the “Service Status Form”. 
3. To view more details on the items in the list box, click on an item and a pop-up will appear with the full details of the service request. 
4. To view the MST click on the button below called “View MST” and the MST will be loaded.
5. To view the MST edges, navigate to the list box underneath the label “MST Edges” and they can be accessed there.
6. To return to the main menu you must click on “Back to Main”, or click “Exit” to exit.

# Data Structures
The data structures found in service request status feature are:
- AVL Trees
- Min-Heap Binary Tree
- Minimum-Spanning Tree (Graph)
- Hashset
- Dictionary
- List
- Queue

## Roles of Data Structures
A tree structure is generally used to store and organise data in a solution. In the case of this project the trees were used to store the data of the method PopulateData(), which is needed to create the MST. The AVL tree is needed to store and retrieve the PopulateData() values, while the Min-Heap is needed to efficiently retrieve data from ServiceRequest based on the priority of the data. The lesser data structures are included in methods to store and traverse through the code, in order to effectively load the data into the MST so that the graph may appear accurately.
