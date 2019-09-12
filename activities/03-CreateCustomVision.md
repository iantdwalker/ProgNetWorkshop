# Creating Custom Vision API

## Activity Steps
### Create Cognitive Services

1. Go to Azure Portal and select new Resource and Find **Custom Vision**
![Azure Cognitive Services](../images/03-CreateCustomVision/01.CreateCustomVision.png)

2. Click to create a new **Custom Vision** API
![Azure Cognitive Services](../images/03-CreateCustomVision/02.CreateCustomVision.png)

3. Fill data with the all data like shown below (use the same resource group that you create in Activity 1)
![Azure Cognitive Services](../images/03-CreateCustomVision/03.CreateCustomVision.png)

4. Now you have your Endpoint and Key that can be used in the [Custom Vision Portal](https://customvision.ai)
![Azure Cognitive Services](../images/03-CreateCustomVision/04.CreateCustomVision.png)

5. Go to the [Custom Vision Portal](https://customvision.ai) and select settings to see that your Custom Vision API was created. You need to login with the same credentails that you login into Azure Portal
![Custom Vision](../images/03-CreateCustomVision/05.CustomVision.PNG)

6. Back to main page and create a new project
![Custom Vision](../images/03-CreateCustomVision/06.CustomVision.PNG)

7. Put name, description and resource.
  Select: 
    Project Types: Classification
    Classification Types: Multiclass (Single tag per image)
    Domains: General
![Custom Vision](../images/03-CreateCustomVision/07.CustomVision.PNG)

8. Now we can start adding images and assigning them tags to create our image classifier. 
* Click Add Images and Select all images from [beagle folder](https://github.com/gosiaborzecka/ProgNetWorkshop/tree/master/steps/03-CreateCustomVision/images/beagle) and tag them as **beagle**
![Custom Vision](../images/03-CreateCustomVision/08.CustomVision.PNG)
![Custom Vision](../images/03-CreateCustomVision/09.CustomVision.PNG)

* Click Add Images and Select all images from [bernese-mountain-dog folder](https://github.com/gosiaborzecka/ProgNetWorkshop/tree/master/steps/03-CreateCustomVision/images/bernese-mountain-dog)  and tag them as **bernese-mountain-dog**
![Custom Vision](../images/03-CreateCustomVision/10.CustomVision.PNG)
![Custom Vision](../images/03-CreateCustomVision/11.CustomVision.PNG)

* Click Add Images and Select all images from [chihuahua folder](https://github.com/gosiaborzecka/ProgNetWorkshop/tree/master/steps/03-CreateCustomVision/images/chihuahua)  and tag them as **chihuahua**
![Custom Vision](../images/03-CreateCustomVision/12.CustomVision.PNG)
![Custom Vision](../images/03-CreateCustomVision/13.CustomVision.PNG)


* Click Add Images and Select all images from [eskimo-dog folder](https://github.com/gosiaborzecka/ProgNetWorkshop/tree/master/steps/03-CreateCustomVision/images/eskimo-dog)  and tag them as **eskimo-dog**
![Custom Vision](../images/03-CreateCustomVision/14.CustomVision.PNG)
![Custom Vision](../images/03-CreateCustomVision/15.CustomVision.PNG)

* Click Add Images and Select all images from [german-shepherd folder](https://github.com/gosiaborzecka/ProgNetWorkshop/tree/master/steps/03-CreateCustomVision/images/german-shepherd)  and tag them as **german-shepherd**
![Custom Vision](../images/03-CreateCustomVision/16.CustomVision.PNG)
![Custom Vision](../images/03-CreateCustomVision/17.CustomVision.PNG)

* Click Add Images and Select all images from [golden-retriever folder](https://github.com/gosiaborzecka/ProgNetWorkshop/tree/master/steps/03-CreateCustomVision/images/golden-retriever)  and tag them as **golden-retriever**
![Custom Vision](../images/03-CreateCustomVision/18.CustomVision.PNG)
![Custom Vision](../images/03-CreateCustomVision/19.CustomVision.PNG)

* Click Add Images and Select all images from [maltese-dog folder](https://github.com/gosiaborzecka/ProgNetWorkshop/tree/master/steps/03-CreateCustomVision/images/maltese-dog)  and tag them as **maltese-dogr**
![Custom Vision](../images/03-CreateCustomVision/20.CustomVision.PNG)
![Custom Vision](../images/03-CreateCustomVision/21.CustomVision.PNG)


9. When all images are uploaded and tagged we can train our model
![Custom Vision](../images/03-CreateCustomVision/22.CustomVision.PNG)

10. When model train is completed we can check the performance of the model and performance per tag
![Custom Vision](../images/03-CreateCustomVision/23.CustomVision.PNG)
![Custom Vision](../images/03-CreateCustomVision/24.CustomVision.PNG)

11. Now it's time to test our model with images form [testset folder](https://github.com/gosiaborzecka/ProgNetWorkshop/tree/master/steps/03-CreateCustomVision/testset)
![Custom Vision](../images/03-CreateCustomVision/25.CustomVision.PNG)
![Custom Vision](../images/03-CreateCustomVision/26.CustomVision.PNG)
![Custom Vision](../images/03-CreateCustomVision/27.CustomVision.PNG)


12. Go to Prediction and see how Custom Vision tags images. You can tag them by yourself and then this images will be added into your model
![Custom Vision](../images/03-CreateCustomVision/28.CustomVision.PNG)
![Custom Vision](../images/03-CreateCustomVision/29.CustomVision.PNG)

13. Train once again the model

![Custom Vision](../images/03-CreateCustomVision/30.CustomVision.PNG)

14. Now we have our Iteration 2 and we can go an publish our model
![Custom Vision](../images/03-CreateCustomVision/31.CustomVision.PNG)

15. Click the publish button, add the model name and choose the prediction resource
![Custom Vision](../images/03-CreateCustomVision/32.CustomVision.PNG)

16. Now we have our model that we can use in custom applications
![Custom Vision](../images/03-CreateCustomVision/32.CustomVision.PNG)
