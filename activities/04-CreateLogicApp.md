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
![Logic Apps](../images/04-CreateLogicApp/10.LogicApp.png)

10. Add the name, use the same resource that you use before for this exercice and click create
![Logic Apps](../images/04-CreateLogicApp/11.LogicApp.png)
![Logic Apps](../images/04-CreateLogicApp/12.LogicApp.png)

11. First we going to add first step **When the Event Grid resources event occurs**
![Logic Apps](../images/04-CreateLogicApp/13.LogicApp.png)

12. Sign in to your Azure tenant to use Event Grid
![Logic Apps](../images/04-CreateLogicApp/14.LogicApp.png)
![Logic Apps](../images/04-CreateLogicApp/15.LogicApp.png)
![Logic Apps](../images/04-CreateLogicApp/16.LogicApp.png)

13. We want to check if on our blob will be added any image, to do that we need to fill the step as below
![Logic Apps](../images/04-CreateLogicApp/18.LogicApp.png)

14. Next step is parse the json of the image that we will need to proceed
![Logic Apps](../images/04-CreateLogicApp/19.LogicApp.png)

15. In Conent add Body (don't type, select the Body from dynamic content) and in schema copy the json from the [JSON file](https://github.com/gosiaborzecka/ProgNetWorkshop/blob/master/steps/04-CreateLogicApp/logic-app-schema1.json)
![Logic Apps](../images/04-CreateLogicApp/21.LogicApp.png)

16. Next step is to connect to our Custom Vision app. Add new step and select Custom Vision
![Logic Apps](../images/04-CreateLogicApp/22.LogicApp.png)

17. Selelct **Classify an image url (preview)**
![Logic Apps](../images/04-CreateLogicApp/23.LogicApp.png)

18. Next we need to add Connection Name (custom) and Prediction Kety and Site URL from [CustomVision.ai website](http://customvision.ai)
![Logic Apps](../images/04-CreateLogicApp/24.LogicApp.png)


19. In Published app you have all information about prediction key and url (get only https://{localization}.api.cognitive.microsoft.com)
![Logic Apps](../images/04-CreateLogicApp/26.LogicApp.png)

20. Now add custom connection name and Prediction Key and Site URL from the CustomVision.ai website
![Logic Apps](../images/04-CreateLogicApp/28.LogicApp.png)

21. Next go back to  [CustomVision.ai](http://customvision.ai) and select Project settings, where you will find Project information (that we will use for next steps)
![Logic Apps](../images/04-CreateLogicApp/27.LogicApp.png)

22. Update information from [CustomVision.ai](https://customvision.ai) by adding project ID and a name of your publishing name. Also select the dynamic content and select **url**
![Logic Apps](../images/04-CreateLogicApp/29.LogicApp.png)

23. Next add new step **For Each**
![Logic Apps](../images/04-CreateLogicApp/30.LogicApp.png)

24. And select from dynamic content **Prediction**
![Logic Apps](../images/04-CreateLogicApp/31.LogicApp.png)

25. Select Next step **Control** and **Condition**
![Logic Apps](../images/04-CreateLogicApp/32.LogicApp.png)

26. Inside select from dynamic conent **Prediction Probability** and select **is greater than** **0.7**
![Logic Apps](../images/04-CreateLogicApp/33.LogicApp.png)

27. Add next step: **Azure Blob storage** and select **Create blob**
![Logic Apps](../images/04-CreateLogicApp/34.LogicApp.png)

28. Select storage that was created at begining of this exercise
![Logic Apps](../images/04-CreateLogicApp/35.LogicApp.png)

29. Select the folder **result** - there we will put the results that will back from **Custom Vision**
![Logic Apps](../images/04-CreateLogicApp/36.LogicApp.png)

30. Save **Logic app** and go back to storage **image** and upload image from testset
![Logic Apps](../images/04-CreateLogicApp/37.LogicApp.png)

31. When you back again to **Logic App** tou will find the result and see exactly that the Logic App finished with Success
![Logic Apps](../images/04-CreateLogicApp/38.LogicApp.png)

32. The same result you will find in the storage in the **result** container
![Logic Apps](../images/04-CreateLogicApp/39.LogicApp.png)