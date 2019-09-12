# Creating Logic Apps

## Activity Steps
### Create Logic Apps

1. Go to the azure portal and click create new resource in the top left corner. Select the section Storage and choose the first option Storage Account.
![Storage Account](../images/04-CreateLogicApp/01.StorageAccount.png)

2. Fill all data like shown below
![Storage Account](../images/04-CreateLogicApp/02.StorageAccount.png)

3. When validation is passed, go to create a storage
![Storage Account](../images/04-CreateLogicApp/03.StorageAccount.png)

4. Go to Resource and click **Blob**
![Storage Account](../images/04-CreateLogicApp/05.StorageAccount.png)

5. Create a new **Container** by adding name **image** and chose Public access level: Container (anonymous read access for containers and blobs)
![Storage Account](../images/04-CreateLogicApp/06.StorageAccount.png)

6. Create a new **Container** with the name **results**
![Storage Account](../images/04-CreateLogicApp/07.StorageAccount.png)

7. Before we starting create a logic apps, check that Microsoft Event Grid is Register. To do that go to your Subscription, select subscription you working on, click Resource Providers and find Microsoft Event Grid
![Logic Apps](../images/04-CreateLogicApp/08.EventGrid.png)

8. Click the Register button and wait few second that registration will finish
![Logic Apps](../images/04-CreateLogicApp/09.EventGrid.png)

9. Time to create Logic Apps. Click Add New Resource and find LogicApp
![Logic Apps](../images/04-CreateLogicApp/10.LogiApp.png)

10. Add the name, use the same resource that you use before for this exercice and click create
![Logic Apps](../images/04-CreateLogicApp/11.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/12.LogiApp.png)

11. First we going to add first step **When the Event Grid resources event occurs**
![Logic Apps](../images/04-CreateLogicApp/13.LogiApp.png)

12. Sign in to your Azure tenant to use Event Grid
![Logic Apps](../images/04-CreateLogicApp/14.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/15.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/16.LogiApp.png)

13. We want to check if on our blob will be added any image, to do that we need to fill the step as below
![Logic Apps](../images/04-CreateLogicApp/18.LogiApp.png)

14. Next step is parse the json of the image that we will need to proceed
![Logic Apps](../images/04-CreateLogicApp/19.LogiApp.png)

15. In Conent add Body (don't type, select the Body from dynamic content) and in schema copy the json from the [JSON file]()
![Logic Apps](../images/04-CreateLogicApp/21.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/22.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/23.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/24.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/25.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/26.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/27.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/28.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/29.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/30.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/31.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/32.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/33.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/34.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/35.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/36.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/37.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/38.LogiApp.png)
![Logic Apps](../images/04-CreateLogicApp/39.LogiApp.png)