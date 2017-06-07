# Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (MarvelComicsPCL.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=MarvelComics-CSharp&workspaceName=MarvelComicsPCL&projectName=MarvelComics.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the MarvelComicsPCL library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=MarvelComics-CSharp&workspaceName=MarvelComicsPCL&projectName=MarvelComics.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=MarvelComics-CSharp&workspaceName=MarvelComicsPCL&projectName=MarvelComics.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=MarvelComics-CSharp&workspaceName=MarvelComicsPCL&projectName=MarvelComics.PCL)

### 3. Add reference of the library project

In order to use the MarvelComicsPCL library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=MarvelComics-CSharp&workspaceName=MarvelComicsPCL&projectName=MarvelComics.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` MarvelComics.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```MarvelComics.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=MarvelComics-CSharp&workspaceName=MarvelComicsPCL&projectName=MarvelComics.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=MarvelComics-CSharp&workspaceName=MarvelComicsPCL&projectName=MarvelComics.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| referer | TODO: add a description |
| apikey | TODO: add a description |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string referer = "*.marvel.com";
string apikey = "apikey";

MarvelComicsPCLClient client = new MarvelComicsPCLClient(referer, apikey);
```

# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [CharactersController](#characters_controller)
* [ComicsController](#comics_controller)
* [EventsController](#events_controller)
* [SeriesController](#series_controller)
* [StoriesController](#stories_controller)
* [CreatorsController](#creators_controller)

## <a name="characters_controller"></a>![Class: ](https://apidocs.io/img/class.png "MarvelComics.PCL.Controllers.CharactersController") CharactersController

### Get singleton instance

The singleton instance of the ``` CharactersController ``` class can be accessed from the API Client.

```csharp
CharactersController characters = client.Characters;
```

### <a name="get_character_individual"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CharactersController.GetCharacterIndividual") GetCharacterIndividual

> Fetches a single character by id.


```csharp
Task<Models.Character> GetCharacterIndividual(string characterId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | A single character id. |


#### Example Usage

```csharp
string characterId = "characterId";

Models.Character result = await characters.GetCharacterIndividual(characterId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Character not found. |


### <a name="get_character_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CharactersController.GetCharacterCollection") GetCharacterCollection

> Fetches lists of characters.


```csharp
Task<Models.CharacterDataWrapper> GetCharacterCollection(
        string comics = null,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string name = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "name",
        string series = null,
        string stories = null)
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

```csharp
string comics = "comics";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string name = "name";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "name";
string series = "series";
string stories = "stories";

Models.CharacterDataWrapper result = await characters.GetCharacterCollection(comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_comic_character_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CharactersController.GetComicCharacterCollection") GetComicCharacterCollection

> Fetches lists of characters filtered by a comic id.


```csharp
Task<Models.CharacterDataWrapper> GetComicCharacterCollection(
        string comicId,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string name = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "name",
        string series = null,
        string stories = null)
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

```csharp
string comicId = "comicId";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string name = "name";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "name";
string series = "series";
string stories = "stories";

Models.CharacterDataWrapper result = await characters.GetComicCharacterCollection(comicId, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_event_character_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CharactersController.GetEventCharacterCollection") GetEventCharacterCollection

> Fetches lists of characters filtered by an event id.


```csharp
Task<Models.CharacterDataWrapper> GetEventCharacterCollection(
        string eventId,
        string comics = null,
        string limit = null,
        string modifiedSince = null,
        string name = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "name",
        string series = null,
        string stories = null)
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

```csharp
string eventId = "eventId";
string comics = "comics";
string limit = "limit";
string modifiedSince = "modifiedSince";
string name = "name";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "name";
string series = "series";
string stories = "stories";

Models.CharacterDataWrapper result = await characters.GetEventCharacterCollection(eventId, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_series_character_wrapper"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CharactersController.GetSeriesCharacterWrapper") GetSeriesCharacterWrapper

> Fetches lists of characters filtered by a series id.


```csharp
Task<Models.CharacterDataWrapper> GetSeriesCharacterWrapper(
        string seriesId,
        string comics = null,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string name = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "name",
        string stories = null)
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

```csharp
string seriesId = "seriesId";
string comics = "comics";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string name = "name";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "name";
string stories = "stories";

Models.CharacterDataWrapper result = await characters.GetSeriesCharacterWrapper(seriesId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_character_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CharactersController.GetCharacterCollectionByStoryId") GetCharacterCollectionByStoryId

> Fetches lists of characters filtered by a story id.


```csharp
Task<Models.CharacterDataWrapper> GetCharacterCollectionByStoryId(
        string storyId,
        string comics = null,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string name = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "name",
        string series = null)
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

```csharp
string storyId = "storyId";
string comics = "comics";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string name = "name";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "name";
string series = "series";

Models.CharacterDataWrapper result = await characters.GetCharacterCollectionByStoryId(storyId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


[Back to List of Controllers](#list_of_controllers)

## <a name="comics_controller"></a>![Class: ](https://apidocs.io/img/class.png "MarvelComics.PCL.Controllers.ComicsController") ComicsController

### Get singleton instance

The singleton instance of the ``` ComicsController ``` class can be accessed from the API Client.

```csharp
ComicsController comics = client.Comics;
```

### <a name="get_comics_character_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.ComicsController.GetComicsCharacterCollection") GetComicsCharacterCollection

> Fetches lists of comics filtered by a character id.


```csharp
Task<Models.ComicDataWrapper> GetComicsCharacterCollection(
        string characterId,
        string collaborators = null,
        string creators = null,
        Models.DateDescriptorEnum? dateDescriptor = null,
        string dateRange = null,
        string diamondCode = null,
        string digitalId = null,
        string ean = null,
        string events = null,
        string format = "comic",
        Models.FormatTypeEnum? formatType = null,
        string hasDigitalIssue = "true",
        string isbn = null,
        string issn = null,
        string issueNumber = null,
        string limit = null,
        string modifiedSince = null,
        string noVariants = "true",
        string offset = null,
        string orderBy = "focDate",
        string series = null,
        string sharedAppearances = null,
        string startYear = null,
        string stories = null,
        string title = null,
        string titleStartsWith = null,
        string upc = null)
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

```csharp
string characterId = "characterId";
string collaborators = "collaborators";
string creators = "creators";
var dateDescriptor = Models.DateDescriptorEnum?Helper.ParseString("lastWeek");
string dateRange = "dateRange";
string diamondCode = "diamondCode";
string digitalId = "digitalId";
string ean = "ean";
string events = "events";
string format = "comic";
var formatType = Models.FormatTypeEnum?Helper.ParseString("collection");
string hasDigitalIssue = "true";
string isbn = "isbn";
string issn = "issn";
string issueNumber = "issueNumber";
string limit = "limit";
string modifiedSince = "modifiedSince";
string noVariants = "true";
string offset = "offset";
string orderBy = "focDate";
string series = "series";
string sharedAppearances = "sharedAppearances";
string startYear = "startYear";
string stories = "stories";
string title = "title";
string titleStartsWith = "titleStartsWith";
string upc = "upc";

Models.ComicDataWrapper result = await comics.GetComicsCharacterCollection(characterId, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_comics_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.ComicsController.GetComicsCollection") GetComicsCollection

> Fetches lists of comics.


```csharp
Task<Models.ComicDataWrapper> GetComicsCollection(
        string characters = null,
        string collaborators = null,
        string creators = null,
        Models.DateDescriptorEnum? dateDescriptor = null,
        string dateRange = null,
        string diamondCode = null,
        string digitalId = null,
        string ean = null,
        string events = null,
        string format = "comic",
        Models.FormatTypeEnum? formatType = null,
        string hasDigitalIssue = "true",
        string isbn = null,
        string issn = null,
        string issueNumber = null,
        string limit = null,
        string modifiedSince = null,
        string noVariants = "true",
        string offset = null,
        string orderBy = "focDate",
        string series = null,
        string sharedAppearances = null,
        string startYear = null,
        string stories = null,
        string title = null,
        string titleStartsWith = null,
        string upc = null)
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

```csharp
string characters = "characters";
string collaborators = "collaborators";
string creators = "creators";
var dateDescriptor = Models.DateDescriptorEnum?Helper.ParseString("lastWeek");
string dateRange = "dateRange";
string diamondCode = "diamondCode";
string digitalId = "digitalId";
string ean = "ean";
string events = "events";
string format = "comic";
var formatType = Models.FormatTypeEnum?Helper.ParseString("collection");
string hasDigitalIssue = "true";
string isbn = "isbn";
string issn = "issn";
string issueNumber = "issueNumber";
string limit = "limit";
string modifiedSince = "modifiedSince";
string noVariants = "true";
string offset = "offset";
string orderBy = "focDate";
string series = "series";
string sharedAppearances = "sharedAppearances";
string startYear = "startYear";
string stories = "stories";
string title = "title";
string titleStartsWith = "titleStartsWith";
string upc = "upc";

Models.ComicDataWrapper result = await comics.GetComicsCollection(characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_comic_individual"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.ComicsController.GetComicIndividual") GetComicIndividual

> Fetches a single comic by id.


```csharp
Task<Models.Comic> GetComicIndividual(string comicId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | A single comic. |


#### Example Usage

```csharp
string comicId = "comicId";

Models.Comic result = await comics.GetComicIndividual(comicId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Comic not found. |


### <a name="get_comics_collection_by_creator_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.ComicsController.GetComicsCollectionByCreatorId") GetComicsCollectionByCreatorId

> Fetches lists of comics filtered by a creator id.


```csharp
Task<Models.ComicDataWrapper> GetComicsCollectionByCreatorId(
        string creatorId,
        string characters = null,
        string collaborators = null,
        Models.DateDescriptorEnum? dateDescriptor = null,
        string dateRange = null,
        string diamondCode = null,
        string digitalId = null,
        string ean = null,
        string events = null,
        string format = "comic",
        Models.FormatTypeEnum? formatType = null,
        string hasDigitalIssue = "true",
        string isbn = null,
        string issn = null,
        string issueNumber = null,
        string limit = null,
        string modifiedSince = null,
        string noVariants = "true",
        string offset = null,
        string orderBy = "focDate",
        string series = null,
        string sharedAppearances = null,
        string startYear = null,
        string stories = null,
        string title = null,
        string titleStartsWith = null,
        string upc = null)
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

```csharp
string creatorId = "creatorId";
string characters = "characters";
string collaborators = "collaborators";
var dateDescriptor = Models.DateDescriptorEnum?Helper.ParseString("lastWeek");
string dateRange = "dateRange";
string diamondCode = "diamondCode";
string digitalId = "digitalId";
string ean = "ean";
string events = "events";
string format = "comic";
var formatType = Models.FormatTypeEnum?Helper.ParseString("collection");
string hasDigitalIssue = "true";
string isbn = "isbn";
string issn = "issn";
string issueNumber = "issueNumber";
string limit = "limit";
string modifiedSince = "modifiedSince";
string noVariants = "true";
string offset = "offset";
string orderBy = "focDate";
string series = "series";
string sharedAppearances = "sharedAppearances";
string startYear = "startYear";
string stories = "stories";
string title = "title";
string titleStartsWith = "titleStartsWith";
string upc = "upc";

Models.ComicDataWrapper result = await comics.GetComicsCollectionByCreatorId(creatorId, characters, collaborators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_comics_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.ComicsController.GetComicsCollectionByEventId") GetComicsCollectionByEventId

> Fetches lists of comics filtered by an event id.


```csharp
Task<Models.ComicDataWrapper> GetComicsCollectionByEventId(
        string eventId,
        string characters = null,
        string collaborators = null,
        string creators = null,
        Models.DateDescriptorEnum? dateDescriptor = null,
        string dateRange = null,
        string diamondCode = null,
        string digitalId = null,
        string ean = null,
        string events = null,
        string format = "comic",
        Models.FormatTypeEnum? formatType = null,
        string hasDigitalIssue = "true",
        string isbn = null,
        string issn = null,
        string issueNumber = null,
        string limit = null,
        string modifiedSince = null,
        string noVariants = "true",
        string offset = null,
        string orderBy = "focDate",
        string series = null,
        string sharedAppearances = null,
        string startYear = null,
        string stories = null,
        string title = null,
        string titleStartsWith = null,
        string upc = null)
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

```csharp
string eventId = "eventId";
string characters = "characters";
string collaborators = "collaborators";
string creators = "creators";
var dateDescriptor = Models.DateDescriptorEnum?Helper.ParseString("lastWeek");
string dateRange = "dateRange";
string diamondCode = "diamondCode";
string digitalId = "digitalId";
string ean = "ean";
string events = "events";
string format = "comic";
var formatType = Models.FormatTypeEnum?Helper.ParseString("collection");
string hasDigitalIssue = "true";
string isbn = "isbn";
string issn = "issn";
string issueNumber = "issueNumber";
string limit = "limit";
string modifiedSince = "modifiedSince";
string noVariants = "true";
string offset = "offset";
string orderBy = "focDate";
string series = "series";
string sharedAppearances = "sharedAppearances";
string startYear = "startYear";
string stories = "stories";
string title = "title";
string titleStartsWith = "titleStartsWith";
string upc = "upc";

Models.ComicDataWrapper result = await comics.GetComicsCollectionByEventId(eventId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_comics_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.ComicsController.GetComicsCollectionBySeriesId") GetComicsCollectionBySeriesId

> Fetches lists of comics filtered by a series id.


```csharp
Task<Models.ComicDataWrapper> GetComicsCollectionBySeriesId(
        string seriesId,
        string characters = null,
        string collaborators = null,
        string creators = null,
        Models.DateDescriptorEnum? dateDescriptor = null,
        string dateRange = null,
        string diamondCode = null,
        string digitalId = null,
        string ean = null,
        string events = null,
        string format = "comic",
        Models.FormatTypeEnum? formatType = null,
        string hasDigitalIssue = "true",
        string isbn = null,
        string issn = null,
        string issueNumber = null,
        string limit = null,
        string modifiedSince = null,
        string noVariants = "true",
        string offset = null,
        string orderBy = "focDate",
        string sharedAppearances = null,
        string startYear = null,
        string stories = null,
        string title = null,
        string titleStartsWith = null,
        string upc = null)
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

```csharp
string seriesId = "seriesId";
string characters = "characters";
string collaborators = "collaborators";
string creators = "creators";
var dateDescriptor = Models.DateDescriptorEnum?Helper.ParseString("lastWeek");
string dateRange = "dateRange";
string diamondCode = "diamondCode";
string digitalId = "digitalId";
string ean = "ean";
string events = "events";
string format = "comic";
var formatType = Models.FormatTypeEnum?Helper.ParseString("collection");
string hasDigitalIssue = "true";
string isbn = "isbn";
string issn = "issn";
string issueNumber = "issueNumber";
string limit = "limit";
string modifiedSince = "modifiedSince";
string noVariants = "true";
string offset = "offset";
string orderBy = "focDate";
string sharedAppearances = "sharedAppearances";
string startYear = "startYear";
string stories = "stories";
string title = "title";
string titleStartsWith = "titleStartsWith";
string upc = "upc";

Models.ComicDataWrapper result = await comics.GetComicsCollectionBySeriesId(seriesId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, sharedAppearances, startYear, stories, title, titleStartsWith, upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_comics_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.ComicsController.GetComicsCollectionByStoryId") GetComicsCollectionByStoryId

> Fetches lists of comics filtered by a story id.


```csharp
Task<Models.ComicDataWrapper> GetComicsCollectionByStoryId(
        string storyId,
        string characters = null,
        string collaborators = null,
        string creators = null,
        Models.DateDescriptorEnum? dateDescriptor = null,
        string dateRange = null,
        string diamondCode = null,
        string digitalId = null,
        string ean = null,
        string events = null,
        string format = "comic",
        Models.FormatTypeEnum? formatType = null,
        string hasDigitalIssue = "true",
        string isbn = null,
        string issn = null,
        string issueNumber = null,
        string limit = null,
        string modifiedSince = null,
        string noVariants = "true",
        string offset = null,
        string orderBy = "focDate",
        string series = null,
        string sharedAppearances = null,
        string startYear = null,
        string title = null,
        string titleStartsWith = null,
        string upc = null)
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

```csharp
string storyId = "storyId";
string characters = "characters";
string collaborators = "collaborators";
string creators = "creators";
var dateDescriptor = Models.DateDescriptorEnum?Helper.ParseString("lastWeek");
string dateRange = "dateRange";
string diamondCode = "diamondCode";
string digitalId = "digitalId";
string ean = "ean";
string events = "events";
string format = "comic";
var formatType = Models.FormatTypeEnum?Helper.ParseString("collection");
string hasDigitalIssue = "true";
string isbn = "isbn";
string issn = "issn";
string issueNumber = "issueNumber";
string limit = "limit";
string modifiedSince = "modifiedSince";
string noVariants = "true";
string offset = "offset";
string orderBy = "focDate";
string series = "series";
string sharedAppearances = "sharedAppearances";
string startYear = "startYear";
string title = "title";
string titleStartsWith = "titleStartsWith";
string upc = "upc";

Models.ComicDataWrapper result = await comics.GetComicsCollectionByStoryId(storyId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, title, titleStartsWith, upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


[Back to List of Controllers](#list_of_controllers)

## <a name="events_controller"></a>![Class: ](https://apidocs.io/img/class.png "MarvelComics.PCL.Controllers.EventsController") EventsController

### Get singleton instance

The singleton instance of the ``` EventsController ``` class can be accessed from the API Client.

```csharp
EventsController events = client.Events;
```

### <a name="get_character_events_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.EventsController.GetCharacterEventsCollection") GetCharacterEventsCollection

> Fetches lists of events filtered by a character id.


```csharp
Task<Models.EventDataWrapper> GetCharacterEventsCollection(
        string characterId,
        string comics = null,
        string creators = null,
        string limit = null,
        string modifiedSince = null,
        string name = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "name",
        string series = null,
        string stories = null)
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

```csharp
string characterId = "characterId";
string comics = "comics";
string creators = "creators";
string limit = "limit";
string modifiedSince = "modifiedSince";
string name = "name";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "name";
string series = "series";
string stories = "stories";

Models.EventDataWrapper result = await events.GetCharacterEventsCollection(characterId, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_issue_events_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.EventsController.GetIssueEventsCollection") GetIssueEventsCollection

> Fetches lists of events filtered by a comic id.


```csharp
Task<Models.EventDataWrapper> GetIssueEventsCollection(
        string comicId,
        string characters = null,
        string creators = null,
        string limit = null,
        string modifiedSince = null,
        string name = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "name",
        string series = null,
        string stories = null)
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

```csharp
string comicId = "comicId";
string characters = "characters";
string creators = "creators";
string limit = "limit";
string modifiedSince = "modifiedSince";
string name = "name";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "name";
string series = "series";
string stories = "stories";

Models.EventDataWrapper result = await events.GetIssueEventsCollection(comicId, characters, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_creator_events_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.EventsController.GetCreatorEventsCollection") GetCreatorEventsCollection

> Fetches lists of events filtered by a creator id.


```csharp
Task<Models.EventDataWrapper> GetCreatorEventsCollection(
        string creatorId,
        string characters = null,
        string comics = null,
        string limit = null,
        string modifiedSince = null,
        string name = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "name",
        string series = null,
        string stories = null)
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

```csharp
string creatorId = "creatorId";
string characters = "characters";
string comics = "comics";
string limit = "limit";
string modifiedSince = "modifiedSince";
string name = "name";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "name";
string series = "series";
string stories = "stories";

Models.EventDataWrapper result = await events.GetCreatorEventsCollection(creatorId, characters, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_event_individual"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.EventsController.GetEventIndividual") GetEventIndividual

> Fetches a single event by id.


```csharp
Task<Models.Event> GetEventIndividual(string eventId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | A single event. |


#### Example Usage

```csharp
string eventId = "eventId";

Models.Event result = await events.GetEventIndividual(eventId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Event not found. |


### <a name="get_events_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.EventsController.GetEventsCollection") GetEventsCollection

> Fetches lists of events.


```csharp
Task<Models.EventDataWrapper> GetEventsCollection(
        string characters = null,
        string comics = null,
        string creators = null,
        string limit = null,
        string modifiedSince = null,
        string name = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "name",
        string series = null,
        string stories = null)
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

```csharp
string characters = "characters";
string comics = "comics";
string creators = "creators";
string limit = "limit";
string modifiedSince = "modifiedSince";
string name = "name";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "name";
string series = "series";
string stories = "stories";

Models.EventDataWrapper result = await events.GetEventsCollection(characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_events_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.EventsController.GetEventsCollectionBySeriesId") GetEventsCollectionBySeriesId

> Fetches lists of events filtered by a series id.


```csharp
Task<Models.EventDataWrapper> GetEventsCollectionBySeriesId(
        string seriesId,
        string characters = null,
        string comics = null,
        string creators = null,
        string limit = null,
        string modifiedSince = null,
        string name = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "name",
        string stories = null)
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

```csharp
string seriesId = "seriesId";
string characters = "characters";
string comics = "comics";
string creators = "creators";
string limit = "limit";
string modifiedSince = "modifiedSince";
string name = "name";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "name";
string stories = "stories";

Models.EventDataWrapper result = await events.GetEventsCollectionBySeriesId(seriesId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_events_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.EventsController.GetEventsCollectionByStoryId") GetEventsCollectionByStoryId

> Fetches lists of events filtered by a story id.


```csharp
Task<Models.EventDataWrapper> GetEventsCollectionByStoryId(
        string storyId,
        string characters = null,
        string comics = null,
        string creators = null,
        string limit = null,
        string modifiedSince = null,
        string name = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "name",
        string series = null)
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

```csharp
string storyId = "storyId";
string characters = "characters";
string comics = "comics";
string creators = "creators";
string limit = "limit";
string modifiedSince = "modifiedSince";
string name = "name";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "name";
string series = "series";

Models.EventDataWrapper result = await events.GetEventsCollectionByStoryId(storyId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


[Back to List of Controllers](#list_of_controllers)

## <a name="series_controller"></a>![Class: ](https://apidocs.io/img/class.png "MarvelComics.PCL.Controllers.SeriesController") SeriesController

### Get singleton instance

The singleton instance of the ``` SeriesController ``` class can be accessed from the API Client.

```csharp
SeriesController series = client.Series;
```

### <a name="get_character_series_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.SeriesController.GetCharacterSeriesCollection") GetCharacterSeriesCollection

> Fetches lists of series filtered by a character id.


```csharp
Task<Models.SeriesDataWrapper> GetCharacterSeriesCollection(
        string characterId,
        string comics = null,
        string contains = "comic",
        string creators = null,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string offset = null,
        string orderBy = "title",
        string seriesType = "collection",
        string startYear = null,
        string stories = null,
        string title = null,
        string titleStartsWith = null)
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

```csharp
string characterId = "characterId";
string comics = "comics";
string contains = "comic";
string creators = "creators";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string offset = "offset";
string orderBy = "title";
string seriesType = "collection";
string startYear = "startYear";
string stories = "stories";
string title = "title";
string titleStartsWith = "titleStartsWith";

Models.SeriesDataWrapper result = await series.GetCharacterSeriesCollection(characterId, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_series_individual"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.SeriesController.GetSeriesIndividual") GetSeriesIndividual

> Fetches a single comic series by id.


```csharp
Task<Models.Series> GetSeriesIndividual(string seriesId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | Filter by series title. |


#### Example Usage

```csharp
string seriesId = "seriesId";

Models.Series result = await series.GetSeriesIndividual(seriesId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Series not found. |


### <a name="get_creator_series_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.SeriesController.GetCreatorSeriesCollection") GetCreatorSeriesCollection

> Fetches lists of series filtered by a creator id.


```csharp
Task<Models.SeriesDataWrapper> GetCreatorSeriesCollection(
        string creatorId,
        string characters = null,
        string comics = null,
        string contains = "comic",
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string offset = null,
        string orderBy = "title",
        string seriesType = "collection",
        string startYear = null,
        string stories = null,
        string title = null,
        string titleStartsWith = null)
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

```csharp
string creatorId = "creatorId";
string characters = "characters";
string comics = "comics";
string contains = "comic";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string offset = "offset";
string orderBy = "title";
string seriesType = "collection";
string startYear = "startYear";
string stories = "stories";
string title = "title";
string titleStartsWith = "titleStartsWith";

Models.SeriesDataWrapper result = await series.GetCreatorSeriesCollection(creatorId, characters, comics, contains, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_event_series_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.SeriesController.GetEventSeriesCollection") GetEventSeriesCollection

> Fetches lists of series filtered by an event id.


```csharp
Task<Models.SeriesDataWrapper> GetEventSeriesCollection(
        string eventId,
        string characters = null,
        string comics = null,
        string contains = "comic",
        string creators = null,
        string limit = null,
        string modifiedSince = null,
        string offset = null,
        string orderBy = "title",
        string seriesType = "collection",
        string startYear = null,
        string stories = null,
        string title = null,
        string titleStartsWith = null)
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

```csharp
string eventId = "eventId";
string characters = "characters";
string comics = "comics";
string contains = "comic";
string creators = "creators";
string limit = "limit";
string modifiedSince = "modifiedSince";
string offset = "offset";
string orderBy = "title";
string seriesType = "collection";
string startYear = "startYear";
string stories = "stories";
string title = "title";
string titleStartsWith = "titleStartsWith";

Models.SeriesDataWrapper result = await series.GetEventSeriesCollection(eventId, characters, comics, contains, creators, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_series_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.SeriesController.GetSeriesCollection") GetSeriesCollection

> Fetches lists of series.


```csharp
Task<Models.SeriesDataWrapper> GetSeriesCollection(
        string characters = null,
        string comics = null,
        string contains = "comic",
        string creators = null,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string offset = null,
        string orderBy = "title",
        string seriesType = "collection",
        string startYear = null,
        string stories = null,
        string title = null,
        string titleStartsWith = null)
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

```csharp
string characters = "characters";
string comics = "comics";
string contains = "comic";
string creators = "creators";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string offset = "offset";
string orderBy = "title";
string seriesType = "collection";
string startYear = "startYear";
string stories = "stories";
string title = "title";
string titleStartsWith = "titleStartsWith";

Models.SeriesDataWrapper result = await series.GetSeriesCollection(characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_story_series_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.SeriesController.GetStorySeriesCollection") GetStorySeriesCollection

> Fetches lists of series filtered by a story id.


```csharp
Task<Models.SeriesDataWrapper> GetStorySeriesCollection(
        string storyId,
        string characters = null,
        string comics = null,
        string contains = "comic",
        string creators = null,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string offset = null,
        string orderBy = "title",
        string seriesType = "collection",
        string startYear = null,
        string title = null,
        string titleStartsWith = null)
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

```csharp
string storyId = "storyId";
string characters = "characters";
string comics = "comics";
string contains = "comic";
string creators = "creators";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string offset = "offset";
string orderBy = "title";
string seriesType = "collection";
string startYear = "startYear";
string title = "title";
string titleStartsWith = "titleStartsWith";

Models.SeriesDataWrapper result = await series.GetStorySeriesCollection(storyId, characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, title, titleStartsWith);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


[Back to List of Controllers](#list_of_controllers)

## <a name="stories_controller"></a>![Class: ](https://apidocs.io/img/class.png "MarvelComics.PCL.Controllers.StoriesController") StoriesController

### Get singleton instance

The singleton instance of the ``` StoriesController ``` class can be accessed from the API Client.

```csharp
StoriesController stories = client.Stories;
```

### <a name="get_character_story_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.StoriesController.GetCharacterStoryCollection") GetCharacterStoryCollection

> Fetches lists of stories filtered by a character id.


```csharp
Task<Models.StoryDataWrapper> GetCharacterStoryCollection(
        string characterId,
        string comics = null,
        string creators = null,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string offset = null,
        string orderBy = "id",
        string series = null)
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

```csharp
string characterId = "characterId";
string comics = "comics";
string creators = "creators";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string offset = "offset";
string orderBy = "id";
string series = "series";

Models.StoryDataWrapper result = await stories.GetCharacterStoryCollection(characterId, comics, creators, events, limit, modifiedSince, offset, orderBy, series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_comic_story_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.StoriesController.GetComicStoryCollectionByComicId") GetComicStoryCollectionByComicId

> Fetches lists of stories filtered by a comic id.


```csharp
Task<Models.StoryDataWrapper> GetComicStoryCollectionByComicId(
        string comicId,
        string characters = null,
        string creators = null,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string offset = null,
        string orderBy = "id",
        string series = null)
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

```csharp
string comicId = "comicId";
string characters = "characters";
string creators = "creators";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string offset = "offset";
string orderBy = "id";
string series = "series";

Models.StoryDataWrapper result = await stories.GetComicStoryCollectionByComicId(comicId, characters, creators, events, limit, modifiedSince, offset, orderBy, series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_creator_story_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.StoriesController.GetCreatorStoryCollection") GetCreatorStoryCollection

> Fetches lists of stories filtered by a creator id.


```csharp
Task<Models.StoryDataWrapper> GetCreatorStoryCollection(
        string creatorId,
        string characters = null,
        string comics = null,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string offset = null,
        string orderBy = "id",
        string series = null)
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

```csharp
string creatorId = "creatorId";
string characters = "characters";
string comics = "comics";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string offset = "offset";
string orderBy = "id";
string series = "series";

Models.StoryDataWrapper result = await stories.GetCreatorStoryCollection(creatorId, characters, comics, events, limit, modifiedSince, offset, orderBy, series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_story_individual"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.StoriesController.GetStoryIndividual") GetStoryIndividual

> Fetches a single comic story by id.


```csharp
Task<Models.Story> GetStoryIndividual(string storyId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | Filter by story id. |


#### Example Usage

```csharp
string storyId = "storyId";

Models.Story result = await stories.GetStoryIndividual(storyId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Story not found. |


### <a name="get_event_story_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.StoriesController.GetEventStoryCollection") GetEventStoryCollection

> Fetches lists of stories filtered by an event id.


```csharp
Task<Models.StoryDataWrapper> GetEventStoryCollection(
        string eventId,
        string characters = null,
        string comics = null,
        string creators = null,
        string limit = null,
        string modifiedSince = null,
        string offset = null,
        string orderBy = "id",
        string series = null)
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

```csharp
string eventId = "eventId";
string characters = "characters";
string comics = "comics";
string creators = "creators";
string limit = "limit";
string modifiedSince = "modifiedSince";
string offset = "offset";
string orderBy = "id";
string series = "series";

Models.StoryDataWrapper result = await stories.GetEventStoryCollection(eventId, characters, comics, creators, limit, modifiedSince, offset, orderBy, series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_series_story_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.StoriesController.GetSeriesStoryCollection") GetSeriesStoryCollection

> Fetches lists of stories filtered by a series id.


```csharp
Task<Models.StoryDataWrapper> GetSeriesStoryCollection(
        string seriesId,
        string characters = null,
        string comics = null,
        string creators = null,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string offset = null,
        string orderBy = "id")
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

```csharp
string seriesId = "seriesId";
string characters = "characters";
string comics = "comics";
string creators = "creators";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string offset = "offset";
string orderBy = "id";

Models.StoryDataWrapper result = await stories.GetSeriesStoryCollection(seriesId, characters, comics, creators, events, limit, modifiedSince, offset, orderBy);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_story_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.StoriesController.GetStoryCollection") GetStoryCollection

> Fetches lists of stories.


```csharp
Task<Models.StoryDataWrapper> GetStoryCollection(
        string characters = null,
        string comics = null,
        string creators = null,
        string events = null,
        string limit = null,
        string modifiedSince = null,
        string offset = null,
        string orderBy = "id",
        string series = null)
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

```csharp
string characters = "characters";
string comics = "comics";
string creators = "creators";
string events = "events";
string limit = "limit";
string modifiedSince = "modifiedSince";
string offset = "offset";
string orderBy = "id";
string series = "series";

Models.StoryDataWrapper result = await stories.GetStoryCollection(characters, comics, creators, events, limit, modifiedSince, offset, orderBy, series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


[Back to List of Controllers](#list_of_controllers)

## <a name="creators_controller"></a>![Class: ](https://apidocs.io/img/class.png "MarvelComics.PCL.Controllers.CreatorsController") CreatorsController

### Get singleton instance

The singleton instance of the ``` CreatorsController ``` class can be accessed from the API Client.

```csharp
CreatorsController creators = client.Creators;
```

### <a name="get_creator_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CreatorsController.GetCreatorCollectionByComicId") GetCreatorCollectionByComicId

> Fetches lists of creators filtered by a comic id.


```csharp
Task<Models.CreatorDataWrapper> GetCreatorCollectionByComicId(
        string comicId,
        string comics = null,
        string firstName = null,
        string firstNameStartsWith = null,
        string lastName = null,
        string lastNameStartsWith = null,
        string limit = null,
        string middleName = null,
        string middleNameStartsWith = null,
        string modifiedSince = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "lastName",
        string series = null,
        string stories = null,
        string suffix = null)
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

```csharp
string comicId = "comicId";
string comics = "comics";
string firstName = "firstName";
string firstNameStartsWith = "firstNameStartsWith";
string lastName = "lastName";
string lastNameStartsWith = "lastNameStartsWith";
string limit = "limit";
string middleName = "middleName";
string middleNameStartsWith = "middleNameStartsWith";
string modifiedSince = "modifiedSince";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "lastName";
string series = "series";
string stories = "stories";
string suffix = "suffix";

Models.CreatorDataWrapper result = await creators.GetCreatorCollectionByComicId(comicId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_creator_collection"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CreatorsController.GetCreatorCollection") GetCreatorCollection

> Fetches lists of creators.


```csharp
Task<Models.CreatorDataWrapper> GetCreatorCollection(
        string comics = null,
        string events = null,
        string firstName = null,
        string firstNameStartsWith = null,
        string lastName = null,
        string lastNameStartsWith = null,
        string limit = null,
        string middleName = null,
        string middleNameStartsWith = null,
        string modifiedSince = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "lastName",
        string series = null,
        string stories = null,
        string suffix = null)
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

```csharp
string comics = "comics";
string events = "events";
string firstName = "firstName";
string firstNameStartsWith = "firstNameStartsWith";
string lastName = "lastName";
string lastNameStartsWith = "lastNameStartsWith";
string limit = "limit";
string middleName = "middleName";
string middleNameStartsWith = "middleNameStartsWith";
string modifiedSince = "modifiedSince";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "lastName";
string series = "series";
string stories = "stories";
string suffix = "suffix";

Models.CreatorDataWrapper result = await creators.GetCreatorCollection(comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_creator_individual"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CreatorsController.GetCreatorIndividual") GetCreatorIndividual

> Fetches a single creator by id.


```csharp
Task<Models.Creator> GetCreatorIndividual(string creatorId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | A single creator id. |


#### Example Usage

```csharp
string creatorId = "creatorId";

Models.Creator result = await creators.GetCreatorIndividual(creatorId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Creator not found. |


### <a name="get_creator_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CreatorsController.GetCreatorCollectionByEventId") GetCreatorCollectionByEventId

> Fetches lists of creators filtered by an event id.


```csharp
Task<Models.CreatorDataWrapper> GetCreatorCollectionByEventId(
        string eventId,
        string comics = null,
        string firstName = null,
        string firstNameStartsWith = null,
        string lastName = null,
        string lastNameStartsWith = null,
        string limit = null,
        string middleName = null,
        string middleNameStartsWith = null,
        string modifiedSince = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "lastName",
        string series = null,
        string stories = null,
        string suffix = null)
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

```csharp
string eventId = "eventId";
string comics = "comics";
string firstName = "firstName";
string firstNameStartsWith = "firstNameStartsWith";
string lastName = "lastName";
string lastNameStartsWith = "lastNameStartsWith";
string limit = "limit";
string middleName = "middleName";
string middleNameStartsWith = "middleNameStartsWith";
string modifiedSince = "modifiedSince";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "lastName";
string series = "series";
string stories = "stories";
string suffix = "suffix";

Models.CreatorDataWrapper result = await creators.GetCreatorCollectionByEventId(eventId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_creator_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CreatorsController.GetCreatorCollectionBySeriesId") GetCreatorCollectionBySeriesId

> Fetches lists of creators filtered by a series id.


```csharp
Task<Models.CreatorDataWrapper> GetCreatorCollectionBySeriesId(
        string seriesId,
        string comics = null,
        string events = null,
        string firstName = null,
        string firstNameStartsWith = null,
        string lastName = null,
        string lastNameStartsWith = null,
        string limit = null,
        string middleName = null,
        string middleNameStartsWith = null,
        string modifiedSince = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "lastName",
        string stories = null,
        string suffix = null)
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

```csharp
string seriesId = "seriesId";
string comics = "comics";
string events = "events";
string firstName = "firstName";
string firstNameStartsWith = "firstNameStartsWith";
string lastName = "lastName";
string lastNameStartsWith = "lastNameStartsWith";
string limit = "limit";
string middleName = "middleName";
string middleNameStartsWith = "middleNameStartsWith";
string modifiedSince = "modifiedSince";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "lastName";
string stories = "stories";
string suffix = "suffix";

Models.CreatorDataWrapper result = await creators.GetCreatorCollectionBySeriesId(seriesId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, stories, suffix);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


### <a name="get_creator_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png "MarvelComics.PCL.Controllers.CreatorsController.GetCreatorCollectionByStoryId") GetCreatorCollectionByStoryId

> Fetches lists of creators filtered by a story id.


```csharp
Task<Models.CreatorDataWrapper> GetCreatorCollectionByStoryId(
        string storyId,
        string comics = null,
        string events = null,
        string firstName = null,
        string firstNameStartsWith = null,
        string lastName = null,
        string lastNameStartsWith = null,
        string limit = null,
        string middleName = null,
        string middleNameStartsWith = null,
        string modifiedSince = null,
        string nameStartsWith = null,
        string offset = null,
        string orderBy = "lastName",
        string series = null,
        string suffix = null)
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

```csharp
string storyId = "storyId";
string comics = "comics";
string events = "events";
string firstName = "firstName";
string firstNameStartsWith = "firstNameStartsWith";
string lastName = "lastName";
string lastNameStartsWith = "lastNameStartsWith";
string limit = "limit";
string middleName = "middleName";
string middleNameStartsWith = "middleNameStartsWith";
string modifiedSince = "modifiedSince";
string nameStartsWith = "nameStartsWith";
string offset = "offset";
string orderBy = "lastName";
string series = "series";
string suffix = "suffix";

Models.CreatorDataWrapper result = await creators.GetCreatorCollectionByStoryId(storyId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, suffix);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |


[Back to List of Controllers](#list_of_controllers)



