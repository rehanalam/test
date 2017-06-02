# Getting started

## How to Build

The generated code uses a few Gradle dependencies e.g., Jackson, Volley,
and Apache HttpClient. The reference to these dependencies is already
added in the build.gradle file will be installed automatically. Therefore,
you will need internet access for a successful build.

* In order to open the client library in Android Studio click on ``` Open an Existing Android Project ```.

![Importing SDK into Android Studio - Step 1](https://apidocs.io/illustration/android?step=import1&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

* Browse to locate the folder containing the source code. Select the location of the CalcLib gradle project and click ``` Ok ```.

![Importing SDK into Android Studio - Step 2](https://apidocs.io/illustration/android?step=import2&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

* Upon successful import, the project can be built by clicking on ``` Build > Make Project ``` or  pressing ``` Ctrl + F9 ```.

![Importing SDK into Android Studio - Step 3](https://apidocs.io/illustration/android?step=import3&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

## How to Use

The following section explains how to use the CalcLib library in a new project.

### 1. Starting a new project 

For starting a new project, click on ``` Create New Android Studio Project ```.

![Add a new project in Android Studio - Step 1](https://apidocs.io/illustration/android?step=createNewProject0&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

Here, configure the new project by adding the name, domain and location of the sample application followed by clicking ``` Next ```.

![Create a new Android Studio Project - Step 2](https://apidocs.io/illustration/android?step=createNewProject1&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

Following this, select the ``` Phone and Tablet ```` option as shown in the illustration below and click ``` Next ```. 

![Create a new Android Studio Project - Step 3](https://apidocs.io/illustration/android?step=createNewProject2&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

In the following step, choose ``` Empty Activity ``` as the activity type and click ``` Next ```.

![Create a new Android Studio Project - Step 4](https://apidocs.io/illustration/android?step=createNewProject3&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

In this step, provide an ``` Activity Name ``` and ``` Layout Name ``` and click ``` Finish ```.  This would take you to the newly created project.

![Create a new Android Studio Project - Step 4](https://apidocs.io/illustration/android?step=createNewProject4&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

### 2. Add reference of the library project

In order to add a dependency to this sample application, click on the android button shown in the project explorer on the left side as shown in the picture. Click on ``` Project ``` in the drop down that emerges.  

![Adding dependency to the client library - Step 1](https://apidocs.io/illustration/android?step=testProject0&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

Right click the sample application in the project explorer and click on ``` New > Module ```  as shown in the picture.

![Adding dependency to the client library - Step 2](https://apidocs.io/illustration/android?step=testProject1&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

Choose ``` Import Gradle Project ``` and click ``` Next ```.

![Adding dependency to the client library - Step 3](https://apidocs.io/illustration/android?step=testProject2&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

Click on ``` Finish ``` which would take you back to the sample application with the refernced SDK. 

![Adding dependency to the client library - Step 4](https://apidocs.io/illustration/android?step=testProject3&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

In the following step naigate to the ``` SampleApplication >  app > build.gradle ``` file and add the following line ```compile project(path: ':CalcLib')``` to the dependencies section as shown in the illustration below.

![Adding dependency to the client library - Step 5](https://apidocs.io/illustration/android?step=testProject4&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

Finally, press ``` Sync Now ``` in the warning visible as shown in the picture below.

![Adding dependency to the client library - Step 6](https://apidocs.io/illustration/android?step=testProject5&workspaceFolder=Calc&workspaceName=CalcLib&projectName=CalcLib&rootNamespace=io.apimatic.examples)

### 3. Write sample code

Once the ``` SampleApplication ``` is created, a file named ``` SampleApplication > app > src > main > java > MainActivity ``` will be visible in the *Project Explorer* with an ``` onCreate ``` method. This is the entry point for the execution of the created project.
Here, you can add code to initialize the client library and instantiate a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

## How to Test

The generated code and the server can be tested using automatically generated test cases. 
JUnit is used as the testing framework and test runner.

In Android Studio, for running the tests do the following:

1. Right click on *SampleApplication > CalcLib > androidTest > java)* from the project explorer.
2. Select "Run All Tests" or use "Ctrl + Shift + F10" to run the Tests.

## Initialization

### 

API client can be initialized as following. The `appContext` being passed is the Android application [`Context`](https://developer.android.com/reference/android/content/Context.html).

```java

io.apimatic.examples.Configuration.initialize(appContext);
CalcLibClient client = new CalcLibClient();
```

# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SimpleCalculatorController](#simple_calculator_controller)

## <a name="simple_calculator_controller"></a>![Class: ](https://apidocs.io/img/class.png "io.apimatic.examples.controllers.SimpleCalculatorController") SimpleCalculatorController

### Get singleton instance

The singleton instance of the ``` SimpleCalculatorController ``` class can be accessed from the API Client.

```java
SimpleCalculatorController simpleCalculator = client.getSimpleCalculator();
```

### <a name="get_calculate_async"></a>![Method: ](https://apidocs.io/img/method.png "io.apimatic.examples.controllers.SimpleCalculatorController.getCalculateAsync") getCalculateAsync

> Calculates the expression using the specified operation.


```java
void getCalculateAsync(
        final GetCalculateInput input,
        final APICallBack<Double> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| operation |  ``` Required ```  | The operator to apply on the variables |
| x |  ``` Required ```  | The LHS value |
| y |  ``` Required ```  | The RHS value |


#### Example Usage

```java
GetCalculateInput collect = new GetCalculateInput();

OperationTypeEnum operation = OperationTypeEnum.fromString("SUM");
collect.setOperation(operation);

double x = 134.310793073061;
collect.setX(x);

double y = 134.310793073061;
collect.setY(y);

// Invoking the API call with sample inputs
simpleCalculator.getCalculateAsync(collect, new APICallBack<Double>() {
    public void onSuccess(HttpContext context, Double response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
}
);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 412 | Could not compute the requested calculation |



[Back to List of Controllers](#list_of_controllers)



