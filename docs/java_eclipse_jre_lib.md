# Getting started

## How to Build

The generated code uses a few Maven dependencies e.g., Jackson, UniRest,
and Apache HttpClient. The reference to these dependencies is already
added in the pom.xml file will be installed automatically. Therefore,
you will need internet access for a successful build.

* In order to open the client library in Eclipse click on ``` File -> Import ```.

![Importing SDK into Eclipse - Step 1](https://apidocs.io/illustration/java?step=import0&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

* In the import dialog, select ``` Existing Java Project ``` and click ``` Next ```.

![Importing SDK into Eclipse - Step 2](https://apidocs.io/illustration/java?step=import1&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

* Browse to locate the folder containing the source code. Select the detected location of the project and click ``` Finish ```.

![Importing SDK into Eclipse - Step 3](https://apidocs.io/illustration/java?step=import2&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

* Upon successful import, the project will be automatically built by Eclipse after automatically resolving the dependencies.

![Importing SDK into Eclipse - Step 4](https://apidocs.io/illustration/java?step=import3&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

## How to Use

The following section explains how to use the MarvelComicsLib library in a new console project.

### 1. Starting a new project

For starting a new project, click the menu command ``` File > New > Project ```.

![Add a new project in Eclipse](https://apidocs.io/illustration/java?step=createNewProject0&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

Next, choose ``` Maven > Maven Project ```and click ``` Next ```.

![Create a new Maven Project - Step 1](https://apidocs.io/illustration/java?step=createNewProject1&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

Here, make sure to use the current workspace by choosing ``` Use default Workspace location ```, as shown in the picture below and click ``` Next ```.

![Create a new Maven Project - Step 2](https://apidocs.io/illustration/java?step=createNewProject2&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

Following this, select the *quick start* project type to create a simple project with an existing class and a ``` main ``` method. To do this, choose ``` maven-archetype-quickstart ``` item from the list and click ``` Next ```.

![Create a new Maven Project - Step 3](https://apidocs.io/illustration/java?step=createNewProject3&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

In the last step, provide a ``` Group Id ``` and ``` Artifact Id ``` as shown in the picture below and click ``` Finish ```.

![Create a new Maven Project - Step 4](https://apidocs.io/illustration/java?step=createNewProject4&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

### 2. Add reference of the library project

The created Maven project manages its dependencies using its ``` pom.xml ``` file. In order to add a dependency on the *MarvelComicsLib* client library, double click on the ``` pom.xml ``` file in the ``` Package Explorer ```. Opening the ``` pom.xml ``` file will render a graphical view on the cavas. Here, switch to the ``` Dependencies ``` tab and click the ``` Add ``` button as shown in the picture below.

![Adding dependency to the client library - Step 1](https://apidocs.io/illustration/java?step=testProject0&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

Clicking the ``` Add ``` button will open a dialog where you need to specify MarvelComicsLib in ``` Group Id ``` and MarvelComicsLib in the ``` Artifact Id ``` fields. Once added click ``` OK ```. Save the ``` pom.xml ``` file.

![Adding dependency to the client library - Step 2](https://apidocs.io/illustration/java?step=testProject1&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

### 3. Write sample code

Once the ``` SimpleConsoleApp ``` is created, a file named ``` App.java ``` will be visible in the *Package Explorer* with a ``` main ``` method. This is the entry point for the execution of the created project.
Here, you can add code to initialize the client library and instantiate a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Adding dependency to the client library - Step 2](https://apidocs.io/illustration/java?step=testProject2&workspaceFolder=MarvelComics-Java&workspaceName=MarvelComicsLib&projectName=MarvelComicsLib&rootNamespace=com.marvel.gateway)

## How to Test

The generated code and the server can be tested using automatically generated test cases. 
JUnit is used as the testing framework and test runner.

In Eclipse, for running the tests do the following:

1. Select the project *MarvelComicsLib* from the package explorer.
2. Select "Run -> Run as -> JUnit Test" or use "Alt + Shift + X" followed by "T" to run the Tests.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| referer | TODO: add a description |
| apikey | TODO: add a description |



API client can be initialized as following.

```java
// Initializing Object Mapper for Serialization and Deserialization purposes
public static ObjectMapper mapper = new ObjectMapper()
{
	private static final long serialVersionUID = -174113593500315394L;
	{
		configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false);
		setSerializationInclusion(JsonInclude.Include.NON_NULL);
	}
};

// Configuration parameters and credentials
String referer = "*.marvel.com";
String apikey = "apikey";

MarvelComicsLibClient client = new MarvelComicsLibClient(referer, apikey);
```

# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [CharactersController](#characters_controller)
* [ComicsController](#comics_controller)
* [EventsController](#events_controller)
* [SeriesController](#series_controller)
* [StoriesController](#stories_controller)
* [CreatorsController](#creators_controller)

## <a name="characters_controller"></a>![Class: ](https://apidocs.io/img/class.png "com.marvel.gateway.controllers.CharactersController") CharactersController

### Get singleton instance

The singleton instance of the ``` CharactersController ``` class can be accessed from the API Client.

```java
CharactersController characters = client.getCharacters();
```

### <a name="get_character_individual_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CharactersController.getCharacterIndividualAsync") getCharacterIndividualAsync

> Fetches a single character by id.


```java
void getCharacterIndividualAsync(
        final String characterId,
        final APICallBack<MCharacter> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | A single character id. |


#### Example Usage

```java
String characterId = "characterId";
// Invoking the API call with sample inputs
characters.getCharacterIndividualAsync(characterId, new APICallBack<MCharacter>() {
    public void onSuccess(HttpContext context, MCharacter response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Character not found. |



### <a name="get_character_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CharactersController.getCharacterCollectionAsync") getCharacterCollectionAsync

> Fetches lists of characters.


```java
void getCharacterCollectionAsync(
        final String comics,
        final String events,
        final String limit,
        final String modifiedSince,
        final String name,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final String stories,
        final APICallBack<CharacterDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only characters which appear in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| nameStartsWith |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```java
String comics = "comics";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String name = "name";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "name";
String series = "series";
String stories = "stories";
// Invoking the API call with sample inputs
characters.getCharacterCollectionAsync(comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, new APICallBack<CharacterDataWrapper>() {
    public void onSuccess(HttpContext context, CharacterDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_character_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CharactersController.getComicCharacterCollectionAsync") getComicCharacterCollectionAsync

> Fetches lists of characters filtered by a comic id.


```java
void getComicCharacterCollectionAsync(
        final String comicId,
        final String events,
        final String limit,
        final String modifiedSince,
        final String name,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final String stories,
        final APICallBack<CharacterDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | The comic id. |
| events |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| nameStartsWith |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```java
String comicId = "comicId";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String name = "name";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "name";
String series = "series";
String stories = "stories";
// Invoking the API call with sample inputs
characters.getComicCharacterCollectionAsync(comicId, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, new APICallBack<CharacterDataWrapper>() {
    public void onSuccess(HttpContext context, CharacterDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_character_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CharactersController.getEventCharacterCollectionAsync") getEventCharacterCollectionAsync

> Fetches lists of characters filtered by an event id.


```java
void getEventCharacterCollectionAsync(
        final String eventId,
        final String comics,
        final String limit,
        final String modifiedSince,
        final String name,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final String stories,
        final APICallBack<CharacterDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | The event ID |
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| nameStartsWith |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```java
String eventId = "eventId";
String comics = "comics";
String limit = "limit";
String modifiedSince = "modifiedSince";
String name = "name";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "name";
String series = "series";
String stories = "stories";
// Invoking the API call with sample inputs
characters.getEventCharacterCollectionAsync(eventId, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, new APICallBack<CharacterDataWrapper>() {
    public void onSuccess(HttpContext context, CharacterDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_character_wrapper_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CharactersController.getSeriesCharacterWrapperAsync") getSeriesCharacterWrapperAsync

> Fetches lists of characters filtered by a series id.


```java
void getSeriesCharacterWrapperAsync(
        final String seriesId,
        final String comics,
        final String events,
        final String limit,
        final String modifiedSince,
        final String name,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String stories,
        final APICallBack<CharacterDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | The series id. |
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| nameStartsWith |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```java
String seriesId = "seriesId";
String comics = "comics";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String name = "name";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "name";
String stories = "stories";
// Invoking the API call with sample inputs
characters.getSeriesCharacterWrapperAsync(seriesId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories, new APICallBack<CharacterDataWrapper>() {
    public void onSuccess(HttpContext context, CharacterDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_character_collection_by_story_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CharactersController.getCharacterCollectionByStoryIdAsync") getCharacterCollectionByStoryIdAsync

> Fetches lists of characters filtered by a story id.


```java
void getCharacterCollectionByStoryIdAsync(
        final String storyId,
        final String comics,
        final String events,
        final String limit,
        final String modifiedSince,
        final String name,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final APICallBack<CharacterDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | The story ID. |
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| nameStartsWith |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```java
String storyId = "storyId";
String comics = "comics";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String name = "name";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "name";
String series = "series";
// Invoking the API call with sample inputs
characters.getCharacterCollectionByStoryIdAsync(storyId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, new APICallBack<CharacterDataWrapper>() {
    public void onSuccess(HttpContext context, CharacterDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="comics_controller"></a>![Class: ](https://apidocs.io/img/class.png "com.marvel.gateway.controllers.ComicsController") ComicsController

### Get singleton instance

The singleton instance of the ``` ComicsController ``` class can be accessed from the API Client.

```java
ComicsController comics = client.getComics();
```

### <a name="get_comics_character_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.ComicsController.getComicsCharacterCollectionAsync") getComicsCharacterCollectionAsync

> Fetches lists of comics filtered by a character id.


```java
void getComicsCharacterCollectionAsync(
        final String characterId,
        final String collaborators,
        final String creators,
        final DateDescriptorEnum dateDescriptor,
        final String dateRange,
        final String diamondCode,
        final String digitalId,
        final String ean,
        final String events,
        final String format,
        final FormatTypeEnum formatType,
        final String hasDigitalIssue,
        final String isbn,
        final String issn,
        final String issueNumber,
        final String limit,
        final String modifiedSince,
        final String noVariants,
        final String offset,
        final String orderBy,
        final String series,
        final String sharedAppearances,
        final String startYear,
        final String stories,
        final String title,
        final String titleStartsWith,
        final String upc,
        final APICallBack<ComicDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | The character id. |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```java
String characterId = "characterId";
String collaborators = "collaborators";
String creators = "creators";
DateDescriptorEnum dateDescriptor = DateDescriptorEnum.fromString("lastWeek");
String dateRange = "dateRange";
String diamondCode = "diamondCode";
String digitalId = "digitalId";
String ean = "ean";
String events = "events";
String format = "comic";
FormatTypeEnum formatType = FormatTypeEnum.fromString("collection");
String hasDigitalIssue = "true";
String isbn = "isbn";
String issn = "issn";
String issueNumber = "issueNumber";
String limit = "limit";
String modifiedSince = "modifiedSince";
String noVariants = "true";
String offset = "offset";
String orderBy = "focDate";
String series = "series";
String sharedAppearances = "sharedAppearances";
String startYear = "startYear";
String stories = "stories";
String title = "title";
String titleStartsWith = "titleStartsWith";
String upc = "upc";
// Invoking the API call with sample inputs
comics.getComicsCharacterCollectionAsync(characterId, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, new APICallBack<ComicDataWrapper>() {
    public void onSuccess(HttpContext context, ComicDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.ComicsController.getComicsCollectionAsync") getComicsCollectionAsync

> Fetches lists of comics.


```java
void getComicsCollectionAsync(
        final String characters,
        final String collaborators,
        final String creators,
        final DateDescriptorEnum dateDescriptor,
        final String dateRange,
        final String diamondCode,
        final String digitalId,
        final String ean,
        final String events,
        final String format,
        final FormatTypeEnum formatType,
        final String hasDigitalIssue,
        final String isbn,
        final String issn,
        final String issueNumber,
        final String limit,
        final String modifiedSince,
        final String noVariants,
        final String offset,
        final String orderBy,
        final String series,
        final String sharedAppearances,
        final String startYear,
        final String stories,
        final String title,
        final String titleStartsWith,
        final String upc,
        final APICallBack<ComicDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). Accepts a comma-separated list of ids. |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variants (alternate covers, secondary printings, director's cuts, etc.) from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). Accepts a comma-separated list of ids. |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```java
String characters = "characters";
String collaborators = "collaborators";
String creators = "creators";
DateDescriptorEnum dateDescriptor = DateDescriptorEnum.fromString("lastWeek");
String dateRange = "dateRange";
String diamondCode = "diamondCode";
String digitalId = "digitalId";
String ean = "ean";
String events = "events";
String format = "comic";
FormatTypeEnum formatType = FormatTypeEnum.fromString("collection");
String hasDigitalIssue = "true";
String isbn = "isbn";
String issn = "issn";
String issueNumber = "issueNumber";
String limit = "limit";
String modifiedSince = "modifiedSince";
String noVariants = "true";
String offset = "offset";
String orderBy = "focDate";
String series = "series";
String sharedAppearances = "sharedAppearances";
String startYear = "startYear";
String stories = "stories";
String title = "title";
String titleStartsWith = "titleStartsWith";
String upc = "upc";
// Invoking the API call with sample inputs
comics.getComicsCollectionAsync(characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, new APICallBack<ComicDataWrapper>() {
    public void onSuccess(HttpContext context, ComicDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_individual_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.ComicsController.getComicIndividualAsync") getComicIndividualAsync

> Fetches a single comic by id.


```java
void getComicIndividualAsync(
        final String comicId,
        final APICallBack<Comic> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | A single comic. |


#### Example Usage

```java
String comicId = "comicId";
// Invoking the API call with sample inputs
comics.getComicIndividualAsync(comicId, new APICallBack<Comic>() {
    public void onSuccess(HttpContext context, Comic response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Comic not found. |



### <a name="get_comics_collection_by_creator_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.ComicsController.getComicsCollectionByCreatorIdAsync") getComicsCollectionByCreatorIdAsync

> Fetches lists of comics filtered by a creator id.


```java
void getComicsCollectionByCreatorIdAsync(
        final String creatorId,
        final String characters,
        final String collaborators,
        final DateDescriptorEnum dateDescriptor,
        final String dateRange,
        final String diamondCode,
        final String digitalId,
        final String ean,
        final String events,
        final String format,
        final FormatTypeEnum formatType,
        final String hasDigitalIssue,
        final String isbn,
        final String issn,
        final String issueNumber,
        final String limit,
        final String modifiedSince,
        final String noVariants,
        final String offset,
        final String orderBy,
        final String series,
        final String sharedAppearances,
        final String startYear,
        final String stories,
        final String title,
        final String titleStartsWith,
        final String upc,
        final APICallBack<ComicDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | The creator ID. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```java
String creatorId = "creatorId";
String characters = "characters";
String collaborators = "collaborators";
DateDescriptorEnum dateDescriptor = DateDescriptorEnum.fromString("lastWeek");
String dateRange = "dateRange";
String diamondCode = "diamondCode";
String digitalId = "digitalId";
String ean = "ean";
String events = "events";
String format = "comic";
FormatTypeEnum formatType = FormatTypeEnum.fromString("collection");
String hasDigitalIssue = "true";
String isbn = "isbn";
String issn = "issn";
String issueNumber = "issueNumber";
String limit = "limit";
String modifiedSince = "modifiedSince";
String noVariants = "true";
String offset = "offset";
String orderBy = "focDate";
String series = "series";
String sharedAppearances = "sharedAppearances";
String startYear = "startYear";
String stories = "stories";
String title = "title";
String titleStartsWith = "titleStartsWith";
String upc = "upc";
// Invoking the API call with sample inputs
comics.getComicsCollectionByCreatorIdAsync(creatorId, characters, collaborators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, new APICallBack<ComicDataWrapper>() {
    public void onSuccess(HttpContext context, ComicDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_event_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.ComicsController.getComicsCollectionByEventIdAsync") getComicsCollectionByEventIdAsync

> Fetches lists of comics filtered by an event id.


```java
void getComicsCollectionByEventIdAsync(
        final String eventId,
        final String characters,
        final String collaborators,
        final String creators,
        final DateDescriptorEnum dateDescriptor,
        final String dateRange,
        final String diamondCode,
        final String digitalId,
        final String ean,
        final String events,
        final String format,
        final FormatTypeEnum formatType,
        final String hasDigitalIssue,
        final String isbn,
        final String issn,
        final String issueNumber,
        final String limit,
        final String modifiedSince,
        final String noVariants,
        final String offset,
        final String orderBy,
        final String series,
        final String sharedAppearances,
        final String startYear,
        final String stories,
        final String title,
        final String titleStartsWith,
        final String upc,
        final APICallBack<ComicDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | The event id. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```java
String eventId = "eventId";
String characters = "characters";
String collaborators = "collaborators";
String creators = "creators";
DateDescriptorEnum dateDescriptor = DateDescriptorEnum.fromString("lastWeek");
String dateRange = "dateRange";
String diamondCode = "diamondCode";
String digitalId = "digitalId";
String ean = "ean";
String events = "events";
String format = "comic";
FormatTypeEnum formatType = FormatTypeEnum.fromString("collection");
String hasDigitalIssue = "true";
String isbn = "isbn";
String issn = "issn";
String issueNumber = "issueNumber";
String limit = "limit";
String modifiedSince = "modifiedSince";
String noVariants = "true";
String offset = "offset";
String orderBy = "focDate";
String series = "series";
String sharedAppearances = "sharedAppearances";
String startYear = "startYear";
String stories = "stories";
String title = "title";
String titleStartsWith = "titleStartsWith";
String upc = "upc";
// Invoking the API call with sample inputs
comics.getComicsCollectionByEventIdAsync(eventId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, new APICallBack<ComicDataWrapper>() {
    public void onSuccess(HttpContext context, ComicDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_series_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.ComicsController.getComicsCollectionBySeriesIdAsync") getComicsCollectionBySeriesIdAsync

> Fetches lists of comics filtered by a series id.


```java
void getComicsCollectionBySeriesIdAsync(
        final String seriesId,
        final String characters,
        final String collaborators,
        final String creators,
        final DateDescriptorEnum dateDescriptor,
        final String dateRange,
        final String diamondCode,
        final String digitalId,
        final String ean,
        final String events,
        final String format,
        final FormatTypeEnum formatType,
        final String hasDigitalIssue,
        final String isbn,
        final String issn,
        final String issueNumber,
        final String limit,
        final String modifiedSince,
        final String noVariants,
        final String offset,
        final String orderBy,
        final String sharedAppearances,
        final String startYear,
        final String stories,
        final String title,
        final String titleStartsWith,
        final String upc,
        final APICallBack<ComicDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | The series ID. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```java
String seriesId = "seriesId";
String characters = "characters";
String collaborators = "collaborators";
String creators = "creators";
DateDescriptorEnum dateDescriptor = DateDescriptorEnum.fromString("lastWeek");
String dateRange = "dateRange";
String diamondCode = "diamondCode";
String digitalId = "digitalId";
String ean = "ean";
String events = "events";
String format = "comic";
FormatTypeEnum formatType = FormatTypeEnum.fromString("collection");
String hasDigitalIssue = "true";
String isbn = "isbn";
String issn = "issn";
String issueNumber = "issueNumber";
String limit = "limit";
String modifiedSince = "modifiedSince";
String noVariants = "true";
String offset = "offset";
String orderBy = "focDate";
String sharedAppearances = "sharedAppearances";
String startYear = "startYear";
String stories = "stories";
String title = "title";
String titleStartsWith = "titleStartsWith";
String upc = "upc";
// Invoking the API call with sample inputs
comics.getComicsCollectionBySeriesIdAsync(seriesId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, sharedAppearances, startYear, stories, title, titleStartsWith, upc, new APICallBack<ComicDataWrapper>() {
    public void onSuccess(HttpContext context, ComicDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_story_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.ComicsController.getComicsCollectionByStoryIdAsync") getComicsCollectionByStoryIdAsync

> Fetches lists of comics filtered by a story id.


```java
void getComicsCollectionByStoryIdAsync(
        final String storyId,
        final String characters,
        final String collaborators,
        final String creators,
        final DateDescriptorEnum dateDescriptor,
        final String dateRange,
        final String diamondCode,
        final String digitalId,
        final String ean,
        final String events,
        final String format,
        final FormatTypeEnum formatType,
        final String hasDigitalIssue,
        final String isbn,
        final String issn,
        final String issueNumber,
        final String limit,
        final String modifiedSince,
        final String noVariants,
        final String offset,
        final String orderBy,
        final String series,
        final String sharedAppearances,
        final String startYear,
        final String title,
        final String titleStartsWith,
        final String upc,
        final APICallBack<ComicDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | The story ID. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```java
String storyId = "storyId";
String characters = "characters";
String collaborators = "collaborators";
String creators = "creators";
DateDescriptorEnum dateDescriptor = DateDescriptorEnum.fromString("lastWeek");
String dateRange = "dateRange";
String diamondCode = "diamondCode";
String digitalId = "digitalId";
String ean = "ean";
String events = "events";
String format = "comic";
FormatTypeEnum formatType = FormatTypeEnum.fromString("collection");
String hasDigitalIssue = "true";
String isbn = "isbn";
String issn = "issn";
String issueNumber = "issueNumber";
String limit = "limit";
String modifiedSince = "modifiedSince";
String noVariants = "true";
String offset = "offset";
String orderBy = "focDate";
String series = "series";
String sharedAppearances = "sharedAppearances";
String startYear = "startYear";
String title = "title";
String titleStartsWith = "titleStartsWith";
String upc = "upc";
// Invoking the API call with sample inputs
comics.getComicsCollectionByStoryIdAsync(storyId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, title, titleStartsWith, upc, new APICallBack<ComicDataWrapper>() {
    public void onSuccess(HttpContext context, ComicDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="events_controller"></a>![Class: ](https://apidocs.io/img/class.png "com.marvel.gateway.controllers.EventsController") EventsController

### Get singleton instance

The singleton instance of the ``` EventsController ``` class can be accessed from the API Client.

```java
EventsController events = client.getEvents();
```

### <a name="get_character_events_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.EventsController.getCharacterEventsCollectionAsync") getCharacterEventsCollectionAsync

> Fetches lists of events filtered by a character id.


```java
void getCharacterEventsCollectionAsync(
        final String characterId,
        final String comics,
        final String creators,
        final String limit,
        final String modifiedSince,
        final String name,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final String stories,
        final APICallBack<EventDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | The character ID. |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```java
String characterId = "characterId";
String comics = "comics";
String creators = "creators";
String limit = "limit";
String modifiedSince = "modifiedSince";
String name = "name";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "name";
String series = "series";
String stories = "stories";
// Invoking the API call with sample inputs
events.getCharacterEventsCollectionAsync(characterId, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, new APICallBack<EventDataWrapper>() {
    public void onSuccess(HttpContext context, EventDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_issue_events_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.EventsController.getIssueEventsCollectionAsync") getIssueEventsCollectionAsync

> Fetches lists of events filtered by a comic id.


```java
void getIssueEventsCollectionAsync(
        final String comicId,
        final String characters,
        final String creators,
        final String limit,
        final String modifiedSince,
        final String name,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final String stories,
        final APICallBack<EventDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | The comic ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```java
String comicId = "comicId";
String characters = "characters";
String creators = "creators";
String limit = "limit";
String modifiedSince = "modifiedSince";
String name = "name";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "name";
String series = "series";
String stories = "stories";
// Invoking the API call with sample inputs
events.getIssueEventsCollectionAsync(comicId, characters, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, new APICallBack<EventDataWrapper>() {
    public void onSuccess(HttpContext context, EventDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_events_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.EventsController.getCreatorEventsCollectionAsync") getCreatorEventsCollectionAsync

> Fetches lists of events filtered by a creator id.


```java
void getCreatorEventsCollectionAsync(
        final String creatorId,
        final String characters,
        final String comics,
        final String limit,
        final String modifiedSince,
        final String name,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final String stories,
        final APICallBack<EventDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | The creator ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```java
String creatorId = "creatorId";
String characters = "characters";
String comics = "comics";
String limit = "limit";
String modifiedSince = "modifiedSince";
String name = "name";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "name";
String series = "series";
String stories = "stories";
// Invoking the API call with sample inputs
events.getCreatorEventsCollectionAsync(creatorId, characters, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, new APICallBack<EventDataWrapper>() {
    public void onSuccess(HttpContext context, EventDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_individual_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.EventsController.getEventIndividualAsync") getEventIndividualAsync

> Fetches a single event by id.


```java
void getEventIndividualAsync(
        final String eventId,
        final APICallBack<Event> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | A single event. |


#### Example Usage

```java
String eventId = "eventId";
// Invoking the API call with sample inputs
events.getEventIndividualAsync(eventId, new APICallBack<Event>() {
    public void onSuccess(HttpContext context, Event response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Event not found. |



### <a name="get_events_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.EventsController.getEventsCollectionAsync") getEventsCollectionAsync

> Fetches lists of events.


```java
void getEventsCollectionAsync(
        final String characters,
        final String comics,
        final String creators,
        final String limit,
        final String modifiedSince,
        final String name,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final String stories,
        final APICallBack<EventDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only events which match the specified name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which take place in the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```java
String characters = "characters";
String comics = "comics";
String creators = "creators";
String limit = "limit";
String modifiedSince = "modifiedSince";
String name = "name";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "name";
String series = "series";
String stories = "stories";
// Invoking the API call with sample inputs
events.getEventsCollectionAsync(characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, new APICallBack<EventDataWrapper>() {
    public void onSuccess(HttpContext context, EventDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_events_collection_by_series_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.EventsController.getEventsCollectionBySeriesIdAsync") getEventsCollectionBySeriesIdAsync

> Fetches lists of events filtered by a series id.


```java
void getEventsCollectionBySeriesIdAsync(
        final String seriesId,
        final String characters,
        final String comics,
        final String creators,
        final String limit,
        final String modifiedSince,
        final String name,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String stories,
        final APICallBack<EventDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | The series ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```java
String seriesId = "seriesId";
String characters = "characters";
String comics = "comics";
String creators = "creators";
String limit = "limit";
String modifiedSince = "modifiedSince";
String name = "name";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "name";
String stories = "stories";
// Invoking the API call with sample inputs
events.getEventsCollectionBySeriesIdAsync(seriesId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories, new APICallBack<EventDataWrapper>() {
    public void onSuccess(HttpContext context, EventDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_events_collection_by_story_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.EventsController.getEventsCollectionByStoryIdAsync") getEventsCollectionByStoryIdAsync

> Fetches lists of events filtered by a story id.


```java
void getEventsCollectionByStoryIdAsync(
        final String storyId,
        final String characters,
        final String comics,
        final String creators,
        final String limit,
        final String modifiedSince,
        final String name,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final APICallBack<EventDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | The story ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```java
String storyId = "storyId";
String characters = "characters";
String comics = "comics";
String creators = "creators";
String limit = "limit";
String modifiedSince = "modifiedSince";
String name = "name";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "name";
String series = "series";
// Invoking the API call with sample inputs
events.getEventsCollectionByStoryIdAsync(storyId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, new APICallBack<EventDataWrapper>() {
    public void onSuccess(HttpContext context, EventDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="series_controller"></a>![Class: ](https://apidocs.io/img/class.png "com.marvel.gateway.controllers.SeriesController") SeriesController

### Get singleton instance

The singleton instance of the ``` SeriesController ``` class can be accessed from the API Client.

```java
SeriesController series = client.getSeries();
```

### <a name="get_character_series_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.SeriesController.getCharacterSeriesCollectionAsync") getCharacterSeriesCollectionAsync

> Fetches lists of series filtered by a character id.


```java
void getCharacterSeriesCollectionAsync(
        final String characterId,
        final String comics,
        final String contains,
        final String creators,
        final String events,
        final String limit,
        final String modifiedSince,
        final String offset,
        final String orderBy,
        final String seriesType,
        final String startYear,
        final String stories,
        final String title,
        final String titleStartsWith,
        final APICallBack<SeriesDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | The character ID |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| creators |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| seriesType |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| startYear |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Filter by series title. |
| titleStartsWith |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```java
String characterId = "characterId";
String comics = "comics";
String contains = "comic";
String creators = "creators";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String offset = "offset";
String orderBy = "title";
String seriesType = "collection";
String startYear = "startYear";
String stories = "stories";
String title = "title";
String titleStartsWith = "titleStartsWith";
// Invoking the API call with sample inputs
series.getCharacterSeriesCollectionAsync(characterId, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, new APICallBack<SeriesDataWrapper>() {
    public void onSuccess(HttpContext context, SeriesDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_individual_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.SeriesController.getSeriesIndividualAsync") getSeriesIndividualAsync

> Fetches a single comic series by id.


```java
void getSeriesIndividualAsync(
        final String seriesId,
        final APICallBack<Series> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | Filter by series title. |


#### Example Usage

```java
String seriesId = "seriesId";
// Invoking the API call with sample inputs
series.getSeriesIndividualAsync(seriesId, new APICallBack<Series>() {
    public void onSuccess(HttpContext context, Series response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Series not found. |



### <a name="get_creator_series_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.SeriesController.getCreatorSeriesCollectionAsync") getCreatorSeriesCollectionAsync

> Fetches lists of series filtered by a creator id.


```java
void getCreatorSeriesCollectionAsync(
        final String creatorId,
        final String characters,
        final String comics,
        final String contains,
        final String events,
        final String limit,
        final String modifiedSince,
        final String offset,
        final String orderBy,
        final String seriesType,
        final String startYear,
        final String stories,
        final String title,
        final String titleStartsWith,
        final APICallBack<SeriesDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | The creator ID. |
| characters |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| events |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| seriesType |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| startYear |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Filter by series title. |
| titleStartsWith |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```java
String creatorId = "creatorId";
String characters = "characters";
String comics = "comics";
String contains = "comic";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String offset = "offset";
String orderBy = "title";
String seriesType = "collection";
String startYear = "startYear";
String stories = "stories";
String title = "title";
String titleStartsWith = "titleStartsWith";
// Invoking the API call with sample inputs
series.getCreatorSeriesCollectionAsync(creatorId, characters, comics, contains, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, new APICallBack<SeriesDataWrapper>() {
    public void onSuccess(HttpContext context, SeriesDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_series_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.SeriesController.getEventSeriesCollectionAsync") getEventSeriesCollectionAsync

> Fetches lists of series filtered by an event id.


```java
void getEventSeriesCollectionAsync(
        final String eventId,
        final String characters,
        final String comics,
        final String contains,
        final String creators,
        final String limit,
        final String modifiedSince,
        final String offset,
        final String orderBy,
        final String seriesType,
        final String startYear,
        final String stories,
        final String title,
        final String titleStartsWith,
        final APICallBack<SeriesDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | The event ID. |
| characters |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| creators |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| seriesType |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| startYear |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Filter by series title. |
| titleStartsWith |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```java
String eventId = "eventId";
String characters = "characters";
String comics = "comics";
String contains = "comic";
String creators = "creators";
String limit = "limit";
String modifiedSince = "modifiedSince";
String offset = "offset";
String orderBy = "title";
String seriesType = "collection";
String startYear = "startYear";
String stories = "stories";
String title = "title";
String titleStartsWith = "titleStartsWith";
// Invoking the API call with sample inputs
series.getEventSeriesCollectionAsync(eventId, characters, comics, contains, creators, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, new APICallBack<SeriesDataWrapper>() {
    public void onSuccess(HttpContext context, SeriesDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.SeriesController.getSeriesCollectionAsync") getSeriesCollectionAsync

> Fetches lists of series.


```java
void getSeriesCollectionAsync(
        final String characters,
        final String comics,
        final String contains,
        final String creators,
        final String events,
        final String limit,
        final String modifiedSince,
        final String offset,
        final String orderBy,
        final String seriesType,
        final String startYear,
        final String stories,
        final String title,
        final String titleStartsWith,
        final APICallBack<SeriesDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characters |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| creators |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| seriesType |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| startYear |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only series matching the specified title. |
| titleStartsWith |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```java
String characters = "characters";
String comics = "comics";
String contains = "comic";
String creators = "creators";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String offset = "offset";
String orderBy = "title";
String seriesType = "collection";
String startYear = "startYear";
String stories = "stories";
String title = "title";
String titleStartsWith = "titleStartsWith";
// Invoking the API call with sample inputs
series.getSeriesCollectionAsync(characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, new APICallBack<SeriesDataWrapper>() {
    public void onSuccess(HttpContext context, SeriesDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_series_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.SeriesController.getStorySeriesCollectionAsync") getStorySeriesCollectionAsync

> Fetches lists of series filtered by a story id.


```java
void getStorySeriesCollectionAsync(
        final String storyId,
        final String characters,
        final String comics,
        final String contains,
        final String creators,
        final String events,
        final String limit,
        final String modifiedSince,
        final String offset,
        final String orderBy,
        final String seriesType,
        final String startYear,
        final String title,
        final String titleStartsWith,
        final APICallBack<SeriesDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | The story ID. |
| characters |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| creators |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| seriesType |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| startYear |  ``` Optional ```  | Return only series matching the specified start year. |
| title |  ``` Optional ```  | Filter by series title. |
| titleStartsWith |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```java
String storyId = "storyId";
String characters = "characters";
String comics = "comics";
String contains = "comic";
String creators = "creators";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String offset = "offset";
String orderBy = "title";
String seriesType = "collection";
String startYear = "startYear";
String title = "title";
String titleStartsWith = "titleStartsWith";
// Invoking the API call with sample inputs
series.getStorySeriesCollectionAsync(storyId, characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, title, titleStartsWith, new APICallBack<SeriesDataWrapper>() {
    public void onSuccess(HttpContext context, SeriesDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="stories_controller"></a>![Class: ](https://apidocs.io/img/class.png "com.marvel.gateway.controllers.StoriesController") StoriesController

### Get singleton instance

The singleton instance of the ``` StoriesController ``` class can be accessed from the API Client.

```java
StoriesController stories = client.getStories();
```

### <a name="get_character_story_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.StoriesController.getCharacterStoryCollectionAsync") getCharacterStoryCollectionAsync

> Fetches lists of stories filtered by a character id.


```java
void getCharacterStoryCollectionAsync(
        final String characterId,
        final String comics,
        final String creators,
        final String events,
        final String limit,
        final String modifiedSince,
        final String offset,
        final String orderBy,
        final String series,
        final APICallBack<StoryDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | The character ID. |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```java
String characterId = "characterId";
String comics = "comics";
String creators = "creators";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String offset = "offset";
String orderBy = "id";
String series = "series";
// Invoking the API call with sample inputs
stories.getCharacterStoryCollectionAsync(characterId, comics, creators, events, limit, modifiedSince, offset, orderBy, series, new APICallBack<StoryDataWrapper>() {
    public void onSuccess(HttpContext context, StoryDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_story_collection_by_comic_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.StoriesController.getComicStoryCollectionByComicIdAsync") getComicStoryCollectionByComicIdAsync

> Fetches lists of stories filtered by a comic id.


```java
void getComicStoryCollectionByComicIdAsync(
        final String comicId,
        final String characters,
        final String creators,
        final String events,
        final String limit,
        final String modifiedSince,
        final String offset,
        final String orderBy,
        final String series,
        final APICallBack<StoryDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | The comic ID. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```java
String comicId = "comicId";
String characters = "characters";
String creators = "creators";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String offset = "offset";
String orderBy = "id";
String series = "series";
// Invoking the API call with sample inputs
stories.getComicStoryCollectionByComicIdAsync(comicId, characters, creators, events, limit, modifiedSince, offset, orderBy, series, new APICallBack<StoryDataWrapper>() {
    public void onSuccess(HttpContext context, StoryDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_story_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.StoriesController.getCreatorStoryCollectionAsync") getCreatorStoryCollectionAsync

> Fetches lists of stories filtered by a creator id.


```java
void getCreatorStoryCollectionAsync(
        final String creatorId,
        final String characters,
        final String comics,
        final String events,
        final String limit,
        final String modifiedSince,
        final String offset,
        final String orderBy,
        final String series,
        final APICallBack<StoryDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | The ID of the creator. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```java
String creatorId = "creatorId";
String characters = "characters";
String comics = "comics";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String offset = "offset";
String orderBy = "id";
String series = "series";
// Invoking the API call with sample inputs
stories.getCreatorStoryCollectionAsync(creatorId, characters, comics, events, limit, modifiedSince, offset, orderBy, series, new APICallBack<StoryDataWrapper>() {
    public void onSuccess(HttpContext context, StoryDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_individual_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.StoriesController.getStoryIndividualAsync") getStoryIndividualAsync

> Fetches a single comic story by id.


```java
void getStoryIndividualAsync(
        final String storyId,
        final APICallBack<Story> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | Filter by story id. |


#### Example Usage

```java
String storyId = "storyId";
// Invoking the API call with sample inputs
stories.getStoryIndividualAsync(storyId, new APICallBack<Story>() {
    public void onSuccess(HttpContext context, Story response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Story not found. |



### <a name="get_event_story_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.StoriesController.getEventStoryCollectionAsync") getEventStoryCollectionAsync

> Fetches lists of stories filtered by an event id.


```java
void getEventStoryCollectionAsync(
        final String eventId,
        final String characters,
        final String comics,
        final String creators,
        final String limit,
        final String modifiedSince,
        final String offset,
        final String orderBy,
        final String series,
        final APICallBack<StoryDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | The ID of the event. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```java
String eventId = "eventId";
String characters = "characters";
String comics = "comics";
String creators = "creators";
String limit = "limit";
String modifiedSince = "modifiedSince";
String offset = "offset";
String orderBy = "id";
String series = "series";
// Invoking the API call with sample inputs
stories.getEventStoryCollectionAsync(eventId, characters, comics, creators, limit, modifiedSince, offset, orderBy, series, new APICallBack<StoryDataWrapper>() {
    public void onSuccess(HttpContext context, StoryDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_story_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.StoriesController.getSeriesStoryCollectionAsync") getSeriesStoryCollectionAsync

> Fetches lists of stories filtered by a series id.


```java
void getSeriesStoryCollectionAsync(
        final String seriesId,
        final String characters,
        final String comics,
        final String creators,
        final String events,
        final String limit,
        final String modifiedSince,
        final String offset,
        final String orderBy,
        final APICallBack<StoryDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | The series ID. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |


#### Example Usage

```java
String seriesId = "seriesId";
String characters = "characters";
String comics = "comics";
String creators = "creators";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String offset = "offset";
String orderBy = "id";
// Invoking the API call with sample inputs
stories.getSeriesStoryCollectionAsync(seriesId, characters, comics, creators, events, limit, modifiedSince, offset, orderBy, new APICallBack<StoryDataWrapper>() {
    public void onSuccess(HttpContext context, StoryDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.StoriesController.getStoryCollectionAsync") getStoryCollectionAsync

> Fetches lists of stories.


```java
void getStoryCollectionAsync(
        final String characters,
        final String comics,
        final String creators,
        final String events,
        final String limit,
        final String modifiedSince,
        final String offset,
        final String orderBy,
        final String series,
        final APICallBack<StoryDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```java
String characters = "characters";
String comics = "comics";
String creators = "creators";
String events = "events";
String limit = "limit";
String modifiedSince = "modifiedSince";
String offset = "offset";
String orderBy = "id";
String series = "series";
// Invoking the API call with sample inputs
stories.getStoryCollectionAsync(characters, comics, creators, events, limit, modifiedSince, offset, orderBy, series, new APICallBack<StoryDataWrapper>() {
    public void onSuccess(HttpContext context, StoryDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="creators_controller"></a>![Class: ](https://apidocs.io/img/class.png "com.marvel.gateway.controllers.CreatorsController") CreatorsController

### Get singleton instance

The singleton instance of the ``` CreatorsController ``` class can be accessed from the API Client.

```java
CreatorsController creators = client.getCreators();
```

### <a name="get_creator_collection_by_comic_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CreatorsController.getCreatorCollectionByComicIdAsync") getCreatorCollectionByComicIdAsync

> Fetches lists of creators filtered by a comic id.


```java
void getCreatorCollectionByComicIdAsync(
        final String comicId,
        final String comics,
        final String firstName,
        final String firstNameStartsWith,
        final String lastName,
        final String lastNameStartsWith,
        final String limit,
        final String middleName,
        final String middleNameStartsWith,
        final String modifiedSince,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final String stories,
        final String suffix,
        final APICallBack<CreatorDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | The comic id. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| firstName |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| firstNameStartsWith |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| lastName |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| lastNameStartsWith |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middleName |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middleNameStartsWith |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modifiedSince |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| nameStartsWith |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```java
String comicId = "comicId";
String comics = "comics";
String firstName = "firstName";
String firstNameStartsWith = "firstNameStartsWith";
String lastName = "lastName";
String lastNameStartsWith = "lastNameStartsWith";
String limit = "limit";
String middleName = "middleName";
String middleNameStartsWith = "middleNameStartsWith";
String modifiedSince = "modifiedSince";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "lastName";
String series = "series";
String stories = "stories";
String suffix = "suffix";
// Invoking the API call with sample inputs
creators.getCreatorCollectionByComicIdAsync(comicId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix, new APICallBack<CreatorDataWrapper>() {
    public void onSuccess(HttpContext context, CreatorDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CreatorsController.getCreatorCollectionAsync") getCreatorCollectionAsync

> Fetches lists of creators.


```java
void getCreatorCollectionAsync(
        final String comics,
        final String events,
        final String firstName,
        final String firstNameStartsWith,
        final String lastName,
        final String lastNameStartsWith,
        final String limit,
        final String middleName,
        final String middleNameStartsWith,
        final String modifiedSince,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final String stories,
        final String suffix,
        final APICallBack<CreatorDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). |
| firstName |  ``` Optional ```  | Filter by creator first name (e.g. Brian). |
| firstNameStartsWith |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| lastName |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| lastNameStartsWith |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middleName |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middleNameStartsWith |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modifiedSince |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| nameStartsWith |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```java
String comics = "comics";
String events = "events";
String firstName = "firstName";
String firstNameStartsWith = "firstNameStartsWith";
String lastName = "lastName";
String lastNameStartsWith = "lastNameStartsWith";
String limit = "limit";
String middleName = "middleName";
String middleNameStartsWith = "middleNameStartsWith";
String modifiedSince = "modifiedSince";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "lastName";
String series = "series";
String stories = "stories";
String suffix = "suffix";
// Invoking the API call with sample inputs
creators.getCreatorCollectionAsync(comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix, new APICallBack<CreatorDataWrapper>() {
    public void onSuccess(HttpContext context, CreatorDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_individual_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CreatorsController.getCreatorIndividualAsync") getCreatorIndividualAsync

> Fetches a single creator by id.


```java
void getCreatorIndividualAsync(
        final String creatorId,
        final APICallBack<Creator> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | A single creator id. |


#### Example Usage

```java
String creatorId = "creatorId";
// Invoking the API call with sample inputs
creators.getCreatorIndividualAsync(creatorId, new APICallBack<Creator>() {
    public void onSuccess(HttpContext context, Creator response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Creator not found. |



### <a name="get_creator_collection_by_event_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CreatorsController.getCreatorCollectionByEventIdAsync") getCreatorCollectionByEventIdAsync

> Fetches lists of creators filtered by an event id.


```java
void getCreatorCollectionByEventIdAsync(
        final String eventId,
        final String comics,
        final String firstName,
        final String firstNameStartsWith,
        final String lastName,
        final String lastNameStartsWith,
        final String limit,
        final String middleName,
        final String middleNameStartsWith,
        final String modifiedSince,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final String stories,
        final String suffix,
        final APICallBack<CreatorDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | The event ID. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| firstName |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| firstNameStartsWith |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| lastName |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| lastNameStartsWith |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middleName |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middleNameStartsWith |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modifiedSince |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| nameStartsWith |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```java
String eventId = "eventId";
String comics = "comics";
String firstName = "firstName";
String firstNameStartsWith = "firstNameStartsWith";
String lastName = "lastName";
String lastNameStartsWith = "lastNameStartsWith";
String limit = "limit";
String middleName = "middleName";
String middleNameStartsWith = "middleNameStartsWith";
String modifiedSince = "modifiedSince";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "lastName";
String series = "series";
String stories = "stories";
String suffix = "suffix";
// Invoking the API call with sample inputs
creators.getCreatorCollectionByEventIdAsync(eventId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix, new APICallBack<CreatorDataWrapper>() {
    public void onSuccess(HttpContext context, CreatorDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection_by_series_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CreatorsController.getCreatorCollectionBySeriesIdAsync") getCreatorCollectionBySeriesIdAsync

> Fetches lists of creators filtered by a series id.


```java
void getCreatorCollectionBySeriesIdAsync(
        final String seriesId,
        final String comics,
        final String events,
        final String firstName,
        final String firstNameStartsWith,
        final String lastName,
        final String lastNameStartsWith,
        final String limit,
        final String middleName,
        final String middleNameStartsWith,
        final String modifiedSince,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String stories,
        final String suffix,
        final APICallBack<CreatorDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | The series ID. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). |
| firstName |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| firstNameStartsWith |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| lastName |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| lastNameStartsWith |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middleName |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middleNameStartsWith |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modifiedSince |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| nameStartsWith |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```java
String seriesId = "seriesId";
String comics = "comics";
String events = "events";
String firstName = "firstName";
String firstNameStartsWith = "firstNameStartsWith";
String lastName = "lastName";
String lastNameStartsWith = "lastNameStartsWith";
String limit = "limit";
String middleName = "middleName";
String middleNameStartsWith = "middleNameStartsWith";
String modifiedSince = "modifiedSince";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "lastName";
String stories = "stories";
String suffix = "suffix";
// Invoking the API call with sample inputs
creators.getCreatorCollectionBySeriesIdAsync(seriesId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, stories, suffix, new APICallBack<CreatorDataWrapper>() {
    public void onSuccess(HttpContext context, CreatorDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection_by_story_id_async"></a>![Method: ](https://apidocs.io/img/method.png "com.marvel.gateway.controllers.CreatorsController.getCreatorCollectionByStoryIdAsync") getCreatorCollectionByStoryIdAsync

> Fetches lists of creators filtered by a story id.


```java
void getCreatorCollectionByStoryIdAsync(
        final String storyId,
        final String comics,
        final String events,
        final String firstName,
        final String firstNameStartsWith,
        final String lastName,
        final String lastNameStartsWith,
        final String limit,
        final String middleName,
        final String middleNameStartsWith,
        final String modifiedSince,
        final String nameStartsWith,
        final String offset,
        final String orderBy,
        final String series,
        final String suffix,
        final APICallBack<CreatorDataWrapper> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | The story ID. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). |
| firstName |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| firstNameStartsWith |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| lastName |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| lastNameStartsWith |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middleName |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middleNameStartsWith |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modifiedSince |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| nameStartsWith |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```java
String storyId = "storyId";
String comics = "comics";
String events = "events";
String firstName = "firstName";
String firstNameStartsWith = "firstNameStartsWith";
String lastName = "lastName";
String lastNameStartsWith = "lastNameStartsWith";
String limit = "limit";
String middleName = "middleName";
String middleNameStartsWith = "middleNameStartsWith";
String modifiedSince = "modifiedSince";
String nameStartsWith = "nameStartsWith";
String offset = "offset";
String orderBy = "lastName";
String series = "series";
String suffix = "suffix";
// Invoking the API call with sample inputs
creators.getCreatorCollectionByStoryIdAsync(storyId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, suffix, new APICallBack<CreatorDataWrapper>() {
    public void onSuccess(HttpContext context, CreatorDataWrapper response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)



