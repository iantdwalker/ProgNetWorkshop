# Creating Text Analytics

## Activity Steps
### Creating Text Analytics

1. Select Create a resource and search Cognitive Services and choose Enter. Then select Create on the Cognitive Services blade
![Text Analytics](../images/05-TextAnalytics/01.TextAnalytics.png)

2. Enter details to create an account like below:
![Text Analytics](../images/05-TextAnalytics/02.TextAnalytics.png)

3. Get your key and Enpoint 
![Text Analytics](../images/05-TextAnalytics/03.TextAnalytics.png)

4. Open PostMan and create a new Request
![Text Analytics](../images/05-TextAnalytics/04.TextAnalytics.png)

5. Enter request details and create a new collection and save it
![Text Analytics](../images/05-TextAnalytics/05.TextAnalytics.png)

6. Now create a request to call your text analytics API:
* Change from a GET request to a POST request in the top left
* Enter your endpoint URL and add ``text/analytics/v2.0/sentiment`` to the end
* Select Headers underneath the URL box
* In Key type ``Ocp-Apim-Subscription-Key`` and in Value add your KEY1 value
* In Key type ``Content-Type`` and in Value type ``application/json``
![Text Analytics](../images/05-TextAnalytics/06.TextAnalytics.png)


7. 
* Select Body underneath the URL box
* Select raw from the radio button options
* Copy JSON sample from [sentiment-analysis-text.json](https://github.com/gosiaborzecka/ProgNetWorkshop/blob/master/steps/05-TextAnalytics/sentiment-analysis-text.json) into the box

![Text Analytics](../images/05-TextAnalytics/07.TextAnalytics.png)

8. Select the Send button and review the Response
![Text Analytics](../images/05-TextAnalytics/08.TextAnalytics.png)

9. Copy JSON sample from [sentiment-analysis-text-fr.json](https://github.com/gosiaborzecka/ProgNetWorkshop/blob/master/steps/05-TextAnalytics/sentiment-analysis-text-fr.json) into the box
![Text Analytics](../images/05-TextAnalytics/09.TextAnalytics.png)

## Add other APIs that you will use in future and test them in the PostMan