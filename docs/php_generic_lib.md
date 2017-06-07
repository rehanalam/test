# Getting started

## How to Build

The generated code has dependencies over external libraries like UniRest. These dependencies are defined in the ```composer.json``` file that comes with the SDK. 
To resolve these dependencies, we use the Composer package manager which requires PHP greater than 5.3.2 installed in your system. 
Visit [https://getcomposer.org/download/](https://getcomposer.org/download/) to download the installer file for Composer and run it in your system. 
Open command prompt and type ```composer --version```. This should display the current version of the Composer installed if the installation was successful.

* Using command line, navigate to the directory containing the generated files (including ```composer.json```) for the SDK. 
* Run the command ```composer install```. This should install all the required dependencies and create the ```vendor``` directory in your project directory.

![Building SDK - Step 1](https://apidocs.io/illustration/php?step=installDependencies&workspaceFolder=MarvelComics-PHP)

### [For Windows Users Only] Configuring CURL Certificate Path in php.ini

CURL used to include a list of accepted CAs, but no longer bundles ANY CA certs. So by default it will reject all SSL certificates as unverifiable. You will have to get your CA's cert and point curl at it. The steps are as follows:

1. Download the certificate bundle (.pem file) from [https://curl.haxx.se/docs/caextract.html](https://curl.haxx.se/docs/caextract.html) on to your system.
2. Add curl.cainfo = "PATH_TO/cacert.pem" to your php.ini file located in your php installation. “PATH_TO” must be an absolute path containing the .pem file.

```ini
[curl]
; A default value for the CURLOPT_CAINFO option. This is required to be an
; absolute path.
;curl.cainfo =
```

## How to Use

The following section explains how to use the MarvelComicsLib library in a new project.

### 1. Open Project in an IDE

Open an IDE for PHP like PhpStorm. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.

![Open project in PHPStorm - Step 1](https://apidocs.io/illustration/php?step=openIDE&workspaceFolder=MarvelComics-PHP)

Click on ```Open``` in PhpStorm to browse to your generated SDK directory and then click ```OK```.

![Open project in PHPStorm - Step 2](https://apidocs.io/illustration/php?step=openProject0&workspaceFolder=MarvelComics-PHP)     

### 2. Add a new Test Project

Create a new directory by right clicking on the solution name as shown below:

![Add a new project in PHPStorm - Step 1](https://apidocs.io/illustration/php?step=createDirectory&workspaceFolder=MarvelComics-PHP)

Name the directory as "test"

![Add a new project in PHPStorm - Step 2](https://apidocs.io/illustration/php?step=nameDirectory&workspaceFolder=MarvelComics-PHP)
   
Add a PHP file to this project

![Add a new project in PHPStorm - Step 3](https://apidocs.io/illustration/php?step=createFile&workspaceFolder=MarvelComics-PHP)

Name it "testSDK"

![Add a new project in PHPStorm - Step 4](https://apidocs.io/illustration/php?step=nameFile&workspaceFolder=MarvelComics-PHP)

Depending on your project setup, you might need to include composer's autoloader in your PHP code to enable auto loading of classes.

```PHP
require_once "../vendor/autoload.php";
```

It is important that the path inside require_once correctly points to the file ```autoload.php``` inside the vendor directory created during dependency installations.

![Add a new project in PHPStorm - Step 4](https://apidocs.io/illustration/php?step=projectFiles&workspaceFolder=MarvelComics-PHP)

After this you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

### 3. Run the Test Project

To run your project you must set the Interpreter for your project. Interpreter is the PHP engine installed on your computer.

Open ```Settings``` from ```File``` menu.

![Run Test Project - Step 1](https://apidocs.io/illustration/php?step=openSettings&workspaceFolder=MarvelComics-PHP)

Select ```PHP``` from within ```Languages & Frameworks```

![Run Test Project - Step 2](https://apidocs.io/illustration/php?step=setInterpreter0&workspaceFolder=MarvelComics-PHP)

Browse for Interpreters near the ```Interpreter``` option and choose your interpreter.

![Run Test Project - Step 3](https://apidocs.io/illustration/php?step=setInterpreter1&workspaceFolder=MarvelComics-PHP)

Once the interpreter is selected, click ```OK```

![Run Test Project - Step 4](https://apidocs.io/illustration/php?step=setInterpreter2&workspaceFolder=MarvelComics-PHP)

To run your project, right click on your PHP file inside your Test project and click on ```Run```

![Run Test Project - Step 5](https://apidocs.io/illustration/php?step=runProject&workspaceFolder=MarvelComics-PHP)

## How to Test

Unit tests in this SDK can be run using PHPUnit. 

1. First install the dependencies using composer including the `require-dev` dependencies.
2. Run `vendor\bin\phpunit --verbose` from commandline to execute tests. If you have 
   installed PHPUnit globally, run tests using `phpunit --verbose` instead.

You can change the PHPUnit test configuration in the `phpunit.xml` file.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| referer | TODO: add a description |
| apikey | TODO: add a description |



API client can be initialized as following.

```php
// Configuration parameters and credentials
$referer = "*.marvel.com";
$apikey = "apikey";

$client = new MarvelComicsLib\MarvelComicsLibClient($referer, $apikey);
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

```php
$characters = $client->getCharacters();
```

### <a name="get_character_individual"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getCharacterIndividual") getCharacterIndividual

> Fetches a single character by id.


```php
function getCharacterIndividual($characterId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | A single character id. |



#### Example Usage

```php
$characterId = 'characterId';

$result = $characters->getCharacterIndividual($characterId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Character not found. |



### <a name="get_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getCharacterCollection") getCharacterCollection

> Fetches lists of characters.


```php
function getCharacterCollection(
        $comics = null,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $name = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'name',
        $series = null,
        $stories = null)
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

```php
$comics = 'comics';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$name = 'name';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'name';
$series = 'series';
$stories = 'stories';

$result = $characters->getCharacterCollection($comics, $events, $limit, $modifiedSince, $name, $nameStartsWith, $offset, $orderBy, $series, $stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getComicCharacterCollection") getComicCharacterCollection

> Fetches lists of characters filtered by a comic id.


```php
function getComicCharacterCollection(
        $comicId,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $name = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'name',
        $series = null,
        $stories = null)
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

```php
$comicId = 'comicId';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$name = 'name';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'name';
$series = 'series';
$stories = 'stories';

$result = $characters->getComicCharacterCollection($comicId, $events, $limit, $modifiedSince, $name, $nameStartsWith, $offset, $orderBy, $series, $stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getEventCharacterCollection") getEventCharacterCollection

> Fetches lists of characters filtered by an event id.


```php
function getEventCharacterCollection(
        $eventId,
        $comics = null,
        $limit = null,
        $modifiedSince = null,
        $name = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'name',
        $series = null,
        $stories = null)
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

```php
$eventId = 'eventId';
$comics = 'comics';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$name = 'name';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'name';
$series = 'series';
$stories = 'stories';

$result = $characters->getEventCharacterCollection($eventId, $comics, $limit, $modifiedSince, $name, $nameStartsWith, $offset, $orderBy, $series, $stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_character_wrapper"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getSeriesCharacterWrapper") getSeriesCharacterWrapper

> Fetches lists of characters filtered by a series id.


```php
function getSeriesCharacterWrapper(
        $seriesId,
        $comics = null,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $name = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'name',
        $stories = null)
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

```php
$seriesId = 'seriesId';
$comics = 'comics';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$name = 'name';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'name';
$stories = 'stories';

$result = $characters->getSeriesCharacterWrapper($seriesId, $comics, $events, $limit, $modifiedSince, $name, $nameStartsWith, $offset, $orderBy, $stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_character_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.getCharacterCollectionByStoryId") getCharacterCollectionByStoryId

> Fetches lists of characters filtered by a story id.


```php
function getCharacterCollectionByStoryId(
        $storyId,
        $comics = null,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $name = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'name',
        $series = null)
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

```php
$storyId = 'storyId';
$comics = 'comics';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$name = 'name';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'name';
$series = 'series';

$result = $characters->getCharacterCollectionByStoryId($storyId, $comics, $events, $limit, $modifiedSince, $name, $nameStartsWith, $offset, $orderBy, $series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="comics_controller"></a>![Class: ](https://apidocs.io/img/class.png ".ComicsController") ComicsController

### Get singleton instance

The singleton instance of the ``` ComicsController ``` class can be accessed from the API Client.

```php
$comics = $client->getComics();
```

### <a name="get_comics_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCharacterCollection") getComicsCharacterCollection

> Fetches lists of comics filtered by a character id.


```php
function getComicsCharacterCollection(
        $characterId,
        $collaborators = null,
        $creators = null,
        $dateDescriptor = null,
        $dateRange = null,
        $diamondCode = null,
        $digitalId = null,
        $ean = null,
        $events = null,
        $format = 'comic',
        $formatType = null,
        $hasDigitalIssue = 'true',
        $isbn = null,
        $issn = null,
        $issueNumber = null,
        $limit = null,
        $modifiedSince = null,
        $noVariants = 'true',
        $offset = null,
        $orderBy = 'focDate',
        $series = null,
        $sharedAppearances = null,
        $startYear = null,
        $stories = null,
        $title = null,
        $titleStartsWith = null,
        $upc = null)
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

```php
$characterId = 'characterId';
$collaborators = 'collaborators';
$creators = 'creators';
$dateDescriptor = string::LASTWEEK;
$dateRange = 'dateRange';
$diamondCode = 'diamondCode';
$digitalId = 'digitalId';
$ean = 'ean';
$events = 'events';
$format = 'comic';
$formatType = string::COLLECTION;
$hasDigitalIssue = 'true';
$isbn = 'isbn';
$issn = 'issn';
$issueNumber = 'issueNumber';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$noVariants = 'true';
$offset = 'offset';
$orderBy = 'focDate';
$series = 'series';
$sharedAppearances = 'sharedAppearances';
$startYear = 'startYear';
$stories = 'stories';
$title = 'title';
$titleStartsWith = 'titleStartsWith';
$upc = 'upc';

$result = $comics->getComicsCharacterCollection($characterId, $collaborators, $creators, $dateDescriptor, $dateRange, $diamondCode, $digitalId, $ean, $events, $format, $formatType, $hasDigitalIssue, $isbn, $issn, $issueNumber, $limit, $modifiedSince, $noVariants, $offset, $orderBy, $series, $sharedAppearances, $startYear, $stories, $title, $titleStartsWith, $upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollection") getComicsCollection

> Fetches lists of comics.


```php
function getComicsCollection(
        $characters = null,
        $collaborators = null,
        $creators = null,
        $dateDescriptor = null,
        $dateRange = null,
        $diamondCode = null,
        $digitalId = null,
        $ean = null,
        $events = null,
        $format = 'comic',
        $formatType = null,
        $hasDigitalIssue = 'true',
        $isbn = null,
        $issn = null,
        $issueNumber = null,
        $limit = null,
        $modifiedSince = null,
        $noVariants = 'true',
        $offset = null,
        $orderBy = 'focDate',
        $series = null,
        $sharedAppearances = null,
        $startYear = null,
        $stories = null,
        $title = null,
        $titleStartsWith = null,
        $upc = null)
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

```php
$characters = 'characters';
$collaborators = 'collaborators';
$creators = 'creators';
$dateDescriptor = string::LASTWEEK;
$dateRange = 'dateRange';
$diamondCode = 'diamondCode';
$digitalId = 'digitalId';
$ean = 'ean';
$events = 'events';
$format = 'comic';
$formatType = string::COLLECTION;
$hasDigitalIssue = 'true';
$isbn = 'isbn';
$issn = 'issn';
$issueNumber = 'issueNumber';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$noVariants = 'true';
$offset = 'offset';
$orderBy = 'focDate';
$series = 'series';
$sharedAppearances = 'sharedAppearances';
$startYear = 'startYear';
$stories = 'stories';
$title = 'title';
$titleStartsWith = 'titleStartsWith';
$upc = 'upc';

$result = $comics->getComicsCollection($characters, $collaborators, $creators, $dateDescriptor, $dateRange, $diamondCode, $digitalId, $ean, $events, $format, $formatType, $hasDigitalIssue, $isbn, $issn, $issueNumber, $limit, $modifiedSince, $noVariants, $offset, $orderBy, $series, $sharedAppearances, $startYear, $stories, $title, $titleStartsWith, $upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_individual"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicIndividual") getComicIndividual

> Fetches a single comic by id.


```php
function getComicIndividual($comicId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | A single comic. |



#### Example Usage

```php
$comicId = 'comicId';

$result = $comics->getComicIndividual($comicId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Comic not found. |



### <a name="get_comics_collection_by_creator_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionByCreatorId") getComicsCollectionByCreatorId

> Fetches lists of comics filtered by a creator id.


```php
function getComicsCollectionByCreatorId(
        $creatorId,
        $characters = null,
        $collaborators = null,
        $dateDescriptor = null,
        $dateRange = null,
        $diamondCode = null,
        $digitalId = null,
        $ean = null,
        $events = null,
        $format = 'comic',
        $formatType = null,
        $hasDigitalIssue = 'true',
        $isbn = null,
        $issn = null,
        $issueNumber = null,
        $limit = null,
        $modifiedSince = null,
        $noVariants = 'true',
        $offset = null,
        $orderBy = 'focDate',
        $series = null,
        $sharedAppearances = null,
        $startYear = null,
        $stories = null,
        $title = null,
        $titleStartsWith = null,
        $upc = null)
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

```php
$creatorId = 'creatorId';
$characters = 'characters';
$collaborators = 'collaborators';
$dateDescriptor = string::LASTWEEK;
$dateRange = 'dateRange';
$diamondCode = 'diamondCode';
$digitalId = 'digitalId';
$ean = 'ean';
$events = 'events';
$format = 'comic';
$formatType = string::COLLECTION;
$hasDigitalIssue = 'true';
$isbn = 'isbn';
$issn = 'issn';
$issueNumber = 'issueNumber';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$noVariants = 'true';
$offset = 'offset';
$orderBy = 'focDate';
$series = 'series';
$sharedAppearances = 'sharedAppearances';
$startYear = 'startYear';
$stories = 'stories';
$title = 'title';
$titleStartsWith = 'titleStartsWith';
$upc = 'upc';

$result = $comics->getComicsCollectionByCreatorId($creatorId, $characters, $collaborators, $dateDescriptor, $dateRange, $diamondCode, $digitalId, $ean, $events, $format, $formatType, $hasDigitalIssue, $isbn, $issn, $issueNumber, $limit, $modifiedSince, $noVariants, $offset, $orderBy, $series, $sharedAppearances, $startYear, $stories, $title, $titleStartsWith, $upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionByEventId") getComicsCollectionByEventId

> Fetches lists of comics filtered by an event id.


```php
function getComicsCollectionByEventId(
        $eventId,
        $characters = null,
        $collaborators = null,
        $creators = null,
        $dateDescriptor = null,
        $dateRange = null,
        $diamondCode = null,
        $digitalId = null,
        $ean = null,
        $events = null,
        $format = 'comic',
        $formatType = null,
        $hasDigitalIssue = 'true',
        $isbn = null,
        $issn = null,
        $issueNumber = null,
        $limit = null,
        $modifiedSince = null,
        $noVariants = 'true',
        $offset = null,
        $orderBy = 'focDate',
        $series = null,
        $sharedAppearances = null,
        $startYear = null,
        $stories = null,
        $title = null,
        $titleStartsWith = null,
        $upc = null)
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

```php
$eventId = 'eventId';
$characters = 'characters';
$collaborators = 'collaborators';
$creators = 'creators';
$dateDescriptor = string::LASTWEEK;
$dateRange = 'dateRange';
$diamondCode = 'diamondCode';
$digitalId = 'digitalId';
$ean = 'ean';
$events = 'events';
$format = 'comic';
$formatType = string::COLLECTION;
$hasDigitalIssue = 'true';
$isbn = 'isbn';
$issn = 'issn';
$issueNumber = 'issueNumber';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$noVariants = 'true';
$offset = 'offset';
$orderBy = 'focDate';
$series = 'series';
$sharedAppearances = 'sharedAppearances';
$startYear = 'startYear';
$stories = 'stories';
$title = 'title';
$titleStartsWith = 'titleStartsWith';
$upc = 'upc';

$result = $comics->getComicsCollectionByEventId($eventId, $characters, $collaborators, $creators, $dateDescriptor, $dateRange, $diamondCode, $digitalId, $ean, $events, $format, $formatType, $hasDigitalIssue, $isbn, $issn, $issueNumber, $limit, $modifiedSince, $noVariants, $offset, $orderBy, $series, $sharedAppearances, $startYear, $stories, $title, $titleStartsWith, $upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionBySeriesId") getComicsCollectionBySeriesId

> Fetches lists of comics filtered by a series id.


```php
function getComicsCollectionBySeriesId(
        $seriesId,
        $characters = null,
        $collaborators = null,
        $creators = null,
        $dateDescriptor = null,
        $dateRange = null,
        $diamondCode = null,
        $digitalId = null,
        $ean = null,
        $events = null,
        $format = 'comic',
        $formatType = null,
        $hasDigitalIssue = 'true',
        $isbn = null,
        $issn = null,
        $issueNumber = null,
        $limit = null,
        $modifiedSince = null,
        $noVariants = 'true',
        $offset = null,
        $orderBy = 'focDate',
        $sharedAppearances = null,
        $startYear = null,
        $stories = null,
        $title = null,
        $titleStartsWith = null,
        $upc = null)
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

```php
$seriesId = 'seriesId';
$characters = 'characters';
$collaborators = 'collaborators';
$creators = 'creators';
$dateDescriptor = string::LASTWEEK;
$dateRange = 'dateRange';
$diamondCode = 'diamondCode';
$digitalId = 'digitalId';
$ean = 'ean';
$events = 'events';
$format = 'comic';
$formatType = string::COLLECTION;
$hasDigitalIssue = 'true';
$isbn = 'isbn';
$issn = 'issn';
$issueNumber = 'issueNumber';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$noVariants = 'true';
$offset = 'offset';
$orderBy = 'focDate';
$sharedAppearances = 'sharedAppearances';
$startYear = 'startYear';
$stories = 'stories';
$title = 'title';
$titleStartsWith = 'titleStartsWith';
$upc = 'upc';

$result = $comics->getComicsCollectionBySeriesId($seriesId, $characters, $collaborators, $creators, $dateDescriptor, $dateRange, $diamondCode, $digitalId, $ean, $events, $format, $formatType, $hasDigitalIssue, $isbn, $issn, $issueNumber, $limit, $modifiedSince, $noVariants, $offset, $orderBy, $sharedAppearances, $startYear, $stories, $title, $titleStartsWith, $upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.getComicsCollectionByStoryId") getComicsCollectionByStoryId

> Fetches lists of comics filtered by a story id.


```php
function getComicsCollectionByStoryId(
        $storyId,
        $characters = null,
        $collaborators = null,
        $creators = null,
        $dateDescriptor = null,
        $dateRange = null,
        $diamondCode = null,
        $digitalId = null,
        $ean = null,
        $events = null,
        $format = 'comic',
        $formatType = null,
        $hasDigitalIssue = 'true',
        $isbn = null,
        $issn = null,
        $issueNumber = null,
        $limit = null,
        $modifiedSince = null,
        $noVariants = 'true',
        $offset = null,
        $orderBy = 'focDate',
        $series = null,
        $sharedAppearances = null,
        $startYear = null,
        $title = null,
        $titleStartsWith = null,
        $upc = null)
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

```php
$storyId = 'storyId';
$characters = 'characters';
$collaborators = 'collaborators';
$creators = 'creators';
$dateDescriptor = string::LASTWEEK;
$dateRange = 'dateRange';
$diamondCode = 'diamondCode';
$digitalId = 'digitalId';
$ean = 'ean';
$events = 'events';
$format = 'comic';
$formatType = string::COLLECTION;
$hasDigitalIssue = 'true';
$isbn = 'isbn';
$issn = 'issn';
$issueNumber = 'issueNumber';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$noVariants = 'true';
$offset = 'offset';
$orderBy = 'focDate';
$series = 'series';
$sharedAppearances = 'sharedAppearances';
$startYear = 'startYear';
$title = 'title';
$titleStartsWith = 'titleStartsWith';
$upc = 'upc';

$result = $comics->getComicsCollectionByStoryId($storyId, $characters, $collaborators, $creators, $dateDescriptor, $dateRange, $diamondCode, $digitalId, $ean, $events, $format, $formatType, $hasDigitalIssue, $isbn, $issn, $issueNumber, $limit, $modifiedSince, $noVariants, $offset, $orderBy, $series, $sharedAppearances, $startYear, $title, $titleStartsWith, $upc);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="events_controller"></a>![Class: ](https://apidocs.io/img/class.png ".EventsController") EventsController

### Get singleton instance

The singleton instance of the ``` EventsController ``` class can be accessed from the API Client.

```php
$events = $client->getEvents();
```

### <a name="get_character_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getCharacterEventsCollection") getCharacterEventsCollection

> Fetches lists of events filtered by a character id.


```php
function getCharacterEventsCollection(
        $characterId,
        $comics = null,
        $creators = null,
        $limit = null,
        $modifiedSince = null,
        $name = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'name',
        $series = null,
        $stories = null)
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

```php
$characterId = 'characterId';
$comics = 'comics';
$creators = 'creators';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$name = 'name';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'name';
$series = 'series';
$stories = 'stories';

$result = $events->getCharacterEventsCollection($characterId, $comics, $creators, $limit, $modifiedSince, $name, $nameStartsWith, $offset, $orderBy, $series, $stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_issue_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getIssueEventsCollection") getIssueEventsCollection

> Fetches lists of events filtered by a comic id.


```php
function getIssueEventsCollection(
        $comicId,
        $characters = null,
        $creators = null,
        $limit = null,
        $modifiedSince = null,
        $name = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'name',
        $series = null,
        $stories = null)
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

```php
$comicId = 'comicId';
$characters = 'characters';
$creators = 'creators';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$name = 'name';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'name';
$series = 'series';
$stories = 'stories';

$result = $events->getIssueEventsCollection($comicId, $characters, $creators, $limit, $modifiedSince, $name, $nameStartsWith, $offset, $orderBy, $series, $stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getCreatorEventsCollection") getCreatorEventsCollection

> Fetches lists of events filtered by a creator id.


```php
function getCreatorEventsCollection(
        $creatorId,
        $characters = null,
        $comics = null,
        $limit = null,
        $modifiedSince = null,
        $name = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'name',
        $series = null,
        $stories = null)
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

```php
$creatorId = 'creatorId';
$characters = 'characters';
$comics = 'comics';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$name = 'name';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'name';
$series = 'series';
$stories = 'stories';

$result = $events->getCreatorEventsCollection($creatorId, $characters, $comics, $limit, $modifiedSince, $name, $nameStartsWith, $offset, $orderBy, $series, $stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_individual"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventIndividual") getEventIndividual

> Fetches a single event by id.


```php
function getEventIndividual($eventId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | A single event. |



#### Example Usage

```php
$eventId = 'eventId';

$result = $events->getEventIndividual($eventId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Event not found. |



### <a name="get_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventsCollection") getEventsCollection

> Fetches lists of events.


```php
function getEventsCollection(
        $characters = null,
        $comics = null,
        $creators = null,
        $limit = null,
        $modifiedSince = null,
        $name = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'name',
        $series = null,
        $stories = null)
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

```php
$characters = 'characters';
$comics = 'comics';
$creators = 'creators';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$name = 'name';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'name';
$series = 'series';
$stories = 'stories';

$result = $events->getEventsCollection($characters, $comics, $creators, $limit, $modifiedSince, $name, $nameStartsWith, $offset, $orderBy, $series, $stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_events_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventsCollectionBySeriesId") getEventsCollectionBySeriesId

> Fetches lists of events filtered by a series id.


```php
function getEventsCollectionBySeriesId(
        $seriesId,
        $characters = null,
        $comics = null,
        $creators = null,
        $limit = null,
        $modifiedSince = null,
        $name = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'name',
        $stories = null)
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

```php
$seriesId = 'seriesId';
$characters = 'characters';
$comics = 'comics';
$creators = 'creators';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$name = 'name';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'name';
$stories = 'stories';

$result = $events->getEventsCollectionBySeriesId($seriesId, $characters, $comics, $creators, $limit, $modifiedSince, $name, $nameStartsWith, $offset, $orderBy, $stories);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_events_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.getEventsCollectionByStoryId") getEventsCollectionByStoryId

> Fetches lists of events filtered by a story id.


```php
function getEventsCollectionByStoryId(
        $storyId,
        $characters = null,
        $comics = null,
        $creators = null,
        $limit = null,
        $modifiedSince = null,
        $name = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'name',
        $series = null)
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

```php
$storyId = 'storyId';
$characters = 'characters';
$comics = 'comics';
$creators = 'creators';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$name = 'name';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'name';
$series = 'series';

$result = $events->getEventsCollectionByStoryId($storyId, $characters, $comics, $creators, $limit, $modifiedSince, $name, $nameStartsWith, $offset, $orderBy, $series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="series_controller"></a>![Class: ](https://apidocs.io/img/class.png ".SeriesController") SeriesController

### Get singleton instance

The singleton instance of the ``` SeriesController ``` class can be accessed from the API Client.

```php
$series = $client->getSeries();
```

### <a name="get_character_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getCharacterSeriesCollection") getCharacterSeriesCollection

> Fetches lists of series filtered by a character id.


```php
function getCharacterSeriesCollection(
        $characterId,
        $comics = null,
        $contains = 'comic',
        $creators = null,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $offset = null,
        $orderBy = 'title',
        $seriesType = 'collection',
        $startYear = null,
        $stories = null,
        $title = null,
        $titleStartsWith = null)
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

```php
$characterId = 'characterId';
$comics = 'comics';
$contains = 'comic';
$creators = 'creators';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$offset = 'offset';
$orderBy = 'title';
$seriesType = 'collection';
$startYear = 'startYear';
$stories = 'stories';
$title = 'title';
$titleStartsWith = 'titleStartsWith';

$result = $series->getCharacterSeriesCollection($characterId, $comics, $contains, $creators, $events, $limit, $modifiedSince, $offset, $orderBy, $seriesType, $startYear, $stories, $title, $titleStartsWith);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_individual"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getSeriesIndividual") getSeriesIndividual

> Fetches a single comic series by id.


```php
function getSeriesIndividual($seriesId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | Filter by series title. |



#### Example Usage

```php
$seriesId = 'seriesId';

$result = $series->getSeriesIndividual($seriesId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Series not found. |



### <a name="get_creator_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getCreatorSeriesCollection") getCreatorSeriesCollection

> Fetches lists of series filtered by a creator id.


```php
function getCreatorSeriesCollection(
        $creatorId,
        $characters = null,
        $comics = null,
        $contains = 'comic',
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $offset = null,
        $orderBy = 'title',
        $seriesType = 'collection',
        $startYear = null,
        $stories = null,
        $title = null,
        $titleStartsWith = null)
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

```php
$creatorId = 'creatorId';
$characters = 'characters';
$comics = 'comics';
$contains = 'comic';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$offset = 'offset';
$orderBy = 'title';
$seriesType = 'collection';
$startYear = 'startYear';
$stories = 'stories';
$title = 'title';
$titleStartsWith = 'titleStartsWith';

$result = $series->getCreatorSeriesCollection($creatorId, $characters, $comics, $contains, $events, $limit, $modifiedSince, $offset, $orderBy, $seriesType, $startYear, $stories, $title, $titleStartsWith);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getEventSeriesCollection") getEventSeriesCollection

> Fetches lists of series filtered by an event id.


```php
function getEventSeriesCollection(
        $eventId,
        $characters = null,
        $comics = null,
        $contains = 'comic',
        $creators = null,
        $limit = null,
        $modifiedSince = null,
        $offset = null,
        $orderBy = 'title',
        $seriesType = 'collection',
        $startYear = null,
        $stories = null,
        $title = null,
        $titleStartsWith = null)
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

```php
$eventId = 'eventId';
$characters = 'characters';
$comics = 'comics';
$contains = 'comic';
$creators = 'creators';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$offset = 'offset';
$orderBy = 'title';
$seriesType = 'collection';
$startYear = 'startYear';
$stories = 'stories';
$title = 'title';
$titleStartsWith = 'titleStartsWith';

$result = $series->getEventSeriesCollection($eventId, $characters, $comics, $contains, $creators, $limit, $modifiedSince, $offset, $orderBy, $seriesType, $startYear, $stories, $title, $titleStartsWith);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getSeriesCollection") getSeriesCollection

> Fetches lists of series.


```php
function getSeriesCollection(
        $characters = null,
        $comics = null,
        $contains = 'comic',
        $creators = null,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $offset = null,
        $orderBy = 'title',
        $seriesType = 'collection',
        $startYear = null,
        $stories = null,
        $title = null,
        $titleStartsWith = null)
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

```php
$characters = 'characters';
$comics = 'comics';
$contains = 'comic';
$creators = 'creators';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$offset = 'offset';
$orderBy = 'title';
$seriesType = 'collection';
$startYear = 'startYear';
$stories = 'stories';
$title = 'title';
$titleStartsWith = 'titleStartsWith';

$result = $series->getSeriesCollection($characters, $comics, $contains, $creators, $events, $limit, $modifiedSince, $offset, $orderBy, $seriesType, $startYear, $stories, $title, $titleStartsWith);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.getStorySeriesCollection") getStorySeriesCollection

> Fetches lists of series filtered by a story id.


```php
function getStorySeriesCollection(
        $storyId,
        $characters = null,
        $comics = null,
        $contains = 'comic',
        $creators = null,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $offset = null,
        $orderBy = 'title',
        $seriesType = 'collection',
        $startYear = null,
        $title = null,
        $titleStartsWith = null)
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

```php
$storyId = 'storyId';
$characters = 'characters';
$comics = 'comics';
$contains = 'comic';
$creators = 'creators';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$offset = 'offset';
$orderBy = 'title';
$seriesType = 'collection';
$startYear = 'startYear';
$title = 'title';
$titleStartsWith = 'titleStartsWith';

$result = $series->getStorySeriesCollection($storyId, $characters, $comics, $contains, $creators, $events, $limit, $modifiedSince, $offset, $orderBy, $seriesType, $startYear, $title, $titleStartsWith);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="stories_controller"></a>![Class: ](https://apidocs.io/img/class.png ".StoriesController") StoriesController

### Get singleton instance

The singleton instance of the ``` StoriesController ``` class can be accessed from the API Client.

```php
$stories = $client->getStories();
```

### <a name="get_character_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getCharacterStoryCollection") getCharacterStoryCollection

> Fetches lists of stories filtered by a character id.


```php
function getCharacterStoryCollection(
        $characterId,
        $comics = null,
        $creators = null,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $offset = null,
        $orderBy = 'id',
        $series = null)
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

```php
$characterId = 'characterId';
$comics = 'comics';
$creators = 'creators';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$offset = 'offset';
$orderBy = 'id';
$series = 'series';

$result = $stories->getCharacterStoryCollection($characterId, $comics, $creators, $events, $limit, $modifiedSince, $offset, $orderBy, $series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_story_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getComicStoryCollectionByComicId") getComicStoryCollectionByComicId

> Fetches lists of stories filtered by a comic id.


```php
function getComicStoryCollectionByComicId(
        $comicId,
        $characters = null,
        $creators = null,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $offset = null,
        $orderBy = 'id',
        $series = null)
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

```php
$comicId = 'comicId';
$characters = 'characters';
$creators = 'creators';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$offset = 'offset';
$orderBy = 'id';
$series = 'series';

$result = $stories->getComicStoryCollectionByComicId($comicId, $characters, $creators, $events, $limit, $modifiedSince, $offset, $orderBy, $series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getCreatorStoryCollection") getCreatorStoryCollection

> Fetches lists of stories filtered by a creator id.


```php
function getCreatorStoryCollection(
        $creatorId,
        $characters = null,
        $comics = null,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $offset = null,
        $orderBy = 'id',
        $series = null)
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

```php
$creatorId = 'creatorId';
$characters = 'characters';
$comics = 'comics';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$offset = 'offset';
$orderBy = 'id';
$series = 'series';

$result = $stories->getCreatorStoryCollection($creatorId, $characters, $comics, $events, $limit, $modifiedSince, $offset, $orderBy, $series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_individual"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getStoryIndividual") getStoryIndividual

> Fetches a single comic story by id.


```php
function getStoryIndividual($storyId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | Filter by story id. |



#### Example Usage

```php
$storyId = 'storyId';

$result = $stories->getStoryIndividual($storyId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Story not found. |



### <a name="get_event_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getEventStoryCollection") getEventStoryCollection

> Fetches lists of stories filtered by an event id.


```php
function getEventStoryCollection(
        $eventId,
        $characters = null,
        $comics = null,
        $creators = null,
        $limit = null,
        $modifiedSince = null,
        $offset = null,
        $orderBy = 'id',
        $series = null)
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

```php
$eventId = 'eventId';
$characters = 'characters';
$comics = 'comics';
$creators = 'creators';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$offset = 'offset';
$orderBy = 'id';
$series = 'series';

$result = $stories->getEventStoryCollection($eventId, $characters, $comics, $creators, $limit, $modifiedSince, $offset, $orderBy, $series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getSeriesStoryCollection") getSeriesStoryCollection

> Fetches lists of stories filtered by a series id.


```php
function getSeriesStoryCollection(
        $seriesId,
        $characters = null,
        $comics = null,
        $creators = null,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $offset = null,
        $orderBy = 'id')
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

```php
$seriesId = 'seriesId';
$characters = 'characters';
$comics = 'comics';
$creators = 'creators';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$offset = 'offset';
$orderBy = 'id';

$result = $stories->getSeriesStoryCollection($seriesId, $characters, $comics, $creators, $events, $limit, $modifiedSince, $offset, $orderBy);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.getStoryCollection") getStoryCollection

> Fetches lists of stories.


```php
function getStoryCollection(
        $characters = null,
        $comics = null,
        $creators = null,
        $events = null,
        $limit = null,
        $modifiedSince = null,
        $offset = null,
        $orderBy = 'id',
        $series = null)
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

```php
$characters = 'characters';
$comics = 'comics';
$creators = 'creators';
$events = 'events';
$limit = 'limit';
$modifiedSince = 'modifiedSince';
$offset = 'offset';
$orderBy = 'id';
$series = 'series';

$result = $stories->getStoryCollection($characters, $comics, $creators, $events, $limit, $modifiedSince, $offset, $orderBy, $series);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="creators_controller"></a>![Class: ](https://apidocs.io/img/class.png ".CreatorsController") CreatorsController

### Get singleton instance

The singleton instance of the ``` CreatorsController ``` class can be accessed from the API Client.

```php
$creators = $client->getCreators();
```

### <a name="get_creator_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionByComicId") getCreatorCollectionByComicId

> Fetches lists of creators filtered by a comic id.


```php
function getCreatorCollectionByComicId(
        $comicId,
        $comics = null,
        $firstName = null,
        $firstNameStartsWith = null,
        $lastName = null,
        $lastNameStartsWith = null,
        $limit = null,
        $middleName = null,
        $middleNameStartsWith = null,
        $modifiedSince = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'lastName',
        $series = null,
        $stories = null,
        $suffix = null)
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

```php
$comicId = 'comicId';
$comics = 'comics';
$firstName = 'firstName';
$firstNameStartsWith = 'firstNameStartsWith';
$lastName = 'lastName';
$lastNameStartsWith = 'lastNameStartsWith';
$limit = 'limit';
$middleName = 'middleName';
$middleNameStartsWith = 'middleNameStartsWith';
$modifiedSince = 'modifiedSince';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'lastName';
$series = 'series';
$stories = 'stories';
$suffix = 'suffix';

$result = $creators->getCreatorCollectionByComicId($comicId, $comics, $firstName, $firstNameStartsWith, $lastName, $lastNameStartsWith, $limit, $middleName, $middleNameStartsWith, $modifiedSince, $nameStartsWith, $offset, $orderBy, $series, $stories, $suffix);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollection") getCreatorCollection

> Fetches lists of creators.


```php
function getCreatorCollection(
        $comics = null,
        $events = null,
        $firstName = null,
        $firstNameStartsWith = null,
        $lastName = null,
        $lastNameStartsWith = null,
        $limit = null,
        $middleName = null,
        $middleNameStartsWith = null,
        $modifiedSince = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'lastName',
        $series = null,
        $stories = null,
        $suffix = null)
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

```php
$comics = 'comics';
$events = 'events';
$firstName = 'firstName';
$firstNameStartsWith = 'firstNameStartsWith';
$lastName = 'lastName';
$lastNameStartsWith = 'lastNameStartsWith';
$limit = 'limit';
$middleName = 'middleName';
$middleNameStartsWith = 'middleNameStartsWith';
$modifiedSince = 'modifiedSince';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'lastName';
$series = 'series';
$stories = 'stories';
$suffix = 'suffix';

$result = $creators->getCreatorCollection($comics, $events, $firstName, $firstNameStartsWith, $lastName, $lastNameStartsWith, $limit, $middleName, $middleNameStartsWith, $modifiedSince, $nameStartsWith, $offset, $orderBy, $series, $stories, $suffix);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_individual"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorIndividual") getCreatorIndividual

> Fetches a single creator by id.


```php
function getCreatorIndividual($creatorId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | A single creator id. |



#### Example Usage

```php
$creatorId = 'creatorId';

$result = $creators->getCreatorIndividual($creatorId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Creator not found. |



### <a name="get_creator_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionByEventId") getCreatorCollectionByEventId

> Fetches lists of creators filtered by an event id.


```php
function getCreatorCollectionByEventId(
        $eventId,
        $comics = null,
        $firstName = null,
        $firstNameStartsWith = null,
        $lastName = null,
        $lastNameStartsWith = null,
        $limit = null,
        $middleName = null,
        $middleNameStartsWith = null,
        $modifiedSince = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'lastName',
        $series = null,
        $stories = null,
        $suffix = null)
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

```php
$eventId = 'eventId';
$comics = 'comics';
$firstName = 'firstName';
$firstNameStartsWith = 'firstNameStartsWith';
$lastName = 'lastName';
$lastNameStartsWith = 'lastNameStartsWith';
$limit = 'limit';
$middleName = 'middleName';
$middleNameStartsWith = 'middleNameStartsWith';
$modifiedSince = 'modifiedSince';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'lastName';
$series = 'series';
$stories = 'stories';
$suffix = 'suffix';

$result = $creators->getCreatorCollectionByEventId($eventId, $comics, $firstName, $firstNameStartsWith, $lastName, $lastNameStartsWith, $limit, $middleName, $middleNameStartsWith, $modifiedSince, $nameStartsWith, $offset, $orderBy, $series, $stories, $suffix);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionBySeriesId") getCreatorCollectionBySeriesId

> Fetches lists of creators filtered by a series id.


```php
function getCreatorCollectionBySeriesId(
        $seriesId,
        $comics = null,
        $events = null,
        $firstName = null,
        $firstNameStartsWith = null,
        $lastName = null,
        $lastNameStartsWith = null,
        $limit = null,
        $middleName = null,
        $middleNameStartsWith = null,
        $modifiedSince = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'lastName',
        $stories = null,
        $suffix = null)
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

```php
$seriesId = 'seriesId';
$comics = 'comics';
$events = 'events';
$firstName = 'firstName';
$firstNameStartsWith = 'firstNameStartsWith';
$lastName = 'lastName';
$lastNameStartsWith = 'lastNameStartsWith';
$limit = 'limit';
$middleName = 'middleName';
$middleNameStartsWith = 'middleNameStartsWith';
$modifiedSince = 'modifiedSince';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'lastName';
$stories = 'stories';
$suffix = 'suffix';

$result = $creators->getCreatorCollectionBySeriesId($seriesId, $comics, $events, $firstName, $firstNameStartsWith, $lastName, $lastNameStartsWith, $limit, $middleName, $middleNameStartsWith, $modifiedSince, $nameStartsWith, $offset, $orderBy, $stories, $suffix);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.getCreatorCollectionByStoryId") getCreatorCollectionByStoryId

> Fetches lists of creators filtered by a story id.


```php
function getCreatorCollectionByStoryId(
        $storyId,
        $comics = null,
        $events = null,
        $firstName = null,
        $firstNameStartsWith = null,
        $lastName = null,
        $lastNameStartsWith = null,
        $limit = null,
        $middleName = null,
        $middleNameStartsWith = null,
        $modifiedSince = null,
        $nameStartsWith = null,
        $offset = null,
        $orderBy = 'lastName',
        $series = null,
        $suffix = null)
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

```php
$storyId = 'storyId';
$comics = 'comics';
$events = 'events';
$firstName = 'firstName';
$firstNameStartsWith = 'firstNameStartsWith';
$lastName = 'lastName';
$lastNameStartsWith = 'lastNameStartsWith';
$limit = 'limit';
$middleName = 'middleName';
$middleNameStartsWith = 'middleNameStartsWith';
$modifiedSince = 'modifiedSince';
$nameStartsWith = 'nameStartsWith';
$offset = 'offset';
$orderBy = 'lastName';
$series = 'series';
$suffix = 'suffix';

$result = $creators->getCreatorCollectionByStoryId($storyId, $comics, $events, $firstName, $firstNameStartsWith, $lastName, $lastNameStartsWith, $limit, $middleName, $middleNameStartsWith, $modifiedSince, $nameStartsWith, $offset, $orderBy, $series, $suffix);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)



