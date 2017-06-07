# Getting started

## How to Build

The generated SDK requires AngularJS framework to work. If you do not already have angular downloaded, please go ahead and do it from [here](https://angularjs.org/).
If any of your models have `Date` or `Datetime` type fields or your endpoints have `Date`/`Datetime` type response, you will need to download and link [angular-moment](https://cdnjs.cloudflare.com/ajax/libs/angular-moment/1.0.1/angular-moment.min.js) and [moment.js](https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.17.1/moment.min.js) with your project.

## How to Use

The following section describes how to use the generated SDK in an existing/new project.

### 1. Configure Angular and Generated SDK
Perform the following steps to configure angular and the SDK:
+ Make a `scripts` folder inside the root folder of the project. If you already have a `scripts` folder, skip to the next step.
+ Move the `angular.min.js` file inside the scripts folder. 
+ Move the `marvelcomicslib` folder inside the scripts folder.
+ If any of the Custom Types in your API have `Date`/`Datetime` type fields or any endpoint has `Date`/`Datetime` response, you will need to download angular-moment and moment.js. Move these 2 files into the `scripts` folder as well.

![folder-structure-image](https://apidocs.io/illustration/angularjs?step=folderStructure&workspaceFolder=MarvelComics-Angular&projectName=MarvelComicsLib)

### 2. Open Project Folder
Open an IDE/Text Editor for JavaScript like Sublime Text. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.  
Click on `File` and select `Open Folder`

Select the folder of your SDK and click on `Select Folder` to open it up in Sublime Text. The folder will become visible in the bar on the left.

![open-folder-image](https://apidocs.io/illustration/angularjs?step=openFolder&workspaceFolder=MarvelComics-Angular)

### 3. Create an Angular Application
Since Angular JS is used for client-side web development, in order to use the generated library, you will have to develop an application first.
If you already have an angular application, [skip to Step 6](#6-include-sdk-references-in-html-file). Otherwise, follow these steps to create one:

+ In the IDE, click on `File` and choose `New File` to create a new file.
+ Add the following starting code in the file:
```js
    var app = angular.module('myApp', []);
    app.controller('testController', function($scope) 
    {

    });
```
+ Save it with the name `app.js` in the `scripts` folder.


### 4. Create HTML File
Skip to the next step if you are working with an existing project and already have an html file. Otherwise follow the steps to create one:
+ Inside the IDE, right click on the project folder name and select the `New File` option to create a new test file.
+ Save it with an appropriate name such as `index.html` in the root of your project folder.
`index.html` should look like this:
```html
	<!DOCTYPE html>
	<html>
	<head>
		<title>Angular Project</title>
		<script></script>
	</head>

	<body>
	</body>

	</html>
```

![initial-html-code-image](https://apidocs.io/illustration/angularjs?step=initialCode&workspaceFolder=MarvelComics-Angular)

### 5. Including links to Angular in HTML file
Your HTML file needs to have a link to `angular.min.js` file to use Angular-JS. Add the link using `script` tags inside the `head` section of `index.html` like:
```html
	<script src="scripts/angular.min.js" ></script>
```
If any of the Custom Types that you have defined have `Date`/`Datetime` type fields or any endpoint has `Date`/`Datetime` response, you will also need to link to angular-moment and moment.js like:
```html
	<script src="scripts/angular.min.js" ></script>
	<script src="scripts/moment.min.js" ></script>
	<script src="scripts/angular-moment.min.js" ></script>
```

### 6. Include SDK references in HTML file
Import the reference to the generated SDK files inside your html file like:
```html
	<head>
		...
		<!-- Helper files -->
		<script src="scripts/marvelcomicslib/Module.js"></script>
		<script src="scripts/marvelcomicslib/Configuration.js"></script>
		<script src="scripts/marvelcomicslib/APIHelper.js"></script>
		<script src="scripts/marvelcomicslib/Http/Client/HttpContext.js"></script>
		<script src="scripts/marvelcomicslib/Http/Client/RequestClient.js"></script>
		<script src="scripts/marvelcomicslib/Http/Request/HttpRequest.js"></script>
		<script src="scripts/marvelcomicslib/Http/Response/HttpResponse.js"></script>

		<!-- API Controllers -->
        <script src="scripts/marvelcomicslib/Controllers/CharactersController.js"></script>
        <script src="scripts/marvelcomicslib/Controllers/ComicsController.js"></script>
        <script src="scripts/marvelcomicslib/Controllers/EventsController.js"></script>
        <script src="scripts/marvelcomicslib/Controllers/SeriesController.js"></script>
        <script src="scripts/marvelcomicslib/Controllers/StoriesController.js"></script>
        <script src="scripts/marvelcomicslib/Controllers/CreatorsController.js"></script>


		<!-- Models -->
        <script src="scripts/marvelcomicslib/Models/BaseModel.js"></script>
        <script src="scripts/marvelcomicslib/Models/FormatTypeEnum.js"></script>
        <script src="scripts/marvelcomicslib/Models/DateDescriptorEnum.js"></script>
        <script src="scripts/marvelcomicslib/Models/ComicList.js"></script>
        <script src="scripts/marvelcomicslib/Models/EventList.js"></script>
        <script src="scripts/marvelcomicslib/Models/CreatorList.js"></script>
        <script src="scripts/marvelcomicslib/Models/CharacterList.js"></script>
        <script src="scripts/marvelcomicslib/Models/SeriesList.js"></script>
        <script src="scripts/marvelcomicslib/Models/StoryList.js"></script>
        <script src="scripts/marvelcomicslib/Models/CharacterSummary.js"></script>
        <script src="scripts/marvelcomicslib/Models/EventSummary.js"></script>
        <script src="scripts/marvelcomicslib/Models/SeriesSummary.js"></script>
        <script src="scripts/marvelcomicslib/Models/ComicSummary.js"></script>
        <script src="scripts/marvelcomicslib/Models/Url.js"></script>
        <script src="scripts/marvelcomicslib/Models/CreatorSummary.js"></script>
        <script src="scripts/marvelcomicslib/Models/StorySummary.js"></script>
        <script src="scripts/marvelcomicslib/Models/Image.js"></script>
        <script src="scripts/marvelcomicslib/Models/ComicDate.js"></script>
        <script src="scripts/marvelcomicslib/Models/CharacterDataContainer.js"></script>
        <script src="scripts/marvelcomicslib/Models/EventDataContainer.js"></script>
        <script src="scripts/marvelcomicslib/Models/ComicPrice.js"></script>
        <script src="scripts/marvelcomicslib/Models/EventDataWrapper.js"></script>
        <script src="scripts/marvelcomicslib/Models/Creator.js"></script>
        <script src="scripts/marvelcomicslib/Models/Event.js"></script>
        <script src="scripts/marvelcomicslib/Models/ComicDataContainer.js"></script>
        <script src="scripts/marvelcomicslib/Models/TextObject.js"></script>
        <script src="scripts/marvelcomicslib/Models/CreatorDataWrapper.js"></script>
        <script src="scripts/marvelcomicslib/Models/StoryDataWrapper.js"></script>
        <script src="scripts/marvelcomicslib/Models/Character.js"></script>
        <script src="scripts/marvelcomicslib/Models/CharacterDataWrapper.js"></script>
        <script src="scripts/marvelcomicslib/Models/ComicDataWrapper.js"></script>
        <script src="scripts/marvelcomicslib/Models/Series.js"></script>
        <script src="scripts/marvelcomicslib/Models/SeriesDataWrapper.js"></script>
        <script src="scripts/marvelcomicslib/Models/SeriesDataContainer.js"></script>
        <script src="scripts/marvelcomicslib/Models/StoryDataContainer.js"></script>
        <script src="scripts/marvelcomicslib/Models/Comic.js"></script>
        <script src="scripts/marvelcomicslib/Models/CreatorDataContainer.js"></script>
        <script src="scripts/marvelcomicslib/Models/Story.js"></script>
        <script src="scripts/marvelcomicslib/Models/Thumbnail.js"></script>

		...
	</head>
```
> The `Module.js` file should be imported before the other files. After `Module.js`, `Configuration.js` should be imported.

### 7. Including link to `app.js` in HTML file
Link your `app.js` file to your `index.html` file like:
```html
	<head>
		...
		<script src="scripts/app.js"></script>
	</head>
```
> The link to app.js needs to be included at the very end of the head tag, after the SDK references have been added

### 8. Initializing the Angular App
You need to initialize your app and the controller associated with your view inside your `index.html` file. Do so like:
+ Add ng-app directive to initialize your app inside the `body` tag.
```html
	<body ng-app="myApp">
```
+ Add ng-controller directive to initialize your controller and bind it with your view (`index.html` file).
```html
	...
	<body ng-app="myApp">
		<div ng-controller="testController">
			...
		</div>
		...
	</body>
	...
```

### 9. Consuming the SDK 
In order to use the generated SDK's modules, controllers and factories, the project needs to be added as a dependency in your angular app's module. This will be done inside the `app.js` file.
Add the dependency like this:

```js
    var app = angular.module('myApp', ['MarvelComicsLib']);
```
At this point, the SDK has been successfully included in your project. Further steps include using a service/factory from the generated SDK. To see working example of this, please head on [over here](#list-of-controllers) and choose any class to see its functions and example usage.  

### 10. Running The App
To run the app, simply open up the `index.html` file in a browser.

![app-running](https://apidocs.io/illustration/angularjs?step=appRunning)

## Initialization

### Authentication
In order to setup authentication and initialization of the Angular App, you need the following information.

| Parameter | Description |
|-----------|-------------|
| referer | TODO: add a description |
| apikey | TODO: add a description |



```JavaScript
// Configuration parameters and credentials
referer = "*.marvel.com";
apikey = "apikey";

```
The Angular App can be initialized as following:
```html
<body ng-app="myApp">
    <div ng-controller="testController">
        ...
    </div>
    ...
</body>
```
> The initialization code will be added inside the `index.html` file (which is the view of the app you have created). More detail about this can be found in the [`How to Use`](#how-to-use) section

# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [CharactersController](#characters_controller)
* [ComicsController](#comics_controller)
* [EventsController](#events_controller)
* [SeriesController](#series_controller)
* [StoriesController](#stories_controller)
* [CreatorsController](#creators_controller)

## <a name="characters_controller"></a>![Class: ](https://apidocs.io/img/class.png ".CharactersController") CharactersController

### Get singleton instance

The singleton instance of the ``` CharactersController ``` class can be accessed via Dependency Injection.

```js
	app.controller("testController", function($scope, CharactersController, Character, CharacterDataWrapper){
	});
```

### <a name="get_character_individual"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getCharacterIndividual") getCharacterIndividual

> Fetches a single character by id.


```javascript
function getCharacterIndividual(characterId)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | A single character id. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, CharactersController, Character){
        var characterId = 'characterId';


		var result = CharactersController.getCharacterIndividual(characterId);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Character not found. |




### <a name="get_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getCharacterCollection") getCharacterCollection

> Fetches lists of characters.


```javascript
function getCharacterCollection(comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)
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

```javascript


	app.controller("testController", function($scope, CharactersController, CharacterDataWrapper){
        var comics = 'comics';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var name = 'name';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var stories = 'stories';


		var result = CharactersController.getCharacterCollection(comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comic_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getComicCharacterCollection") getComicCharacterCollection

> Fetches lists of characters filtered by a comic id.


```javascript
function getComicCharacterCollection(comicId, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)
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

```javascript


	app.controller("testController", function($scope, CharactersController, CharacterDataWrapper){
        var comicId = 'comicId';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var name = 'name';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var stories = 'stories';


		var result = CharactersController.getComicCharacterCollection(comicId, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_event_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getEventCharacterCollection") getEventCharacterCollection

> Fetches lists of characters filtered by an event id.


```javascript
function getEventCharacterCollection(eventId, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)
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

```javascript


	app.controller("testController", function($scope, CharactersController, CharacterDataWrapper){
        var eventId = 'eventId';
        var comics = 'comics';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var name = 'name';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var stories = 'stories';


		var result = CharactersController.getEventCharacterCollection(eventId, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_character_wrapper"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getSeriesCharacterWrapper") getSeriesCharacterWrapper

> Fetches lists of characters filtered by a series id.


```javascript
function getSeriesCharacterWrapper(seriesId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories)
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

```javascript


	app.controller("testController", function($scope, CharactersController, CharacterDataWrapper){
        var seriesId = 'seriesId';
        var comics = 'comics';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var name = 'name';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var stories = 'stories';


		var result = CharactersController.getSeriesCharacterWrapper(seriesId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_character_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getCharacterCollectionByStoryId") getCharacterCollectionByStoryId

> Fetches lists of characters filtered by a story id.


```javascript
function getCharacterCollectionByStoryId(storyId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series)
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

```javascript


	app.controller("testController", function($scope, CharactersController, CharacterDataWrapper){
        var storyId = 'storyId';
        var comics = 'comics';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var name = 'name';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';


		var result = CharactersController.getCharacterCollectionByStoryId(storyId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="comics_controller"></a>![Class: ](https://apidocs.io/img/class.png ".ComicsController") ComicsController

### Get singleton instance

The singleton instance of the ``` ComicsController ``` class can be accessed via Dependency Injection.

```js
	app.controller("testController", function($scope, ComicsController, ComicDataWrapper, Comic){
	});
```

### <a name="get_comics_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCharacterCollection") getComicsCharacterCollection

> Fetches lists of comics filtered by a character id.


```javascript
function getComicsCharacterCollection(characterId, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc)
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

```javascript


	app.controller("testController", function($scope, ComicsController, ComicDataWrapper){
        var characterId = 'characterId';
        var collaborators = 'collaborators';
        var creators = 'creators';
        var dateDescriptor = Object.keys(DateDescriptorEnum)[0];
        var dateRange = 'dateRange';
        var diamondCode = 'diamondCode';
        var digitalId = 'digitalId';
        var ean = 'ean';
        var events = 'events';
        var format = 'format';
        var formatType = Object.keys(FormatTypeEnum)[0];
        var hasDigitalIssue = 'hasDigitalIssue';
        var isbn = 'isbn';
        var issn = 'issn';
        var issueNumber = 'issueNumber';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var noVariants = 'noVariants';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var sharedAppearances = 'sharedAppearances';
        var startYear = 'startYear';
        var stories = 'stories';
        var title = 'title';
        var titleStartsWith = 'titleStartsWith';
        var upc = 'upc';


		var result = ComicsController.getComicsCharacterCollection(characterId, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollection") getComicsCollection

> Fetches lists of comics.


```javascript
function getComicsCollection(characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc)
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

```javascript


	app.controller("testController", function($scope, ComicsController, ComicDataWrapper){
        var characters = 'characters';
        var collaborators = 'collaborators';
        var creators = 'creators';
        var dateDescriptor = Object.keys(DateDescriptorEnum)[0];
        var dateRange = 'dateRange';
        var diamondCode = 'diamondCode';
        var digitalId = 'digitalId';
        var ean = 'ean';
        var events = 'events';
        var format = 'format';
        var formatType = Object.keys(FormatTypeEnum)[0];
        var hasDigitalIssue = 'hasDigitalIssue';
        var isbn = 'isbn';
        var issn = 'issn';
        var issueNumber = 'issueNumber';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var noVariants = 'noVariants';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var sharedAppearances = 'sharedAppearances';
        var startYear = 'startYear';
        var stories = 'stories';
        var title = 'title';
        var titleStartsWith = 'titleStartsWith';
        var upc = 'upc';


		var result = ComicsController.getComicsCollection(characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comic_individual"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicIndividual") getComicIndividual

> Fetches a single comic by id.


```javascript
function getComicIndividual(comicId)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | A single comic. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, ComicsController, Comic){
        var comicId = 'comicId';


		var result = ComicsController.getComicIndividual(comicId);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Comic not found. |




### <a name="get_comics_collection_by_creator_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionByCreatorId") getComicsCollectionByCreatorId

> Fetches lists of comics filtered by a creator id.


```javascript
function getComicsCollectionByCreatorId(creatorId, characters, collaborators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc)
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

```javascript


	app.controller("testController", function($scope, ComicsController, ComicDataWrapper){
        var creatorId = 'creatorId';
        var characters = 'characters';
        var collaborators = 'collaborators';
        var dateDescriptor = Object.keys(DateDescriptorEnum)[0];
        var dateRange = 'dateRange';
        var diamondCode = 'diamondCode';
        var digitalId = 'digitalId';
        var ean = 'ean';
        var events = 'events';
        var format = 'format';
        var formatType = Object.keys(FormatTypeEnum)[0];
        var hasDigitalIssue = 'hasDigitalIssue';
        var isbn = 'isbn';
        var issn = 'issn';
        var issueNumber = 'issueNumber';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var noVariants = 'noVariants';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var sharedAppearances = 'sharedAppearances';
        var startYear = 'startYear';
        var stories = 'stories';
        var title = 'title';
        var titleStartsWith = 'titleStartsWith';
        var upc = 'upc';


		var result = ComicsController.getComicsCollectionByCreatorId(creatorId, characters, collaborators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionByEventId") getComicsCollectionByEventId

> Fetches lists of comics filtered by an event id.


```javascript
function getComicsCollectionByEventId(eventId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc)
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

```javascript


	app.controller("testController", function($scope, ComicsController, ComicDataWrapper){
        var eventId = 'eventId';
        var characters = 'characters';
        var collaborators = 'collaborators';
        var creators = 'creators';
        var dateDescriptor = Object.keys(DateDescriptorEnum)[0];
        var dateRange = 'dateRange';
        var diamondCode = 'diamondCode';
        var digitalId = 'digitalId';
        var ean = 'ean';
        var events = 'events';
        var format = 'format';
        var formatType = Object.keys(FormatTypeEnum)[0];
        var hasDigitalIssue = 'hasDigitalIssue';
        var isbn = 'isbn';
        var issn = 'issn';
        var issueNumber = 'issueNumber';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var noVariants = 'noVariants';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var sharedAppearances = 'sharedAppearances';
        var startYear = 'startYear';
        var stories = 'stories';
        var title = 'title';
        var titleStartsWith = 'titleStartsWith';
        var upc = 'upc';


		var result = ComicsController.getComicsCollectionByEventId(eventId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionBySeriesId") getComicsCollectionBySeriesId

> Fetches lists of comics filtered by a series id.


```javascript
function getComicsCollectionBySeriesId(seriesId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, sharedAppearances, startYear, stories, title, titleStartsWith, upc)
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

```javascript


	app.controller("testController", function($scope, ComicsController, ComicDataWrapper){
        var seriesId = 'seriesId';
        var characters = 'characters';
        var collaborators = 'collaborators';
        var creators = 'creators';
        var dateDescriptor = Object.keys(DateDescriptorEnum)[0];
        var dateRange = 'dateRange';
        var diamondCode = 'diamondCode';
        var digitalId = 'digitalId';
        var ean = 'ean';
        var events = 'events';
        var format = 'format';
        var formatType = Object.keys(FormatTypeEnum)[0];
        var hasDigitalIssue = 'hasDigitalIssue';
        var isbn = 'isbn';
        var issn = 'issn';
        var issueNumber = 'issueNumber';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var noVariants = 'noVariants';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var sharedAppearances = 'sharedAppearances';
        var startYear = 'startYear';
        var stories = 'stories';
        var title = 'title';
        var titleStartsWith = 'titleStartsWith';
        var upc = 'upc';


		var result = ComicsController.getComicsCollectionBySeriesId(seriesId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, sharedAppearances, startYear, stories, title, titleStartsWith, upc);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionByStoryId") getComicsCollectionByStoryId

> Fetches lists of comics filtered by a story id.


```javascript
function getComicsCollectionByStoryId(storyId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, title, titleStartsWith, upc)
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

```javascript


	app.controller("testController", function($scope, ComicsController, ComicDataWrapper){
        var storyId = 'storyId';
        var characters = 'characters';
        var collaborators = 'collaborators';
        var creators = 'creators';
        var dateDescriptor = Object.keys(DateDescriptorEnum)[0];
        var dateRange = 'dateRange';
        var diamondCode = 'diamondCode';
        var digitalId = 'digitalId';
        var ean = 'ean';
        var events = 'events';
        var format = 'format';
        var formatType = Object.keys(FormatTypeEnum)[0];
        var hasDigitalIssue = 'hasDigitalIssue';
        var isbn = 'isbn';
        var issn = 'issn';
        var issueNumber = 'issueNumber';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var noVariants = 'noVariants';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var sharedAppearances = 'sharedAppearances';
        var startYear = 'startYear';
        var title = 'title';
        var titleStartsWith = 'titleStartsWith';
        var upc = 'upc';


		var result = ComicsController.getComicsCollectionByStoryId(storyId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, title, titleStartsWith, upc);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="events_controller"></a>![Class: ](https://apidocs.io/img/class.png ".EventsController") EventsController

### Get singleton instance

The singleton instance of the ``` EventsController ``` class can be accessed via Dependency Injection.

```js
	app.controller("testController", function($scope, EventsController, EventDataWrapper, Event){
	});
```

### <a name="get_character_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getCharacterEventsCollection") getCharacterEventsCollection

> Fetches lists of events filtered by a character id.


```javascript
function getCharacterEventsCollection(characterId, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)
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

```javascript


	app.controller("testController", function($scope, EventsController, EventDataWrapper){
        var characterId = 'characterId';
        var comics = 'comics';
        var creators = 'creators';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var name = 'name';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var stories = 'stories';


		var result = EventsController.getCharacterEventsCollection(characterId, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_issue_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getIssueEventsCollection") getIssueEventsCollection

> Fetches lists of events filtered by a comic id.


```javascript
function getIssueEventsCollection(comicId, characters, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)
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

```javascript


	app.controller("testController", function($scope, EventsController, EventDataWrapper){
        var comicId = 'comicId';
        var characters = 'characters';
        var creators = 'creators';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var name = 'name';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var stories = 'stories';


		var result = EventsController.getIssueEventsCollection(comicId, characters, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getCreatorEventsCollection") getCreatorEventsCollection

> Fetches lists of events filtered by a creator id.


```javascript
function getCreatorEventsCollection(creatorId, characters, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)
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

```javascript


	app.controller("testController", function($scope, EventsController, EventDataWrapper){
        var creatorId = 'creatorId';
        var characters = 'characters';
        var comics = 'comics';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var name = 'name';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var stories = 'stories';


		var result = EventsController.getCreatorEventsCollection(creatorId, characters, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_event_individual"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventIndividual") getEventIndividual

> Fetches a single event by id.


```javascript
function getEventIndividual(eventId)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | A single event. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, EventsController, Event){
        var eventId = 'eventId';


		var result = EventsController.getEventIndividual(eventId);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Event not found. |




### <a name="get_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventsCollection") getEventsCollection

> Fetches lists of events.


```javascript
function getEventsCollection(characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)
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

```javascript


	app.controller("testController", function($scope, EventsController, EventDataWrapper){
        var characters = 'characters';
        var comics = 'comics';
        var creators = 'creators';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var name = 'name';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var stories = 'stories';


		var result = EventsController.getEventsCollection(characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_events_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventsCollectionBySeriesId") getEventsCollectionBySeriesId

> Fetches lists of events filtered by a series id.


```javascript
function getEventsCollectionBySeriesId(seriesId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories)
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

```javascript


	app.controller("testController", function($scope, EventsController, EventDataWrapper){
        var seriesId = 'seriesId';
        var characters = 'characters';
        var comics = 'comics';
        var creators = 'creators';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var name = 'name';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var stories = 'stories';


		var result = EventsController.getEventsCollectionBySeriesId(seriesId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_events_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventsCollectionByStoryId") getEventsCollectionByStoryId

> Fetches lists of events filtered by a story id.


```javascript
function getEventsCollectionByStoryId(storyId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series)
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

```javascript


	app.controller("testController", function($scope, EventsController, EventDataWrapper){
        var storyId = 'storyId';
        var characters = 'characters';
        var comics = 'comics';
        var creators = 'creators';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var name = 'name';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';


		var result = EventsController.getEventsCollectionByStoryId(storyId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="series_controller"></a>![Class: ](https://apidocs.io/img/class.png ".SeriesController") SeriesController

### Get singleton instance

The singleton instance of the ``` SeriesController ``` class can be accessed via Dependency Injection.

```js
	app.controller("testController", function($scope, SeriesController, SeriesDataWrapper, Series){
	});
```

### <a name="get_character_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getCharacterSeriesCollection") getCharacterSeriesCollection

> Fetches lists of series filtered by a character id.


```javascript
function getCharacterSeriesCollection(characterId, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith)
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

```javascript


	app.controller("testController", function($scope, SeriesController, SeriesDataWrapper){
        var characterId = 'characterId';
        var comics = 'comics';
        var contains = 'contains';
        var creators = 'creators';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var seriesType = 'seriesType';
        var startYear = 'startYear';
        var stories = 'stories';
        var title = 'title';
        var titleStartsWith = 'titleStartsWith';


		var result = SeriesController.getCharacterSeriesCollection(characterId, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_individual"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getSeriesIndividual") getSeriesIndividual

> Fetches a single comic series by id.


```javascript
function getSeriesIndividual(seriesId)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | Filter by series title. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, SeriesController, Series){
        var seriesId = 'seriesId';


		var result = SeriesController.getSeriesIndividual(seriesId);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Series not found. |




### <a name="get_creator_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getCreatorSeriesCollection") getCreatorSeriesCollection

> Fetches lists of series filtered by a creator id.


```javascript
function getCreatorSeriesCollection(creatorId, characters, comics, contains, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith)
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

```javascript


	app.controller("testController", function($scope, SeriesController, SeriesDataWrapper){
        var creatorId = 'creatorId';
        var characters = 'characters';
        var comics = 'comics';
        var contains = 'contains';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var seriesType = 'seriesType';
        var startYear = 'startYear';
        var stories = 'stories';
        var title = 'title';
        var titleStartsWith = 'titleStartsWith';


		var result = SeriesController.getCreatorSeriesCollection(creatorId, characters, comics, contains, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_event_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getEventSeriesCollection") getEventSeriesCollection

> Fetches lists of series filtered by an event id.


```javascript
function getEventSeriesCollection(eventId, characters, comics, contains, creators, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith)
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

```javascript


	app.controller("testController", function($scope, SeriesController, SeriesDataWrapper){
        var eventId = 'eventId';
        var characters = 'characters';
        var comics = 'comics';
        var contains = 'contains';
        var creators = 'creators';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var seriesType = 'seriesType';
        var startYear = 'startYear';
        var stories = 'stories';
        var title = 'title';
        var titleStartsWith = 'titleStartsWith';


		var result = SeriesController.getEventSeriesCollection(eventId, characters, comics, contains, creators, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getSeriesCollection") getSeriesCollection

> Fetches lists of series.


```javascript
function getSeriesCollection(characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith)
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

```javascript


	app.controller("testController", function($scope, SeriesController, SeriesDataWrapper){
        var characters = 'characters';
        var comics = 'comics';
        var contains = 'contains';
        var creators = 'creators';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var seriesType = 'seriesType';
        var startYear = 'startYear';
        var stories = 'stories';
        var title = 'title';
        var titleStartsWith = 'titleStartsWith';


		var result = SeriesController.getSeriesCollection(characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_story_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getStorySeriesCollection") getStorySeriesCollection

> Fetches lists of series filtered by a story id.


```javascript
function getStorySeriesCollection(storyId, characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, title, titleStartsWith)
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

```javascript


	app.controller("testController", function($scope, SeriesController, SeriesDataWrapper){
        var storyId = 'storyId';
        var characters = 'characters';
        var comics = 'comics';
        var contains = 'contains';
        var creators = 'creators';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var seriesType = 'seriesType';
        var startYear = 'startYear';
        var title = 'title';
        var titleStartsWith = 'titleStartsWith';


		var result = SeriesController.getStorySeriesCollection(storyId, characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, title, titleStartsWith);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="stories_controller"></a>![Class: ](https://apidocs.io/img/class.png ".StoriesController") StoriesController

### Get singleton instance

The singleton instance of the ``` StoriesController ``` class can be accessed via Dependency Injection.

```js
	app.controller("testController", function($scope, StoriesController, StoryDataWrapper, Story){
	});
```

### <a name="get_character_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getCharacterStoryCollection") getCharacterStoryCollection

> Fetches lists of stories filtered by a character id.


```javascript
function getCharacterStoryCollection(characterId, comics, creators, events, limit, modifiedSince, offset, orderBy, series)
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

```javascript


	app.controller("testController", function($scope, StoriesController, StoryDataWrapper){
        var characterId = 'characterId';
        var comics = 'comics';
        var creators = 'creators';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';


		var result = StoriesController.getCharacterStoryCollection(characterId, comics, creators, events, limit, modifiedSince, offset, orderBy, series);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comic_story_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getComicStoryCollectionByComicId") getComicStoryCollectionByComicId

> Fetches lists of stories filtered by a comic id.


```javascript
function getComicStoryCollectionByComicId(comicId, characters, creators, events, limit, modifiedSince, offset, orderBy, series)
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

```javascript


	app.controller("testController", function($scope, StoriesController, StoryDataWrapper){
        var comicId = 'comicId';
        var characters = 'characters';
        var creators = 'creators';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';


		var result = StoriesController.getComicStoryCollectionByComicId(comicId, characters, creators, events, limit, modifiedSince, offset, orderBy, series);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getCreatorStoryCollection") getCreatorStoryCollection

> Fetches lists of stories filtered by a creator id.


```javascript
function getCreatorStoryCollection(creatorId, characters, comics, events, limit, modifiedSince, offset, orderBy, series)
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

```javascript


	app.controller("testController", function($scope, StoriesController, StoryDataWrapper){
        var creatorId = 'creatorId';
        var characters = 'characters';
        var comics = 'comics';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';


		var result = StoriesController.getCreatorStoryCollection(creatorId, characters, comics, events, limit, modifiedSince, offset, orderBy, series);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_story_individual"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getStoryIndividual") getStoryIndividual

> Fetches a single comic story by id.


```javascript
function getStoryIndividual(storyId)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | Filter by story id. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, StoriesController, Story){
        var storyId = 'storyId';


		var result = StoriesController.getStoryIndividual(storyId);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Story not found. |




### <a name="get_event_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getEventStoryCollection") getEventStoryCollection

> Fetches lists of stories filtered by an event id.


```javascript
function getEventStoryCollection(eventId, characters, comics, creators, limit, modifiedSince, offset, orderBy, series)
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

```javascript


	app.controller("testController", function($scope, StoriesController, StoryDataWrapper){
        var eventId = 'eventId';
        var characters = 'characters';
        var comics = 'comics';
        var creators = 'creators';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';


		var result = StoriesController.getEventStoryCollection(eventId, characters, comics, creators, limit, modifiedSince, offset, orderBy, series);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getSeriesStoryCollection") getSeriesStoryCollection

> Fetches lists of stories filtered by a series id.


```javascript
function getSeriesStoryCollection(seriesId, characters, comics, creators, events, limit, modifiedSince, offset, orderBy)
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

```javascript


	app.controller("testController", function($scope, StoriesController, StoryDataWrapper){
        var seriesId = 'seriesId';
        var characters = 'characters';
        var comics = 'comics';
        var creators = 'creators';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var offset = 'offset';
        var orderBy = 'orderBy';


		var result = StoriesController.getSeriesStoryCollection(seriesId, characters, comics, creators, events, limit, modifiedSince, offset, orderBy);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getStoryCollection") getStoryCollection

> Fetches lists of stories.


```javascript
function getStoryCollection(characters, comics, creators, events, limit, modifiedSince, offset, orderBy, series)
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

```javascript


	app.controller("testController", function($scope, StoriesController, StoryDataWrapper){
        var characters = 'characters';
        var comics = 'comics';
        var creators = 'creators';
        var events = 'events';
        var limit = 'limit';
        var modifiedSince = 'modifiedSince';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';


		var result = StoriesController.getStoryCollection(characters, comics, creators, events, limit, modifiedSince, offset, orderBy, series);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="creators_controller"></a>![Class: ](https://apidocs.io/img/class.png ".CreatorsController") CreatorsController

### Get singleton instance

The singleton instance of the ``` CreatorsController ``` class can be accessed via Dependency Injection.

```js
	app.controller("testController", function($scope, CreatorsController, CreatorDataWrapper, Creator){
	});
```

### <a name="get_creator_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionByComicId") getCreatorCollectionByComicId

> Fetches lists of creators filtered by a comic id.


```javascript
function getCreatorCollectionByComicId(comicId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix)
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

```javascript


	app.controller("testController", function($scope, CreatorsController, CreatorDataWrapper){
        var comicId = 'comicId';
        var comics = 'comics';
        var firstName = 'firstName';
        var firstNameStartsWith = 'firstNameStartsWith';
        var lastName = 'lastName';
        var lastNameStartsWith = 'lastNameStartsWith';
        var limit = 'limit';
        var middleName = 'middleName';
        var middleNameStartsWith = 'middleNameStartsWith';
        var modifiedSince = 'modifiedSince';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var stories = 'stories';
        var suffix = 'suffix';


		var result = CreatorsController.getCreatorCollectionByComicId(comicId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollection") getCreatorCollection

> Fetches lists of creators.


```javascript
function getCreatorCollection(comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix)
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

```javascript


	app.controller("testController", function($scope, CreatorsController, CreatorDataWrapper){
        var comics = 'comics';
        var events = 'events';
        var firstName = 'firstName';
        var firstNameStartsWith = 'firstNameStartsWith';
        var lastName = 'lastName';
        var lastNameStartsWith = 'lastNameStartsWith';
        var limit = 'limit';
        var middleName = 'middleName';
        var middleNameStartsWith = 'middleNameStartsWith';
        var modifiedSince = 'modifiedSince';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var stories = 'stories';
        var suffix = 'suffix';


		var result = CreatorsController.getCreatorCollection(comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_individual"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorIndividual") getCreatorIndividual

> Fetches a single creator by id.


```javascript
function getCreatorIndividual(creatorId)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | A single creator id. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, CreatorsController, Creator){
        var creatorId = 'creatorId';


		var result = CreatorsController.getCreatorIndividual(creatorId);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Creator not found. |




### <a name="get_creator_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionByEventId") getCreatorCollectionByEventId

> Fetches lists of creators filtered by an event id.


```javascript
function getCreatorCollectionByEventId(eventId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix)
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

```javascript


	app.controller("testController", function($scope, CreatorsController, CreatorDataWrapper){
        var eventId = 'eventId';
        var comics = 'comics';
        var firstName = 'firstName';
        var firstNameStartsWith = 'firstNameStartsWith';
        var lastName = 'lastName';
        var lastNameStartsWith = 'lastNameStartsWith';
        var limit = 'limit';
        var middleName = 'middleName';
        var middleNameStartsWith = 'middleNameStartsWith';
        var modifiedSince = 'modifiedSince';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var stories = 'stories';
        var suffix = 'suffix';


		var result = CreatorsController.getCreatorCollectionByEventId(eventId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionBySeriesId") getCreatorCollectionBySeriesId

> Fetches lists of creators filtered by a series id.


```javascript
function getCreatorCollectionBySeriesId(seriesId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, stories, suffix)
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

```javascript


	app.controller("testController", function($scope, CreatorsController, CreatorDataWrapper){
        var seriesId = 'seriesId';
        var comics = 'comics';
        var events = 'events';
        var firstName = 'firstName';
        var firstNameStartsWith = 'firstNameStartsWith';
        var lastName = 'lastName';
        var lastNameStartsWith = 'lastNameStartsWith';
        var limit = 'limit';
        var middleName = 'middleName';
        var middleNameStartsWith = 'middleNameStartsWith';
        var modifiedSince = 'modifiedSince';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var stories = 'stories';
        var suffix = 'suffix';


		var result = CreatorsController.getCreatorCollectionBySeriesId(seriesId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, stories, suffix);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionByStoryId") getCreatorCollectionByStoryId

> Fetches lists of creators filtered by a story id.


```javascript
function getCreatorCollectionByStoryId(storyId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, suffix)
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

```javascript


	app.controller("testController", function($scope, CreatorsController, CreatorDataWrapper){
        var storyId = 'storyId';
        var comics = 'comics';
        var events = 'events';
        var firstName = 'firstName';
        var firstNameStartsWith = 'firstNameStartsWith';
        var lastName = 'lastName';
        var lastNameStartsWith = 'lastNameStartsWith';
        var limit = 'limit';
        var middleName = 'middleName';
        var middleNameStartsWith = 'middleNameStartsWith';
        var modifiedSince = 'modifiedSince';
        var nameStartsWith = 'nameStartsWith';
        var offset = 'offset';
        var orderBy = 'orderBy';
        var series = 'series';
        var suffix = 'suffix';


		var result = CreatorsController.getCreatorCollectionByStoryId(storyId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, suffix);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)



