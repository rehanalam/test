# Getting started

## How to Build

The generated SDK relies on [Node Package Manager](https://www.npmjs.com/) (NPM) being available to resolve dependencies. If you don't already have NPM installed, please go ahead and follow instructions to install NPM from [here](https://nodejs.org/en/download/).
The SDK also requires Node to be installed. If Node isn't already installed, please install it from [here](https://nodejs.org/en/download/)
> NPM is installed by default when Node is installed

To check if node and npm have been successfully installed, write the following commands in command prompt:
* `node --version`
* `npm -version` 
![Version Check](https://apidocs.io/illustration/nodejs?step=versionCheck&workspaceFolder=MarvelComics-Node)  

Now use npm to resolve all dependencies by running the following command in the root directory (of the SDK folder):
* `npm install`
![Resolve Dependencies](https://apidocs.io/illustration/nodejs?step=resolveDependency1&workspaceFolder=MarvelComics-Node)
![Resolve Dependencies](https://apidocs.io/illustration/nodejs?step=resolveDependency2)

This will install all dependencies in the `node_modules` folder. 

Once dependencies are resolved, you will need to move the folder `MarvelComicsLib ` in to your `node_modules` folder.

## How to Use

The following section explains how to use the library in a new project.

### 1. Open Project Folder
Open an IDE/Text Editor for JavaScript like Sublime Text. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.  
Click on `File` and select `Open Folder`
![Open Folder](https://apidocs.io/illustration/nodejs?step=openFolder)

Select the folder of your SDK and click on `Select Folder` to open it up in Sublime Text. The folder will become visible in the bar on the left.
![Open Project](https://apidocs.io/illustration/nodejs?step=openProject&workspaceFolder=MarvelComics-Node)


### 2. Creating a Test File
Now right click on the folder name and select the `New File` option to create a new test file.    Save it as `index.js` Now import the generated NodeJS library using the following lines of code:
```JavaScript
var lib = require('lib');
```
Save changes.

![Create new file](https://apidocs.io/illustration/nodejs?step=createNewFile&workspaceFolder=MarvelComics-Node)
![Save new file](https://apidocs.io/illustration/nodejs?step=saveNewFile&workspaceFolder=MarvelComics-Node)

### 3. Running The Test File
To run the `index.js` file, open up the command prompt and navigate to the Path where the SDK folder resides. Type the following command to run the file:  
`node index.js`
![Run file](https://apidocs.io/illustration/nodejs?step=runProject&workspaceFolder=MarvelComics-Node)


## How to Test

These tests use Mocha framework for testing, coupled with Chai for assertions. These dependencies need to be installed for tests to run.
Tests can be run in a number of ways:

### Method 1 
###### (Run all tests)

1. Navigate to the root directory of the SDK folder from command prompt.
2. Type `mocha --recursive` to run all the tests.

### Method 2
###### (Run all tests)

1. Navigate to the `../test/Controllers/` directory from command prompt.
2. Type `mocha *` to run all the tests.

### Method 3
###### (Run specific controller's tests)

1. Navigate to the `../test/Controllers/` directory from command prompt.
2. Type `mocha  MarvelComicsController`  to run all the tests in that controller file.

> To increase mocha's default timeout, you can change the `TEST_TIMEOUT` parameter's value in `TestBootstrap.js`.  

![Run Tests](https://apidocs.io/illustration/nodejs?step=runTests&controllerName=MarvelComicsController)

## Initialization

### Authentication
In order to setup authentication in the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| referer | TODO: add a description |
| apikey | TODO: add a description |



API client can be initialized as following:

```JavaScript
var lib = require('lib');

// Configuration parameters and credentials
lib.Configuration.referer = "*.marvel.com";
lib.Configuration.apikey = "apikey";

```

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

The singleton instance of the ``` CharactersController ``` class can be accessed from the API Client.

```javascript
var controller = lib.CharactersController;
```

### <a name="get_character_individual"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getCharacterIndividual") getCharacterIndividual

> Fetches a single character by id.


```javascript
function getCharacterIndividual(characterId, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | A single character id. |



#### Example Usage

```javascript

    var characterId = 'characterId';

    controller.getCharacterIndividual(characterId, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Character not found. |




### <a name="get_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getCharacterCollection") getCharacterCollection

> Fetches lists of characters.


```javascript
function getCharacterCollection(comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, callback)
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

    controller.getCharacterCollection(comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comic_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getComicCharacterCollection") getComicCharacterCollection

> Fetches lists of characters filtered by a comic id.


```javascript
function getComicCharacterCollection(comicId, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, callback)
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

    controller.getComicCharacterCollection(comicId, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_event_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getEventCharacterCollection") getEventCharacterCollection

> Fetches lists of characters filtered by an event id.


```javascript
function getEventCharacterCollection(eventId, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, callback)
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

    controller.getEventCharacterCollection(eventId, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_character_wrapper"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getSeriesCharacterWrapper") getSeriesCharacterWrapper

> Fetches lists of characters filtered by a series id.


```javascript
function getSeriesCharacterWrapper(seriesId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories, callback)
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

    controller.getSeriesCharacterWrapper(seriesId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_character_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getCharacterCollectionByStoryId") getCharacterCollectionByStoryId

> Fetches lists of characters filtered by a story id.


```javascript
function getCharacterCollectionByStoryId(storyId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, callback)
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

    controller.getCharacterCollectionByStoryId(storyId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="comics_controller"></a>![Class: ](https://apidocs.io/img/class.png ".ComicsController") ComicsController

### Get singleton instance

The singleton instance of the ``` ComicsController ``` class can be accessed from the API Client.

```javascript
var controller = lib.ComicsController;
```

### <a name="get_comics_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCharacterCollection") getComicsCharacterCollection

> Fetches lists of comics filtered by a character id.


```javascript
function getComicsCharacterCollection(characterId, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, callback)
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

    var characterId = 'characterId';
    var collaborators = 'collaborators';
    var creators = 'creators';
    var dateDescriptor = Object.keys(dateDescriptor)[0];
    var dateRange = 'dateRange';
    var diamondCode = 'diamondCode';
    var digitalId = 'digitalId';
    var ean = 'ean';
    var events = 'events';
    var format = 'format';
    var formatType = Object.keys(formatType)[0];
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

    controller.getComicsCharacterCollection(characterId, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollection") getComicsCollection

> Fetches lists of comics.


```javascript
function getComicsCollection(characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, callback)
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

    var characters = 'characters';
    var collaborators = 'collaborators';
    var creators = 'creators';
    var dateDescriptor = Object.keys(dateDescriptor)[0];
    var dateRange = 'dateRange';
    var diamondCode = 'diamondCode';
    var digitalId = 'digitalId';
    var ean = 'ean';
    var events = 'events';
    var format = 'format';
    var formatType = Object.keys(formatType)[0];
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

    controller.getComicsCollection(characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comic_individual"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicIndividual") getComicIndividual

> Fetches a single comic by id.


```javascript
function getComicIndividual(comicId, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | A single comic. |



#### Example Usage

```javascript

    var comicId = 'comicId';

    controller.getComicIndividual(comicId, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Comic not found. |




### <a name="get_comics_collection_by_creator_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionByCreatorId") getComicsCollectionByCreatorId

> Fetches lists of comics filtered by a creator id.


```javascript
function getComicsCollectionByCreatorId(creatorId, characters, collaborators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, callback)
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

    var creatorId = 'creatorId';
    var characters = 'characters';
    var collaborators = 'collaborators';
    var dateDescriptor = Object.keys(dateDescriptor)[0];
    var dateRange = 'dateRange';
    var diamondCode = 'diamondCode';
    var digitalId = 'digitalId';
    var ean = 'ean';
    var events = 'events';
    var format = 'format';
    var formatType = Object.keys(formatType)[0];
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

    controller.getComicsCollectionByCreatorId(creatorId, characters, collaborators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionByEventId") getComicsCollectionByEventId

> Fetches lists of comics filtered by an event id.


```javascript
function getComicsCollectionByEventId(eventId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, callback)
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

    var eventId = 'eventId';
    var characters = 'characters';
    var collaborators = 'collaborators';
    var creators = 'creators';
    var dateDescriptor = Object.keys(dateDescriptor)[0];
    var dateRange = 'dateRange';
    var diamondCode = 'diamondCode';
    var digitalId = 'digitalId';
    var ean = 'ean';
    var events = 'events';
    var format = 'format';
    var formatType = Object.keys(formatType)[0];
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

    controller.getComicsCollectionByEventId(eventId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionBySeriesId") getComicsCollectionBySeriesId

> Fetches lists of comics filtered by a series id.


```javascript
function getComicsCollectionBySeriesId(seriesId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, sharedAppearances, startYear, stories, title, titleStartsWith, upc, callback)
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

    var seriesId = 'seriesId';
    var characters = 'characters';
    var collaborators = 'collaborators';
    var creators = 'creators';
    var dateDescriptor = Object.keys(dateDescriptor)[0];
    var dateRange = 'dateRange';
    var diamondCode = 'diamondCode';
    var digitalId = 'digitalId';
    var ean = 'ean';
    var events = 'events';
    var format = 'format';
    var formatType = Object.keys(formatType)[0];
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

    controller.getComicsCollectionBySeriesId(seriesId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, sharedAppearances, startYear, stories, title, titleStartsWith, upc, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionByStoryId") getComicsCollectionByStoryId

> Fetches lists of comics filtered by a story id.


```javascript
function getComicsCollectionByStoryId(storyId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, title, titleStartsWith, upc, callback)
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

    var storyId = 'storyId';
    var characters = 'characters';
    var collaborators = 'collaborators';
    var creators = 'creators';
    var dateDescriptor = Object.keys(dateDescriptor)[0];
    var dateRange = 'dateRange';
    var diamondCode = 'diamondCode';
    var digitalId = 'digitalId';
    var ean = 'ean';
    var events = 'events';
    var format = 'format';
    var formatType = Object.keys(formatType)[0];
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

    controller.getComicsCollectionByStoryId(storyId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, title, titleStartsWith, upc, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="events_controller"></a>![Class: ](https://apidocs.io/img/class.png ".EventsController") EventsController

### Get singleton instance

The singleton instance of the ``` EventsController ``` class can be accessed from the API Client.

```javascript
var controller = lib.EventsController;
```

### <a name="get_character_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getCharacterEventsCollection") getCharacterEventsCollection

> Fetches lists of events filtered by a character id.


```javascript
function getCharacterEventsCollection(characterId, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, callback)
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

    controller.getCharacterEventsCollection(characterId, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_issue_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getIssueEventsCollection") getIssueEventsCollection

> Fetches lists of events filtered by a comic id.


```javascript
function getIssueEventsCollection(comicId, characters, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, callback)
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

    controller.getIssueEventsCollection(comicId, characters, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getCreatorEventsCollection") getCreatorEventsCollection

> Fetches lists of events filtered by a creator id.


```javascript
function getCreatorEventsCollection(creatorId, characters, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, callback)
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

    controller.getCreatorEventsCollection(creatorId, characters, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_event_individual"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventIndividual") getEventIndividual

> Fetches a single event by id.


```javascript
function getEventIndividual(eventId, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | A single event. |



#### Example Usage

```javascript

    var eventId = 'eventId';

    controller.getEventIndividual(eventId, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Event not found. |




### <a name="get_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventsCollection") getEventsCollection

> Fetches lists of events.


```javascript
function getEventsCollection(characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, callback)
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

    controller.getEventsCollection(characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_events_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventsCollectionBySeriesId") getEventsCollectionBySeriesId

> Fetches lists of events filtered by a series id.


```javascript
function getEventsCollectionBySeriesId(seriesId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories, callback)
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

    controller.getEventsCollectionBySeriesId(seriesId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_events_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventsCollectionByStoryId") getEventsCollectionByStoryId

> Fetches lists of events filtered by a story id.


```javascript
function getEventsCollectionByStoryId(storyId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, callback)
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

    controller.getEventsCollectionByStoryId(storyId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="series_controller"></a>![Class: ](https://apidocs.io/img/class.png ".SeriesController") SeriesController

### Get singleton instance

The singleton instance of the ``` SeriesController ``` class can be accessed from the API Client.

```javascript
var controller = lib.SeriesController;
```

### <a name="get_character_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getCharacterSeriesCollection") getCharacterSeriesCollection

> Fetches lists of series filtered by a character id.


```javascript
function getCharacterSeriesCollection(characterId, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, callback)
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

    controller.getCharacterSeriesCollection(characterId, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_individual"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getSeriesIndividual") getSeriesIndividual

> Fetches a single comic series by id.


```javascript
function getSeriesIndividual(seriesId, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | Filter by series title. |



#### Example Usage

```javascript

    var seriesId = 'seriesId';

    controller.getSeriesIndividual(seriesId, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Series not found. |




### <a name="get_creator_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getCreatorSeriesCollection") getCreatorSeriesCollection

> Fetches lists of series filtered by a creator id.


```javascript
function getCreatorSeriesCollection(creatorId, characters, comics, contains, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, callback)
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

    controller.getCreatorSeriesCollection(creatorId, characters, comics, contains, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_event_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getEventSeriesCollection") getEventSeriesCollection

> Fetches lists of series filtered by an event id.


```javascript
function getEventSeriesCollection(eventId, characters, comics, contains, creators, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, callback)
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

    controller.getEventSeriesCollection(eventId, characters, comics, contains, creators, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getSeriesCollection") getSeriesCollection

> Fetches lists of series.


```javascript
function getSeriesCollection(characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, callback)
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

    controller.getSeriesCollection(characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_story_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getStorySeriesCollection") getStorySeriesCollection

> Fetches lists of series filtered by a story id.


```javascript
function getStorySeriesCollection(storyId, characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, title, titleStartsWith, callback)
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

    controller.getStorySeriesCollection(storyId, characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, title, titleStartsWith, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="stories_controller"></a>![Class: ](https://apidocs.io/img/class.png ".StoriesController") StoriesController

### Get singleton instance

The singleton instance of the ``` StoriesController ``` class can be accessed from the API Client.

```javascript
var controller = lib.StoriesController;
```

### <a name="get_character_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getCharacterStoryCollection") getCharacterStoryCollection

> Fetches lists of stories filtered by a character id.


```javascript
function getCharacterStoryCollection(characterId, comics, creators, events, limit, modifiedSince, offset, orderBy, series, callback)
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

    var characterId = 'characterId';
    var comics = 'comics';
    var creators = 'creators';
    var events = 'events';
    var limit = 'limit';
    var modifiedSince = 'modifiedSince';
    var offset = 'offset';
    var orderBy = 'orderBy';
    var series = 'series';

    controller.getCharacterStoryCollection(characterId, comics, creators, events, limit, modifiedSince, offset, orderBy, series, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comic_story_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getComicStoryCollectionByComicId") getComicStoryCollectionByComicId

> Fetches lists of stories filtered by a comic id.


```javascript
function getComicStoryCollectionByComicId(comicId, characters, creators, events, limit, modifiedSince, offset, orderBy, series, callback)
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

    var comicId = 'comicId';
    var characters = 'characters';
    var creators = 'creators';
    var events = 'events';
    var limit = 'limit';
    var modifiedSince = 'modifiedSince';
    var offset = 'offset';
    var orderBy = 'orderBy';
    var series = 'series';

    controller.getComicStoryCollectionByComicId(comicId, characters, creators, events, limit, modifiedSince, offset, orderBy, series, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getCreatorStoryCollection") getCreatorStoryCollection

> Fetches lists of stories filtered by a creator id.


```javascript
function getCreatorStoryCollection(creatorId, characters, comics, events, limit, modifiedSince, offset, orderBy, series, callback)
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

    var creatorId = 'creatorId';
    var characters = 'characters';
    var comics = 'comics';
    var events = 'events';
    var limit = 'limit';
    var modifiedSince = 'modifiedSince';
    var offset = 'offset';
    var orderBy = 'orderBy';
    var series = 'series';

    controller.getCreatorStoryCollection(creatorId, characters, comics, events, limit, modifiedSince, offset, orderBy, series, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_story_individual"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getStoryIndividual") getStoryIndividual

> Fetches a single comic story by id.


```javascript
function getStoryIndividual(storyId, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | Filter by story id. |



#### Example Usage

```javascript

    var storyId = 'storyId';

    controller.getStoryIndividual(storyId, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Story not found. |




### <a name="get_event_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getEventStoryCollection") getEventStoryCollection

> Fetches lists of stories filtered by an event id.


```javascript
function getEventStoryCollection(eventId, characters, comics, creators, limit, modifiedSince, offset, orderBy, series, callback)
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

    var eventId = 'eventId';
    var characters = 'characters';
    var comics = 'comics';
    var creators = 'creators';
    var limit = 'limit';
    var modifiedSince = 'modifiedSince';
    var offset = 'offset';
    var orderBy = 'orderBy';
    var series = 'series';

    controller.getEventStoryCollection(eventId, characters, comics, creators, limit, modifiedSince, offset, orderBy, series, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getSeriesStoryCollection") getSeriesStoryCollection

> Fetches lists of stories filtered by a series id.


```javascript
function getSeriesStoryCollection(seriesId, characters, comics, creators, events, limit, modifiedSince, offset, orderBy, callback)
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

    var seriesId = 'seriesId';
    var characters = 'characters';
    var comics = 'comics';
    var creators = 'creators';
    var events = 'events';
    var limit = 'limit';
    var modifiedSince = 'modifiedSince';
    var offset = 'offset';
    var orderBy = 'orderBy';

    controller.getSeriesStoryCollection(seriesId, characters, comics, creators, events, limit, modifiedSince, offset, orderBy, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getStoryCollection") getStoryCollection

> Fetches lists of stories.


```javascript
function getStoryCollection(characters, comics, creators, events, limit, modifiedSince, offset, orderBy, series, callback)
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

    var characters = 'characters';
    var comics = 'comics';
    var creators = 'creators';
    var events = 'events';
    var limit = 'limit';
    var modifiedSince = 'modifiedSince';
    var offset = 'offset';
    var orderBy = 'orderBy';
    var series = 'series';

    controller.getStoryCollection(characters, comics, creators, events, limit, modifiedSince, offset, orderBy, series, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="creators_controller"></a>![Class: ](https://apidocs.io/img/class.png ".CreatorsController") CreatorsController

### Get singleton instance

The singleton instance of the ``` CreatorsController ``` class can be accessed from the API Client.

```javascript
var controller = lib.CreatorsController;
```

### <a name="get_creator_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionByComicId") getCreatorCollectionByComicId

> Fetches lists of creators filtered by a comic id.


```javascript
function getCreatorCollectionByComicId(comicId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix, callback)
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

    controller.getCreatorCollectionByComicId(comicId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollection") getCreatorCollection

> Fetches lists of creators.


```javascript
function getCreatorCollection(comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix, callback)
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

    controller.getCreatorCollection(comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_individual"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorIndividual") getCreatorIndividual

> Fetches a single creator by id.


```javascript
function getCreatorIndividual(creatorId, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | A single creator id. |



#### Example Usage

```javascript

    var creatorId = 'creatorId';

    controller.getCreatorIndividual(creatorId, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Creator not found. |




### <a name="get_creator_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionByEventId") getCreatorCollectionByEventId

> Fetches lists of creators filtered by an event id.


```javascript
function getCreatorCollectionByEventId(eventId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix, callback)
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

    controller.getCreatorCollectionByEventId(eventId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionBySeriesId") getCreatorCollectionBySeriesId

> Fetches lists of creators filtered by a series id.


```javascript
function getCreatorCollectionBySeriesId(seriesId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, stories, suffix, callback)
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

    controller.getCreatorCollectionBySeriesId(seriesId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, stories, suffix, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionByStoryId") getCreatorCollectionByStoryId

> Fetches lists of creators filtered by a story id.


```javascript
function getCreatorCollectionByStoryId(storyId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, suffix, callback)
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

    controller.getCreatorCollectionByStoryId(storyId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, suffix, function(error, response, context) {

    
	});
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)



